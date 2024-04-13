﻿using System.ComponentModel.DataAnnotations;

namespace NLogger.Models
{
    public class UserProfile:EntityBase
    {
        public Int64 UserProfileId { get; set; }
        public string ApplicationUserId { get; set; }
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Designation { get; set; }
        public int Department { get; set; }
        public int SubDepartment { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ProfilePicture { get; set; }
        public Int64 RoleId { get; set; }
        public int IsApprover { get; set; }
    }

    public class EntityBase
    {
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool Cancelled { get; set; }

    }
}
