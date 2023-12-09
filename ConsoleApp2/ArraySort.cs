using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArraySort
    {
        public void SortArray(int[] arr)
        {
            Array.Sort(arr, 0, arr.Length); 
        }
        public void PrintArray (int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length-1)
                Console.Write(" ,");
            }
            Console.WriteLine("}");
        }
    }
}
