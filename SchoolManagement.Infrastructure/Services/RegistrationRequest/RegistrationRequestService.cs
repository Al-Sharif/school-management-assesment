using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Entities;
using SchoolManagement.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Infrastructure.Services
{
    public class RegistrationRequestService : IRegistrationRequestService
    {
        private readonly SchoolManagementDbContext _dbContext;
        private readonly IMapper _mapper;
        public RegistrationRequestService(SchoolManagementDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public bool Add(RequestInputModel input)
        {
            if (!IsExist(input.Email))
            {
                var entity = _mapper.Map<RegistrationRequest>(input);
                _dbContext.Set<RegistrationRequest>().Add(entity);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<RequestViewModel> GetPendingRequests(int pageSize, int pageNumber)
        {
            var skip = pageSize * pageNumber;
            var result = _dbContext.Set<RegistrationRequest>().Where(x => !x.IsApproved.HasValue).Skip(skip).Take(pageSize).ToList();
            return _mapper.Map<List<RequestViewModel>>(result);
        }

        public RequestViewModel GetById(int id)
        {
            var result = _dbContext.Set<RegistrationRequest>().FirstOrDefault(x => x.Id == id);
            return _mapper.Map<RequestViewModel>(result);
        }
        public void UpdateStatus(int id, bool approved)
        {
            var entity = _dbContext.Set<RegistrationRequest>().FirstOrDefault(x => x.Id == id);
            entity.IsApproved = approved;
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
        public int GetPendingRequestsCount()
        {
            return _dbContext.Set<RegistrationRequest>().Count(x => !x.IsApproved.HasValue);
        }
        private bool IsExist(string email)
        {
            return _dbContext.Set<RegistrationRequest>().Any(x => x.Email.ToLower() == email.ToLower());
        }


    }
}
