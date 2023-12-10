using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vehicle
    {
        private string make;
        private int year;
        private decimal price;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        
        public Vehicle(string make, int year, decimal price)
        {
            Make = make;
            Year = year;
            Price = price;
        }

        public string GetVehicleInformation()
        {
            return $"Make: {Make}\nYear: {Year}\nPrice: {Price:C}";
        }
    }
}
