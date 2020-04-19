using System;

namespace MovieStore.Domain.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        private double Price { get; set; }
        public Genre Genre { get; set; }
        public bool IsRented { get; set; }

        public Movie(string title, string description, int year, double price, Genre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Price = price;
            Genre = genre;
            IsRented = false;
        }

        public void SetPrice()
        {
            Random random = new Random();
            if(Year <= 2000)
            {
                Year = random.Next(100, 200);
            }
            else if(Year > 2000 && Year <= 2010)
            {
                Year = random.Next(200, 300); 
            }
            else
            {
                Year = random.Next(300, 500);
            }
        }
    }
}