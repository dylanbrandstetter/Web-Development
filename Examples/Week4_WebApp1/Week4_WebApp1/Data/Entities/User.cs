﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Week4_WebApp1.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int YearsInSchool { get; set; }
    }
}