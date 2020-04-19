using System;
using MovieStore.Domain.Enums;
namespace MovieStore.Domain.Models
{
    public class Employee : Member
    {
        private double Salary { get; set; }
        public double HoursPerMonth { get; set; }
        private double? Bonus { get; set; }

        public Employee(string firstName, string lastName, int age, string userName, string password, long phoneNumber, DateTime dateOfRegistration) 
            : base(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration)
        {
            Role = Role.Employee;
        }

        public Employee(string firstName, string lastName, int age, string userName, string password, long phoneNumber, DateTime dateOfRegistration, Role role)
            : base(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration)
        {
            Role = role;
        }

        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else
            {
                Bonus = null;
            }
        }

        public void SetSalary()
        {
            if (Bonus.HasValue)
            {
                Salary = HoursPerMonth * Bonus.Value;
            }
            else
            {
                Salary = HoursPerMonth * 5;
            }
        }

    }
}
