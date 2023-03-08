﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LearningApp.Models
{
    public partial class Account
    {

        public Account()
        {
        }

        public Account(string fullName, bool gender, string email, string contactNo, string userName, string password, int roleId, bool? status)
        {
            FullName = fullName;
            Gender = gender;
            Email = email;
            ContactNo = contactNo;
            UserName = userName;
            Password = password;
            RoleId = roleId;
            Status = status;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool? Status { get; set; }


        public virtual Role Role { get; set; }
    }
}
