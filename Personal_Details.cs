﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_App
{
    public class Personal_Details
    {
        public Personal_Details(string firstName, string lastName, DateTime dateOfBirth, string placeOfBirth, string address, string phoneNumber, string email, string sex, string maritalStatus, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Sex = sex;
            MaritalStatus = maritalStatus;
            Nationality = nationality;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }

    }
}

