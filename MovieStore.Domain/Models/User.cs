using System;
using MovieStore.Domain.Enums;

namespace MovieStore.Domain.Models
{
    public class User : Member
    {
        public string MemberNumber { get; set; }
        public Subscription Subscription { get; set; }
        public Movie[] Movies { get; set; }

        public User(string firstName, string lastName, int age, string userName, string password, long phoneNumber, DateTime dateOfRegistration)
            : base(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration)
        {
            MemberNumber = GenerateMemeberId();
            Role = Role.User;
            Movies = new Movie[0];
        }

        public string GenerateMemeberId()
        {
            Random rand = new Random();
            string[] registrationDateSplited = DateOfRegistration.ToString("dd/MM/yyyy").Split("-");
            string memberNumber = String.Concat($"{registrationDateSplited[0]}{registrationDateSplited[1]}{registrationDateSplited[2]}_{rand.Next(100, 1000)}");
            return memberNumber;
        }
    }
}
