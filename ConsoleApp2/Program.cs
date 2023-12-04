//using System;
//using System.Diagnostics.Tracing;
//using System.Formats.Asn1;
//using System.Reflection.Metadata.Ecma335;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Transactions;

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
Console.WriteLine("this is the question7\n.......................................");
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
Console.WriteLine("this is the question8\n.......................................");
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



