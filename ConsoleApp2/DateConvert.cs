using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DateConvert
    {

       public static DateTime ConvertToDate(string dateString)
        {
            string format = "dd-MM-yyyy";

            return DateTime.ParseExact(dateString, format, null);
        }
    }
}
