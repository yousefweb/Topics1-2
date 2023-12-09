using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CalculateDate
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }

        public CalculateDate(DateTime startDate, DateTime endDate)
        {
            CalculateDifference(startDate, endDate);
        }

        private void CalculateDifference(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                throw new ArgumentException("End date must be greater than or equal to start date.");
            }

            Years = endDate.Year - startDate.Year;
            Months = endDate.Month - startDate.Month;
            Days = endDate.Day - startDate.Day;

            if (Days < 0)
            {
                int daysInMonth = DateTime.DaysInMonth(startDate.Year, startDate.Month);
                Days += daysInMonth;
                Months--;
            }

            if (Months < 0)
            {
                Months += 12;
                Years--;
            }
        }

        public override string ToString()
        {
            return $"Difference: {Years} years, {Months} months, {Days} days.";
        }
    }
}

