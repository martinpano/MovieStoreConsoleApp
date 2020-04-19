using MovieStore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Domain
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }

        public Member(string firstName, string lastName, int age, string userName, string password, long phoneNumber, DateTime dateOfRegistration)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = Age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}  |  Registered on: {DateOfRegistration.ToShortDateString()}");
        }
    }
}
