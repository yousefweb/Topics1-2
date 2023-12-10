//using System;
//using System.Diagnostics.Tracing;
//using System.Formats.Asn1;
//using System.Reflection.Metadata.Ecma335;
using ConsoleApp2;
using System;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;


class Program
{
    static void Main()
    {
        Console.WriteLine(" task1\n.............................................................");
        ////Question one
        //Console.WriteLine("Please enter the  word...");
        //string word = Console.ReadLine();
        //Console.WriteLine(word);
        //Console.WriteLine("........................................................");
        ////Question two
        //double d = 1.2;
        //string s = " hello";
        //char a = 'a';
        //bool b = false;
        //int num = 1;
        //const int num2 = 2;
        //Console.WriteLine($"double num {d} and string word is {s}  and char is {a} and boolean value is {b} and num value is {num} and constant num value is {num2}");
        //Console.WriteLine("........................................................");
        ////Question three
        //string[] car = { "toyota", "mercedes", "Kia" };
        //foreach (var item in car)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine("the array of the length is: " + car.Length);
        //Console.WriteLine("........................................................");
        ////Question four
        //string[] info = new string[3];
        //string[] names = { "Enter the firstName", "Enter the surName", "Enter the year of the birth" };


        //for (int i = 0; i < info.Length; i++)
        //{
        //    Console.WriteLine(names[i]);
        //    info[i] = Console.ReadLine();
        //}
        //for (int i = 0; i < info.Length; i++)
        //{
        //    Console.Write(info[i] + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question five
        //int[] arr = new int[10];

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = Convert.ToInt32(Console.ReadLine());

        //}
        //Console.WriteLine();
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"element - {i} " + arr[i] + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question six
        //int sum = 0;
        //int[] arr2 = { 1, 2, 3, 4, 5 };
        //for (int i = 0; i < arr2.Length; i++)
        //{
        //    sum += arr2[i];
        //}
        //Console.Write("Sum of all elements stored in the array is :" + sum);
        //Console.WriteLine();
        Console.WriteLine(" task2\n.............................................................");
        ////Task 2
        ////Question one
        //Console.WriteLine("Insert two numbers to check which one is smaller");
        //int x = Convert.ToInt32(Console.ReadLine());
        //int y = Convert.ToInt32(Console.ReadLine());
        //if (x == y)
        //{
        //    Console.WriteLine("two numbers are equal please insert another numbers");

        //}
        //if (x < y)
        //{
        //    Console.WriteLine(x);
        //}
        //if (y < x)
        //{
        //    Console.WriteLine(y);

        //}
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question two
        //Console.WriteLine("Insert the number....");
        //int num3 = Convert.ToInt32(Console.ReadLine());
        //if (num3 < 0)
        //{
        //    Console.WriteLine("the sign is -");
        //}
        //if (num3 > 0)
        //{
        //    Console.WriteLine("the sign is +");
        //}
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question three
        //int[] arr3 = { 0, -1, 4 };
        //int temp;
        //for (int i = 0; i < arr3.Length - 1; i++)
        //{
        //    if (arr3[i + 1] < arr3[i])
        //    {
        //        temp = arr3[i];
        //        arr3[i] = arr3[i + 1];
        //        arr3[i + 1] = temp;
        //    }
        //}
        //foreach (int i in arr3)
        //{
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question four
        //int[] arr4 = { -5, -2, -6, 0, -1 };
        //int max = arr4[0];
        //for (int i = 1; i < arr4.Length; i++)
        //{
        //    if (max == arr4[i])
        //    {
        //        Console.WriteLine("two numbers are equals");
        //    }
        //    if (arr4[i] > max)
        //    {
        //        max = arr4[i];
        //    }
        //}
        //Console.WriteLine(max);
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question five
        //Console.WriteLine("Insert the kilometers per hour");
        //double val = Convert.ToDouble(Console.ReadLine());
        //double val2 = val * 0.621371;
        //Console.WriteLine(val2 + " miles per hour");
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question six
        //Console.WriteLine("please Insert the hours:");
        //int val3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("please Insert the minutes:");
        //int val4 = Convert.ToInt32(Console.ReadLine());
        //int sum2 = (val3 * 60) + val4;
        //Console.WriteLine("Total: " + sum2 + " minutes.");
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        //Question seven
        //Console.WriteLine("write the number of minutes");
        //int valm = Convert.ToInt32(Console.ReadLine());
        //int valH = valm / 60;
        //int valM = valm % 60;
        //Console.WriteLine(valH + " Hours, " + valM + " Minutes");
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question eight
        //string[] sentences = new string[]
        //{
        //            "hello my name is yousef aldeeb.",
        //            "iam studying in just university of science and technology",
        //            "i have graduated in october",
        //            "software engineering",
        //            "My grade is 3.25."
        //};

        //Console.WriteLine("\nFixed-Length Sentences:");

        //int fxLength = 40;
        //foreach (string sentence in sentences)
        //{
        //    string fxLengthSentence;

        //    if (sentence.Length < fxLength)
        //    {
        //        fxLengthSentence = sentence.PadRight(fxLength);
        //    }
        //    else
        //    {
        //        fxLengthSentence = sentence.Substring(0, fxLength);
        //    }

        //    Console.WriteLine(fxLengthSentence);
        //}
        //Console.WriteLine();
        //Console.WriteLine(".............................................................");
        ////Question nine

        //    static string ReverseOdd(string input)
        //{
        //    string[] words = input.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (words[i].Length % 2 != 0)
        //        {
        //            char[] charArray = words[i].ToCharArray();
        //            Array.Reverse(charArray);
        //            words[i] = new string(charArray);
        //        }
        //    }

        //    return string.Join(" ", charArray);
        //}
        //Console.WriteLine(ReverseOdd("Bananas"));
        //Console.WriteLine(ReverseOdd("One two three four"));
        Console.WriteLine(" task3\n.............................................................");
        ////Task 3
        ////Question one
        //Console.WriteLine("this is the question1 ");
        //string[] arr = { "1", "7", "9", "45" };
        //string[] arr2 = { "Str", "alex", "moh" };
        //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
        //Question two
        //Console.WriteLine("this is the question2");
        //string[] fruits = {"Tomato", "Banana", "Watermelon"};
        //Console.WriteLine(fruits[0]+ " " + fruits[1]);
        //Question three
        //Console.WriteLine("this is the question3");
        //string[] food = { "manasf", "burger", "kabsa", "maqlobeh", "shawerma" };
        //string[] sport = { "gym", "swimming", "bowling"};
        //string[] movie = { "titanic", "never back down", "wrong turn", "saw" };
        //foreach (var item in food)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();
        //foreach (var item in sport)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();

        //foreach (var item in movie)
        //{
        //    Console.Write(item + " ");
        //}
        //Question four
        //Console.WriteLine("this is the question 4");
        //Console.WriteLine("Input three numbers separated by comma: ");

        //string[] arr7 = Console.ReadLine().Split(',');

        //int sum = 0;

        //foreach (string i in arr7)
        //{
        //    sum += Convert.ToInt32(i);
        //}

        //Console.WriteLine($"The sum of three numbers: {sum}.");
        //Question five
        //Console.WriteLine("this is the question 5");
        //int sum = 0;
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i%2 != 0)
        //    {
        //        Console.Write(i+" ");
        //        sum += i;
        //    }
        //}
        //Console.WriteLine(sum);

        //Question six
        //Console.WriteLine("this is the question 6");
        //Console.Write("Enter an integer: ");
        //int value = int.Parse(Console.ReadLine());

        //for (int i = 1; i <=value; i++)
        //{
        //    for (int j = 1; j <=value-i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = 1; j <= i*2-1; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //Question seven
        //Console.WriteLine("this is the question 7");
        //Console.WriteLine("Enter an integer: ");
        //int c = 1;

        //for (int i = 1; i <= 4; i++)
        //{
        //    for (int j = 1; j <= 4 - i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(" "+c);
        //        c++;
        //    }
        //    Console.WriteLine();
        //}
        Console.WriteLine(" task4\n.............................................................");
        //Task 4
        ////Question one
        //Console.WriteLine("this is the question1\n.......................................");
        //static void calculateNum(int[] number)
        //{
        //    int sum = 0;
        //    float c = 0f;
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        number[i] = Convert.ToInt32(Console.ReadLine());

        //    }
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        sum += number[i];
        //        c++;
        //    }
        //    Console.WriteLine("The sum of 10 no is : " + sum);
        //    Console.WriteLine("The Average is: " + sum/c);
        //}
        //int[] number = new int[10];
        //calculateNum(number);
        //Question two
        //Console.WriteLine("this is the question2\n.......................................");
        //while (true)
        //{
        //    Console.Write("Enter a number (or 'E' to exit): ");
        //    string input = Console.ReadLine();

        //    if (input.ToUpper() == "E")
        //    {
        //        Console.WriteLine("Exiting the program. Goodbye!");
        //        break;
        //    }

        //    if (int.TryParse(input, out int cube))
        //    {
        //        int result = 1;

        //        for (int i = 1; i <= 3; i++)
        //        {
        //            result *= cube;
        //        }

        //        Console.WriteLine($"Number is: {cube} and cube of {cube} is: {result}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter a valid number.");
        //    }
        //}
        //Question three
        //Console.WriteLine("this is the question3\n.......................................");
        //static List<int> getYears(int [] years)
        //{
        //    List<int> newArr = new List<int>();
        //    for (int i = 0; i < years.Length; i++)
        //	{
        //		if (years[i] > 1950)
        //		{
        //			newArr.Add(years[i]);
        //		}
        //	}
        //	return newArr;
        //}

        //  int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
        //        List<int> result = getYears(years);

        //        Console.WriteLine("Years greater than 1950:");
        //        foreach (int year in result)
        //        {
        //            Console.WriteLine(year);
        //        }
        //}
        ////Question four
        //Console.WriteLine("this is the question4\n.......................................");
        //static int Age(int years)
        //{
        //    int ageDay = years * 365;
        //    return ageDay;
        //}
        //Console.Write("Enter your age in years: ");
        //int year = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("The Age in Days is: "+Age(year));
        //Question five
        //Console.WriteLine("this is the question5\n.......................................");
        //static int CountLegs(int chickens, int cows, int pigs)
        //{
        //    int chickenLegs = chickens * 2;
        //    int cowLegs = cows * 4;
        //    int pigLegs = pigs * 4;

        //    int totalLegs = chickenLegs + cowLegs + pigLegs;
        //    return totalLegs;
        //}

        //int totalLegs = CountLegs(2, 3, 5);
        //Console.WriteLine($"Total number of legs: {totalLegs}");
        //Question six
        //Console.WriteLine("this is the question6\n.......................................");
        //static string Login(string username, string password)
        //{
        //    string[] validUsers = { "user1:pass1", "user2:pass2", "user3:pass3" };

        //    foreach (string user in validUsers)
        //    {
        //        string[] userCredentials = user.Split(':');
        //        string storedUsername = userCredentials[0];
        //        string storedPassword = userCredentials[1];

        //        if (username == storedUsername && password == storedPassword)
        //        {
        //            return "Pass";
        //        }
        //    }

        //    return "Failed"; 
        //}

        //Console.Write("Enter username: ");
        //string inputUsername = Console.ReadLine();

        //Console.Write("Enter password: ");
        //string inputPassword = Console.ReadLine();

        //string result = Login(inputUsername, inputPassword);
        //Console.WriteLine($"Login {result}");
        //Question seven
        //Console.WriteLine("this is the question7\n.......................................");
        //static double CalculatePower(double baseNumber, int exponent)
        //{
        //    if (exponent == 0)
        //    {
        //        return 1; 
        //    }
        //    else if (exponent < 0)
        //    {
        //        throw new ArgumentException("Exponent must be a non-negative integer.");
        //    }

        //    double result = 1;
        //    for (int i = 0; i < exponent; i++)
        //    {
        //        result *= baseNumber;
        //    }

        //    return result;
        //}

        //    Console.Write("Enter the base number: ");
        //    if (double.TryParse(Console.ReadLine(), out double baseNumber))
        //    {
        //        Console.Write("Enter the exponent: ");
        //        if (int.TryParse(Console.ReadLine(), out int exponent))
        //        {
        //            try
        //            {
        //                double result = CalculatePower(baseNumber, exponent);
        //                Console.WriteLine($"Result: {result}");
        //            }
        //            catch (ArgumentException ex)
        //            {
        //                Console.WriteLine($"Error: {ex.Message}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input. Exponent must be an integer.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Base number must be a valid double.");
        //    }
        //Question eight
        //Console.WriteLine("this is the question8\n.......................................");
        //static bool IsLeapYear(int year) { 
        //    if (year < 1900 || year > 2024)
        //    {
        //        throw new ArgumentException("Year must be in the range 1900-2024.");
        //    }

        //    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        //}

        //    Console.Write("Enter a year (1900-2024): ");
        //    if (int.TryParse(Console.ReadLine(), out int inputYear))
        //    {
        //        try
        //        {
        //            bool isLeapYear = IsLeapYear(inputYear);
        //            if (isLeapYear)
        //            {
        //                Console.WriteLine($"{inputYear} is a leap year.");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{inputYear} is not a leap year.");
        //            }
        //        }
        //        catch (ArgumentException ex)
        //        {
        //            Console.WriteLine($"Error: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid integer for the year.");
        //    }
        //Question nine
        //Console.WriteLine("this is the question9\n.......................................");
        //static bool IsPrime(int num)
        //{
        //    if (num < 2)
        //    {
        //        return false; 
        //    }

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            return false; 
        //        }
        //    }

        //    return true;
        //    }

        //Console.Write("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //bool isPrime = IsPrime(num);

        //if (isPrime)
        //{
        //    Console.WriteLine($"{num} is a prime number.");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is not a prime number.");
        //}
        //Question ten
        //Console.WriteLine("this is the question10\n.......................................");
        //static int CountWords(string sentence)
        //{
        //    int wordCount = 0;
        //    bool isPreviousCharSpace = true;

        //    foreach (char character in sentence)
        //    {
        //        if (character == ' ')
        //        {
        //            isPreviousCharSpace = true;
        //        }
        //        else if (isPreviousCharSpace)
        //        {
        //            wordCount++;
        //            isPreviousCharSpace = false;
        //        }
        //    }
        //    return wordCount;
        //}

        //Console.Write("Enter a sentence: ");
        //string inputSentence = Console.ReadLine();

        //int wordCount = CountWords(inputSentence);
        //Console.WriteLine($"Number of words: {wordCount}");
        Console.WriteLine(" Task-function\n.............................................................");
        //task-function
        //Question one
        //Console.WriteLine("this is the question1\n.......................................");
        //static int ConvertM(int m)
        //{
        //    return m * 60;
        //}
        //Console.WriteLine("Enter the number of minutes");
        //int m = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Number of seconds is: "+ConvertM(m));
        //Question two
        //Console.WriteLine("this is the question2\n.......................................");
        //static int IncNum(int num)
        //{
        //    return num + 1;
        //}
        //Console.Write("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(IncNum(num));
        //Question three
        //Console.WriteLine("this is the question3\n.......................................");
        //static int FirstArrIndex(int[] arr)
        //{
        //    if (arr.Length > 0)
        //    {
        //        return arr[0];
        //    }
        //    else
        //    {
        //         throw new Exception("array is empty!!");
        //    }
        //}

        //int[] numberArray = {2,4,6,8,10};
        //try
        //{
        //Console.WriteLine("The first element is: " + FirstArrIndex(numberArray));

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"The error : {ex.Message}");

        //}
        //Question four
        //Console.WriteLine("this is the question4\n.......................................");
        //static double area (double Base , double height)
        //{
        //    if (Base < 0 || height<0)
        //    {
        //        throw new Exception("Base and height must be non-negative.");
        //    }
        //    else
        //    {
        //        return 0.5 * Base * height;
        //    }
        //}
        //Console.WriteLine("Enter the Base:");
        //if (double.TryParse(Console.ReadLine(), out double Base)) {
        //    Console.WriteLine("Enter the Height:");
        //    if (double.TryParse(Console.ReadLine(), out double Height))
        //    {
        //        try
        //        {

        //            Console.WriteLine($"The area of the triangle is: {area(Base,Height)}");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"The Error is: {ex.Message}");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number for height.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid number for base length.");
        //}
        //Question five
        //Console.WriteLine("this is the question5\n.......................................");
        //static int[] EvenNumberEvenIndex(int[] nums)
        //{
        //    List<int> newArray2 = new List<int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (i%2==0 && nums[i] % 2 == 0)
        //        {
        //            newArray2.Add(nums[i]);
        //        }
        //    }

        //    return newArray2.ToArray();
        //}
        //int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };

        //int[] resultArray = EvenNumberEvenIndex(nums);

        //Console.WriteLine("Result: [" + string.Join(", ", resultArray) + "]");
        ////Question six
        //Console.WriteLine("this is the question6\n.......................................");

        // static string[] EvenIndexOddLength(string[] strings)
        //{
        //    List<string> result = new List<string>();

        //    for (int i = 0; i < strings.Length; i += 2)
        //    {
        //        if (strings[i].Length % 2 != 0)
        //        {
        //            result.Add(strings[i]);
        //        }
        //    }

        //    return result.ToArray();
        //}

        //string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };

        //string[] resultArray = EvenIndexOddLength(strings);

        //Console.WriteLine("Result: [" + string.Join(", ", resultArray) + "]");
        //Question seven
        //Console.WriteLine("this is the question7\n.......................................");
        //static int[] PowerElementIndex(int[] nums)
        //{
        //    List<int> result = new List<int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        result.Add((int)Math.Pow(nums[i], i));
        //    }

        //    return result.ToArray();
        //}

        //    int[] nums = { 44, 5, 4, 3, 2, 10 };

        //    int[] resultArray = PowerElementIndex(nums);

        //    Console.WriteLine("Result: [" + string.Join(", ", resultArray) + "]");
        //Question eight
        //Console.WriteLine("this is the question8\n.......................................");
        //static int multiplication2(int a , int b){
        //    int sum = 0;
        //	for (int i = 0; i < Math.Abs(b); i++)
        //	{
        //		sum += a;
        //	}
        //	if(b<0)
        //	   return -(sum);
        //	        return sum;
        //}
        //Console.WriteLine("Please insert the first number:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please insert the second number:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(multiplication2(a,b));
        //Question nine
        //Console.WriteLine("this is the question9\n.......................................");
        //static int muti2(int a, int b)
        //{
        //    if(a>b)
        //    {
        //        throw new Exception("start point must be less than end point");
        //    }
        //    int result = 1;
        //    for (int i = a; i <=b; i++)
        //    {
        //        result *= i;
        //    }
        //      return result;
        //}
        //try { Console.WriteLine("Please insert the first number:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Please insert the second number:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(muti2(a, b));
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine($"Error : {ex.Message}");
        //}
        //Question ten
        //Console.WriteLine("this is the question10\n.......................................");
        //static float aveArray(int[] arr)
        //{
        //    if (arr.Length == 0)
        //    {
        //        throw new Exception("Array must not be empty.");
        //    }
        //    int sum = 0;
        //	for (int i = 0; i < arr.Length; i++)
        //	{
        //		sum += arr[i];
        //	}
        //	return (float) sum / arr.Length;
        //}
        //try
        //{
        //    int[] numArrayy = { 1, 2, 3, 8, 9 };
        //    Console.WriteLine("Average : "+aveArray(numArrayy));
        //    int[] numArrayy2 = { 1, 2, 3, 8, 9, 77 };
        //    Console.WriteLine("Average : "+aveArray(numArrayy2));
        //}
        //catch(Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }

        Console.WriteLine(" Task-function2\n.............................................................");
        //task-function2
        //Question one
        //Console.WriteLine("this is the question1\n.......................................");


        //static int GetDaysBetweenDates(DateTime date1, DateTime date2)
        //{
        //    TimeSpan timeDifference = date2 - date1;

        //    int daysDifference = (int)timeDifference.TotalDays;

        //    return Math.Abs(daysDifference);
        //}
        //DateTime date1 = new DateTime(2019, 6, 14);
        //DateTime date2 = new DateTime(2019, 6, 20);
        //int result1 = GetDaysBetweenDates(date1, date2);
        //Console.WriteLine(result1);  

        //DateTime date3 = new DateTime(2018, 12, 29);
        //DateTime date4 = new DateTime(2019, 1, 1);
        //int result2 = GetDaysBetweenDates(date3, date4);
        //Console.WriteLine(result2);
        //Question two
        //Console.WriteLine("this is the question2\n.......................................");

        //static string[] StrNum(string[] num)
        //{
        //    var result = num.Where(x =>x.Any(char.IsDigit)).ToArray();
        //    return result;
        //}

        //string[] input1 = { "1a", "a", "2b", "b" };
        //string[] result3 = StrNum(input1);
        //Console.WriteLine(string.Join(", ", result3));

        //string[] input2 = { "abc", "abc10" };
        //string[] result4 = StrNum(input2);
        //Console.WriteLine(string.Join(", ", result4));
        //Question three
        //Console.WriteLine("this is the question3\n.......................................");


        //static string ReverseOddWords(string str)
        //{
        //    string[] words = str.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (words[i].Length % 2 != 0)
        //        {
        //            char[] charArray = words[i].ToCharArray();
        //            Array.Reverse(charArray);
        //            words[i] = new string(charArray);
        //        }
        //    }

        //    string result = string.Join(" ", words);

        //    return result;
        //}
        //string result1 = ReverseOddWords("Bananas");
        //Console.WriteLine(result1);  

        //string result2 = ReverseOddWords("One two three four");
        //Console.WriteLine(result2); 

        //Question four
        //Console.WriteLine("this is the question4\n.......................................");
        //static bool IsPandigital(long number)
        //{
        //    string numberStr = number.ToString();

        //    for (int digit = 0; digit < 10; digit++)
        //    {
        //        if (!numberStr.Contains(digit.ToString()))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        //bool result1 = IsPandigital(98140723568910);
        //Console.WriteLine(result1);  

        //bool result2 = IsPandigital(90864523148909);
        //Console.WriteLine(result2);  

        //bool result3 = IsPandigital(112233445566778899);
        //Console.WriteLine(result3);  

        Console.WriteLine(" Task-function3\n.............................................................");
        //task-function3
        //Question one
        //Console.WriteLine("this is the question1\n.......................................");
        //static Func<int, int> Add(int n)
        //{

        //    return x => x + n;
        //}
        //Func<int, int> add10 = Add(10);
        //Console.WriteLine(add10(20)); 

        //Func<int, int> addZero = Add(0);
        //Console.WriteLine(addZero(20));   

        //Func<int, int> addNeg30 = Add(-30);
        //Console.WriteLine(addNeg30(80)); 

        //Question two
        //Console.WriteLine("this is the question2\n.......................................");
        //static string removeLeadingTrailing(string n)
        //{
        //    decimal number = decimal.Parse(n);

        //    string result = number.ToString();


        //    if (result.Contains('.'))
        //    {
        //    result = result.TrimEnd('0');
        //    result = result.TrimStart('0');
        //    }
        //    if (result.EndsWith('.'))
        //    {
        //        result = result.TrimEnd('.');
        //    }
        //    return result;
        //}
        //Console.WriteLine(removeLeadingTrailing("230.000"));
        //Console.WriteLine(removeLeadingTrailing("00402"));
        //Console.WriteLine(removeLeadingTrailing("03.1400"));
        //Console.WriteLine(removeLeadingTrailing("30"));

        //Question thrre
        //Console.WriteLine("this is the question3\n.......................................");
        // static int secondLargest(int[] arr)
        //{
        //    if (arr.Length < 2)
        //    {
        //        throw new ArgumentException("Array must have at least two elements.");
        //    }

        //    int firstLargest = arr[0];
        //    int secondLargest = -1;

        //    foreach (int number in arr)
        //    {
        //        if (number > firstLargest)
        //        {
        //            secondLargest = firstLargest;
        //            firstLargest = number;
        //        }
        //        else if (number > secondLargest && number != firstLargest)
        //        {
        //            secondLargest = number;
        //        }
        //    }

        //    return secondLargest;
        //}
        //int[] numbers1 = { 10, 40, 30, 20, 50 };
        //Console.WriteLine(secondLargest(numbers1)); 

        //int[] numbers2 = { 25, 143, 89, 13, 105 };
        //Console.WriteLine(secondLargest(numbers2));  

        //int[] numbers3 = { 54, 23, 11, 17, 10 };
        //Console.WriteLine(secondLargest(numbers3));

        //Question four
        //Console.WriteLine("this is the question4\n.......................................");
        //static bool isRepdigit(int number)
        //{
        //    string numstr = number.ToString();
        //    char firstDigit = numstr[0];
        //    for (int i = 1; i < numstr.Length; i++)
        //    {
        //        if (numstr[i]!=firstDigit)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Console.WriteLine(isRepdigit(66));
        //Console.WriteLine(isRepdigit(0));
        //Console.WriteLine(isRepdigit(-11));

        //Question five
        //Console.WriteLine("this is the question5\n.......................................");

        //static string reverseWords(string str)
        //{
        //    string[] strArr = str.Split(" ");
        //	string [] newStr = new string[strArr.Length];

        //	for (int i = strArr.Length-1; i >=0; i--)
        //	{
        //		newStr[strArr.Length-1-i] = strArr[i];
        //	}
        //	return string.Join(" ",newStr);
        //}
        //Console.WriteLine(reverseWords("the sky is blue"));    
        //Console.WriteLine(reverseWords("hello world! "));      
        //Console.WriteLine(reverseWords("a good example"));

        //Question six
        //Console.WriteLine("this is the question6\n.......................................");
        //static string SevenBoom(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)

        //    {
        //        if (Math.Abs(numbers[i]).ToString().Contains('7'))
        //        {
        //            return "Boom!";
        //        }
        //    }

        //    return "there is no 7 in the array";
        //}

        //Console.WriteLine(SevenBoom(new int[] { 1, 2, 3, 4, 5, 6, 7 })); 
        //Console.WriteLine(SevenBoom(new int[] { 8, 6, 33, 100 }));          
        //Console.WriteLine(SevenBoom(new int[] { 2, 55, 60, 97, 86 }));

        //Question seven
        //Console.WriteLine("this is the question7\n.......................................");
        //static string insertWhitespace(string str)

        //{
        //    StringBuilder result = new StringBuilder();

        //    for (int i = 0; i < str.Length; i++)
        //    {

        //        if (i > 0 && char.IsUpper(str[i]) && char.IsLower(str[i - 1]))
        //        {
        //            result.Append(' ');
        //        }

        //        result.Append(str[i]);
        //    }

        //    return result.ToString();
        //}

        //Console.WriteLine(insertWhitespace("SheWalksToTheBeach"));
        //Console.WriteLine(insertWhitespace("MarvinTalksTooMuch"));
        //Console.WriteLine(insertWhitespace("TheGreatestUpsetInHistory"));

        //Question eight
        ////Console.WriteLine("this is the question8\n.......................................");
        //static int countTrue(bool[] numArr)
        //{
        //    int c = 0;
        //	for (int i = 0; i < numArr.Length; i++)
        //	{
        //		if (numArr[i] == true)
        //		{
        //			c++;
        //		}
        //	}
        //	return c;
        //}

        //Console.WriteLine(countTrue(new bool[] { true, false, false, true, false }));
        //Console.WriteLine(countTrue(new bool[] { false, false, false, false }));
        //Console.WriteLine(countTrue(new bool[] {}));

        //Question nine
        ////Console.WriteLine("this is the question9\n.......................................");
        //static string capToFront(string str)
        //{

        //    char[] charArray = str.ToCharArray();

        //    int j = 0;
        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        if (char.IsUpper(charArray[i]))
        //        {
        //            char temp = charArray[i];
        //            charArray[i] = charArray[j];
        //            charArray[j] = temp;
        //            j++;
        //        }
        //    }

        //    return new string (charArray);
        //}
        //Console.WriteLine(capToFront("hApPy"));
        //Console.WriteLine(capToFront("moveMENT"));
        //Console.WriteLine(capToFront("shOrtCAKE"));


        //Question ten
        ////Console.WriteLine("this is the question10\n.......................................");

        //static bool MatchLastItem(object[] arr)
        //{
        //    if (arr.Length == 0)
        //    {
        //        return false;
        //    }

        //    string lastItem = arr[arr.Length - 1].ToString();
        //    string concatenatedRest = "";

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        concatenatedRest += arr[i].ToString();
        //    }

        //    if (lastItem.Equals(concatenatedRest,StringComparison.Ordinal))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //Console.WriteLine(MatchLastItem(new object[] { "rsq", "6hi", "g", "rsq6hig" }));
        //Console.WriteLine(MatchLastItem(new object[] { 1, 1, 1, "11" }));
        //Console.WriteLine(MatchLastItem(new object[] { 8, "thunder", true, "8thundertrue" }));  



        //Question eleven
        //Console.WriteLine("this is the question11\n.......................................");
        //static int findNaN(double[] arr)
        //{
        //	for (int i = 0; i < arr.Length; i++)
        //	{
        //		if (double.IsNaN(arr[i]))
        //		{
        //			return i;
        //		}
        //	}
        //	return -1;
        //}
        //Console.WriteLine(findNaN(new double[] { 1, 2, double.NaN }));
        //Console.WriteLine(findNaN(new double[] { double.NaN, 1, 2, 3, 4 }));
        //Console.WriteLine(findNaN(new double[] { 0, 1, 2, 3, 4 }));


        //Question twelve
        ////Console.WriteLine("this is the question12\n.......................................");


        //static object[] removeDups(object[] arr)
        //{
        //    if (arr.Length == 0)
        //    {
        //        throw new ArgumentException("The array is empty");
        //    }

        //    List<object> uniqueList = new List<object>();

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (!uniqueList.Contains(arr[i]))
        //        {
        //            uniqueList.Add(arr[i]);
        //        }
        //    }

        //    return uniqueList.ToArray();
        //}
        //static void DisplayArray(object[] arr)
        //{
        //    Console.Write("[");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]);
        //        if (i < arr.Length - 1)
        //        {
        //            Console.Write(", ");
        //        }
        //    }
        //    Console.WriteLine("]");
        //}
        //try
        //{
        //    var result1 = removeDups(new object[] { 1, 0, 1, 0 });
        //    DisplayArray(result1);

        //    var result2 = removeDups(new object[] { "The", "big", "cat" });
        //    DisplayArray(result2);

        //    var result3 = removeDups(new object[] { "John", "Taylor", "John" });
        //    DisplayArray(result3);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Error: {ex.Message}");
        //}


        //Question thirteen
        ////Console.WriteLine("this is the question13\n.......................................");

        //static string ConvertTime(string time)
        //{

        //    DateTime parsedTime = DateTime.ParseExact(time, "hh:mm:sstt", "HH:mm:ss");

        //    return parsedTime.ToString();
        //}
        //Console.WriteLine(ConvertTime("07:05:45PM")); 
        //Console.WriteLine(ConvertTime("12:40:22AM")); 
        //Console.WriteLine(ConvertTime("12:45:54PM")); 


        //Question fourteen
        ////Console.WriteLine("this is the question14\n.......................................");

        //static string RemoveLastVowel(string str)
        //{
        //    string[] words = str.Split(' ');
        //    for (int i = 0; i < words.Length; i++)
        //    {

        //        for (int j = words[i].Length - 1; j >= 0; j--)
        //        {
        //            if (words[i][j] == 'a' || words[i][j] == 'o' || words[i][j] == 'e' || words[i][j] == 'u' || words[i][j] =='i')
        //            {
        //                words[i] = words[i].Remove(j, 1);
        //                break;
        //            }
        //        }
        //    }
        //    return string.Join(" ",words);
        //}

        //Console.WriteLine(RemoveLastVowel("Those who dare to fail miserably can achieve greatly."));
        //Console.WriteLine(RemoveLastVowel("Love is a serious mental disease."));


        //Question fifteen
        //Console.WriteLine("this is the question15\n.......................................");
        //static int sumOfCubes(int[] num)
        //{
        //	double sum = 0;
        //	for (int i = 0; i < num.Length; i++)
        //	{
        //		double power = Math.Pow(num[i], 3);
        //		sum += power;
        //	}
        //	return (int) sum;
        //}

        //Console.WriteLine(sumOfCubes(new int[] {1,5,9}));
        //Console.WriteLine(sumOfCubes(new int[] { 3,4,5 }));
        //Console.WriteLine(sumOfCubes(new int[] {2}));
        //Console.WriteLine(sumOfCubes(new int[] {}));


        Console.WriteLine("Task OOP\n.............................................................");
        //task-OOP
        //Question one
        //Console.WriteLine("this is the question1\n.......................................");
        //MyClass obj = new MyClass();

        //Question two
        //Console.WriteLine("this is the question2\n.......................................");
        //GreetingClass greetingClass = new GreetingClass();
        //greetingClass.DisplayGreeting("Scott");


        //Question three
        //Console.WriteLine("this is the question3\n.......................................");
        //FactorialClass factorialClass = new FactorialClass();
        //int fact = factorialClass.CalculateFact(5);
        //Console.WriteLine("the factorial number is :"+ fact);



        //Question four
        //Console.WriteLine("this is the question4\n.......................................");
        //int[] array = { 11, -2, 4, 35, 0, 8, -9 ,-5};
        //ArraySort arraySort = new ArraySort();

        //Console.WriteLine("Original array:");
        //arraySort.PrintArray(array);

        //arraySort.SortArray(array);

        //Console.WriteLine("Sorted array:");
        //arraySort.PrintArray(array);


        //Question five
        //Console.WriteLine("this is the question5\n.......................................");
        //DateTime date1 = new DateTime(1981, 11, 03);
        //DateTime date2 = new DateTime(2013, 09, 04);

        //CalculateDate calculateDate = new CalculateDate(date1, date2);
        //Console.WriteLine(calculateDate);


        //Question six
        //Console.WriteLine("this is the question6\n.......................................");
        //string dateString = "12-08-2004";
        //DateTime dateOnly = DateConvert.ConvertToDate(dateString);
        //Console.WriteLine($"Converted Date: {dateOnly:yyyy-MM-dd}");

        Console.WriteLine("Task6\n.......................................");

        //Car myCar = new Car("Toyota", 2022, "Sedan", 25000.00m, "Camry", "123ABC", "Blue");

        //Console.WriteLine(myCar.GetVehicleInformation());

        //myCar.StartEngine();

        //string carInformation = myCar.GetCarInformation();
        //Console.WriteLine("\nCar Information:\n" + carInformation+"\n");

        //myCar.StopEngine();

        //carInformation = myCar.GetCarInformation();
        //Console.WriteLine("\nUpdated Car Information:\n" + carInformation);

        Console.WriteLine("Task7\n.......................................");

    //    var newDirPath = Path.Combine(Directory.GetCurrentDirectory(), "MyNewFolder");
    //    Directory.CreateDirectory(newDirPath);

    //    var newFilePath = Path.Combine(newDirPath, "MyFile.txt");
    //    var fileStream = File.Create(newFilePath);

    //    using (var sw = new StreamWriter(fileStream))
    //    {
    //        sw.WriteLine("my name is: yousef aldeeb\r\nspecialize is : software engineering\r\nmy age is : 23\r\nwork: web development Asp.net core mvc \r\n");
    //    }

    //    using (var sr = new StreamReader(newFilePath))
    //    {
    //        var read = true;
    //        int charCount = 0;
    //        int wordCount = 0;

    //        while (read)
    //        {
    //            var line = sr.ReadLine();
    //            if (string.IsNullOrEmpty(line))
    //            {
    //                read = false;
    //            }
    //            else
    //            {
                   
    //                charCount += CountCharNoSpace(line);

                    
    //                wordCount += CountWordsNoSpace(line);

    //                Console.WriteLine(line);
    //            }
    //        }

    //        Console.WriteLine($"\nTotal number of characters (excluding spaces): {charCount}");
    //        Console.WriteLine($"Total number of words (excluding spaces): {wordCount}");
    //    }
    //}

    //static int CountCharNoSpace(string text)
    //{
    //    int count = 0;
    //    foreach (char c in text)
    //    {
    //        if (!char.IsWhiteSpace(c))
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}

    //static int CountWordsNoSpace(string text)
    //{
    //    int count = 0;
    //    bool inWord = false;

    //    foreach (char c in text)
    //    {
    //        if (!char.IsWhiteSpace(c))
    //        {
    //            if (!inWord)
    //            {
    //                count++;
    //                inWord = true;
    //            }
    //        }
    //        else
    //        {
    //            inWord = false;
    //        }
    //    }
    //    return count;
    }
}