using System;
using System.Diagnostics.Tracing;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question one
            Console.WriteLine("Please enter the  word...");
            string word = Console.ReadLine();
            Console.WriteLine(word);
            Console.WriteLine("........................................................");
            //Question two
            double d = 1.2;
            string s = " hello";
            char a = 'a';
            bool b = false;
            int num = 1;
            const int num2 = 2;
            Console.WriteLine($"double num {d} and string word is {s}  and char is {a} and boolean value is {b} and num value is {num} and constant num value is {num2}");
            Console.WriteLine("........................................................");
            //Question three
            string[] car = { "toyota", "mercedes", "Kia" };
            foreach (var item in car)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("the array of the length is: " + car.Length);
            Console.WriteLine("........................................................");
            //Question four
            string[] info = new string[3];
            string[] names = { "Enter the firstName", "Enter the surName", "Enter the year of the birth" };


            for (int i = 0; i < info.Length; i++)
            {
                Console.WriteLine(names[i]);
                info[i] = Console.ReadLine();
            }
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i] + " ");
            }
            Console.WriteLine(".............................................................");
            //Question five
            int[] arr = { };
            for (int i = 0; i <= arr.Length; i++)
            {
                if (arr[i]==)
                Console.WriteLine(arr[i]);
            }

        }
    }
}