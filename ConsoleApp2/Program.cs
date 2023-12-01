using System;
using System.Diagnostics.Tracing;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
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
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question five
int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"element - {i} " + arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question six
int sum = 0;
int[] arr2 = { 1, 2, 3, 4, 5 };
for (int i = 0; i < arr2.Length; i++)
{
    sum += arr2[i];
}
Console.Write("Sum of all elements stored in the array is :" + sum);
Console.WriteLine();
//Console.WriteLine(" Task2\n.............................................................");
//Task 2
//Question one
Console.WriteLine("Insert two numbers to check which one is smaller");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x == y)
{
    Console.WriteLine("two numbers are equal please insert another numbers");

}
if (x < y)
{
    Console.WriteLine(x);
}
if (y < x)
{
    Console.WriteLine(y);

}
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question two
Console.WriteLine("Insert the number....");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 < 0)
{
    Console.WriteLine("the sign is -");
}
if (num3 > 0)
{
    Console.WriteLine("the sign is +");
}
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question three
int[] arr3 = { 0, -1, 4 };
int temp;
for (int i = 0; i < arr3.Length - 1; i++)
{
    if (arr3[i + 1] < arr3[i])
    {
        temp = arr3[i];
        arr3[i] = arr3[i + 1];
        arr3[i + 1] = temp;
    }
}
foreach (int i in arr3)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question four
int[] arr4 = { -5, -2, -6, 0, -1 };
int max = arr4[0];
for (int i = 1; i < arr4.Length; i++)
{
    if (max == arr4[i])
    {
        Console.WriteLine("two numbers are equals");
    }
    if (arr4[i] > max)
    {
        max = arr4[i];
    }
}
Console.WriteLine(max);
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question five
Console.WriteLine("Insert the kilometers per hour");
double val = Convert.ToDouble(Console.ReadLine());
double val2 = val * 0.621371;
Console.WriteLine(val2 + " miles per hour");
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question six
Console.WriteLine("please Insert the hours:");
int val3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please Insert the minutes:");
int val4 = Convert.ToInt32(Console.ReadLine());
int sum2 = (val3 * 60) + val4;
Console.WriteLine("Total: " + sum2 + " minutes.");
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question seven
Console.WriteLine("write the number of minutes");
int valm = Convert.ToInt32(Console.ReadLine());
int valH = valm / 60;
int valM = valm % 60;
Console.WriteLine(valH + " Hours, " + valM + " Minutes");
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question eight
string[] sentences = new string[]
{
            "hello my name is yousef aldeeb.",
            "iam studying in just university of science and technology",
            "i have graduated in october",
            "software engineering",
            "My grade is 3.25."
};



Console.WriteLine("\nFixed-Length Sentences:");

int fxLength = 40;
foreach (string sentence in sentences)
{
    string fxLengthSentence;

    if (sentence.Length < fxLength)
    {
        fxLengthSentence = sentence.PadRight(fxLength);
    }
    else
    {
        fxLengthSentence = sentence.Substring(0, fxLength);
    }

    Console.WriteLine(fxLengthSentence);
}
Console.WriteLine();
Console.WriteLine(".............................................................");
//Question nine




    static string ReverseOdd(string input)
{
    string[] words = input.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 != 0)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }
    }

    return string.Join(" ", words);
}
Console.WriteLine(ReverseOdd("Bananas"));
Console.WriteLine(ReverseOdd("One two three four"));

