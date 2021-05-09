using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Entities
{
    public class RegistrationRequest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string HashPassword { get; set; }
        public bool? IsApproved { get; set; }
    }
}
