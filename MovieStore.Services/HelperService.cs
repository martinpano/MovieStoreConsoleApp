using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class HelperService
    {
        public void ErrorMessage(string message)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }
}
