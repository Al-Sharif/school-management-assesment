using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SchoolManagement.Infrastructure.Authentication;
using SchoolManagement.Infrastructure.Models;
using SchoolManagement.Infrastructure.Services;
using SchoolManagement.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanResourceController : ControllerBase
    {
        private readonly IRegistrationRequestService _registrationRequestService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public HumanResourceController(IRegistrationRequestService registrationRequestService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _registrationRequestService = registrationRequestService;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpGet]
        [Authorize(Roles = UserRoles.HumanResource)]
        [Route("PendingRequests/{pageSize}/{pageNumber}")]
        public ActionResult GetPendingRequests(int pageSize, int pageNumber)
        {
            var requests = _registrationRequestService.GetPendingRequests(pageSize, pageNumber);
            var recordsCount = _registrationRequestService.GetPendingRequestsCount();
            return Ok(new { requests, recordsCount });
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("AddRequest")]
        public ActionResult AddRequest([FromBody] RequestInputModel input)
        {
            var key = _configuration.GetValue<string>("AesOperation:Key");
            input.Password = AesOperation.EncryptString(key, input.Password);
            bool isSucceeded = _registrationRequestService.Add(input);
            if (isSucceeded)
            {
                return Ok();
            }
            return BadRequest("Student email already exist.");
        }

        [HttpPut]
        [Route("UpdateStatus/{id}/{approved}")]
        [Authorize(Roles = UserRoles.HumanResource)]
        public async Task<IActionResult> UpdateStatus(int id, bool approved)
        {
            var key = _configuration.GetValue<string>("AesOperation:Key");
            var currentRequest = _registrationRequestService.GetById(id);
            if (currentRequest != null && approved)
            {
                var userExists = await _userManager.FindByEmailAsync(currentRequest.Email);
                if (userExists != null)
                    return StatusCode(StatusCodes.Status400BadRequest, new { Status = "Error", Message = "User already exists!" });

                ApplicationUser user = new ApplicationUser()
                {
                    Email = currentRequest.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = currentRequest.Email,
                    FirstName = currentRequest.FirstName,
                    LastName = currentRequest.LastName
                };
                currentRequest.HashPassword = AesOperation.DecryptString(key, currentRequest.HashPassword);
                var result = await _userManager.CreateAsync(user, currentRequest.HashPassword);
                if (!result.Succeeded)
                    return StatusCode(StatusCodes.Status400BadRequest, new { Status = "Error", Message = "User creation failed! Please check user details and try again." });

                if (!await _roleManager.RoleExistsAsync(UserRoles.Student))
                    await _roleManager.CreateAsync(new IdentityRole(UserRoles.Student));

                if (await _roleManager.RoleExistsAsync(UserRoles.Student))
                {
                    await _userManager.AddToRoleAsync(user, UserRoles.Student);
                }
            }
            _registrationRequestService.UpdateStatus(id, approved);
            return Ok();
        }
    }
}
