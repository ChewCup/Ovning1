using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userCommandInput;
                Console.Write("Type in the exercise task (1.1 - 1.25): ");
                userCommandInput = Console.ReadLine();
                if (userCommandInput == "1.1")
                {
                    IsNumberEqual();
                }
                else if (userCommandInput == "1.2")
                {
                    IsNumberEvenOrOdd();
                }
                else if (userCommandInput == "1.3")
                {
                    IsNumberPosOrNeg();
                }
                else if (userCommandInput == "1.4")
                {
                    CheckLeapYear();
                }
                else if (userCommandInput == "1.5")
                {
                    ElectionVoting();
                }
                else if (userCommandInput == "1.6")
                {
                    IntegerValue();
                }
                else if (userCommandInput == "1.7")
                {
                    PersonHight();
                }
                else if (userCommandInput == "1.8")
                {
                    PrintTenNaturalNumbers();
                }
                else if (userCommandInput == "1.9")
                {
                    TheSumOfTheTenNaturalNumers();
                }
                else if (userCommandInput == "1.10")
                {
                    SumOfInputNaturalNumbers();
                }
                else if (userCommandInput == "1.11")
                {
                    SumOfUserIntegerInput();
                }
                else if (userCommandInput == "1.12")
                {
                    CubeOfUserInput();
                }
                else if (userCommandInput == "1.13")
                {
                    MultiplyAGivenInteger();
                }
                else if (userCommandInput == "1.14")
                {
                    SaveIntegerInArray();
                }
                else if (userCommandInput == "1.15")
                {
                    ReverseArrayElements();
                }
                else if (userCommandInput == "1.16")
                {
                    SumOfAllElementsInArray();
                }
                else if (userCommandInput == "1.17")
                {
                    CopyArrayToAnother();
                }
                else if (userCommandInput == "1.18")
                {
                    CountDuplicateInArray();
                }
                else if (userCommandInput == "1.19")
                {
                    // hej fdsfsdf
                }
                else if (userCommandInput == "1.20")
                {
                    // testing2
                }
                //fdslfns
                else if (userCommandInput == "quit")
                {
                    break;
                }
            }
        }
        //////// Methods ////////
        // Uppgift 1.1
        static void IsNumberEqual()
        {
            int int1, int2;
            Console.WriteLine("Compare two integer if it equal or not.");
            Console.Write("Number1: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"First number is: {int1} \nSecond number is: {int2}");
            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        }
        // Uppgift 1.2
        static void IsNumberEvenOrOdd()
        {
            int intToCheck;
            Console.Write($"Check if the number is even or odd: ");
            intToCheck = Convert.ToInt32(Console.ReadLine());
            if (intToCheck % 2 == 0)
                Console.WriteLine($"{intToCheck} is an even integer.");
            else
            {
                Console.WriteLine($"{intToCheck} is an odd integer.");
            }
        }
        // Uppgift 1.3
        static void IsNumberPosOrNeg()
        {
            Console.Write("Check if the number is positive or negative: ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            if (int1 > 0)
            {
                Console.WriteLine($"{int1} is a positive integer!");
            }
            else if (int1 == 0)
            {
                Console.WriteLine($"{int1} is a neutral number!");
            }
            else
            {
                Console.WriteLine($"{int1} is an negative integer!");
            }
        }
        // Uppgift 1.4
        static void CheckLeapYear()
        {
            Console.Write("Check if the year is leap year or not: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is leap year!");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not leap year!");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is leap year!");
            }
            else
            {
                Console.WriteLine($"{year} is not leap year!");
            }
        }
        // Uppgift 1.5
        static void ElectionVoting()
        {
            Console.Write("How old are you?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are not eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You are eligible for casting your vote.");
            }
        }
        // Uppgift 1.6
        static void IntegerValue()
        {
            Console.Write("Enter a number: ");
            double m = Convert.ToDouble(Console.ReadLine());
            if (m > 0)
            {
                Console.WriteLine("The value of n = 1");
            }
            else if (m == 0)
            {
                Console.WriteLine("The value of n = 0");
            }
            else
            {
                Console.WriteLine("The value of n = -1");
            }
        }
        // Uppgift 1.7
        static void PersonHight()
        {
            Console.Write("Whats your hight in centimeter (cm)? ");
            double userHight = Convert.ToDouble(Console.ReadLine());
            if (userHight <= 135)
            {
                Console.WriteLine("You are short.");
            }
            else
            {
                Console.WriteLine("You are a tall.");
            }
        }
        // Uppgift 1.8
        static void PrintTenNaturalNumbers()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        // Uppgift 1.9
        static void TheSumOfTheTenNaturalNumers()
        {
            int sum = 0;
            Console.WriteLine("The first 10 natural numbers:");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nThe sum is: {sum}");
        }
        // Uppgift 1.10
        static void SumOfInputNaturalNumbers()
        {
            int sum = 0;
            Console.Write("Type in a number: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userInt; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine($"\nThe sum is: {sum}");
        }
        // Uppgift 1.11
        static void SumOfUserIntegerInput()
        {
            int[] integer = new int[10];
            double theSumOfTheInput = 0;
            Console.WriteLine("Enter 10 integers.");
            for (int i = 0; i <= 9; i++)
            {
                Console.Write($"Enter number{i+1}: ");
                integer[i] = Convert.ToInt32(Console.ReadLine());
                theSumOfTheInput += integer[i];
            }
            double average = theSumOfTheInput / integer.Length;
            Console.WriteLine($"The sum of 10 numbers: {theSumOfTheInput}\nThe average: {average}");
        }
        // Uppgift 1.12
        static void CubeOfUserInput()
        {
            Console.Write("The Cube of an integer up to the user integer input.\nYour input: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            double cubeOfIntegers = 0;
            for (int i = 1; i < userInput+1; i++)
            {
                cubeOfIntegers = Math.Pow(i, 3);
                Console.WriteLine($"Integer: {i}, cube of {i} is: {cubeOfIntegers}");
            }

        }
        // Uppgift 1.13
        static void MultiplyAGivenInteger()
        {
            Console.Write("Enter an integer to multiply.\nYour integer: ");
            int userInt = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int multi = userInt * i;
                Console.WriteLine($"{userInt} x {i} = {multi}");
            }
        }
        // Uppgift 1.14
        static void SaveIntegerInArray()
        {
            Console.Write("How many elements do you want to store in your array?\nYour number of elements in the array are: ");
            int storage = Convert.ToInt32(Console.ReadLine());
            int[] integer = new int[storage];
            for (int i = 0; i < storage; i++)
            {
                Console.Write($"element - {i}: ");
                integer[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in your array are: ");
            Console.WriteLine(string.Join(" ", integer));
        }
        // Uppgift 1.15
        static void ReverseArrayElements()
        {
            Console.Write("How many elements do you want to store in your array?\nYour number of elements in the array are: ");
            int storage = Convert.ToInt32(Console.ReadLine());
            int[] integer = new int[storage];
            for (int i = 0; i < storage; i++)
            {
                Console.Write($"element - {i}: ");
                integer[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in your array are:\n");
            Console.WriteLine(string.Join(" ", integer));
            
            // reverse the array
            Console.Write("The reversed array order are:\n");
            Array.Reverse(integer);
            foreach (int item in integer)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        // Uppgift 1.16
        static void SumOfAllElementsInArray()
        {
            int arraySum = 0;
            Console.Write("How many elements do you want to store in your array?\nYour number of elements in the array are: ");
            int storage = Convert.ToInt32(Console.ReadLine());
            int[] integer = new int[storage];
            Console.WriteLine($"Input {storage} elemtens in the array:");
            for (int i = 0; i < storage; i++)
            {
                Console.Write($"element - {i}: ");
                integer[i] = Convert.ToInt32(Console.ReadLine());
                arraySum += integer[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is: {arraySum}");
        }
        // Uppgift 1.17
        static void CopyArrayToAnother()
        {
            Console.Write("How many elements do you want to store in your array?\nYour number of elements in the array are: ");
            int storage = Convert.ToInt32(Console.ReadLine());
            int[] integer1 = new int[storage];
            Console.WriteLine($"Input {storage} elemtens in the array:");
            for (int i = 0; i < storage; i++)
            {
                Console.Write($"element - {i}: ");
                integer1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in your array are:\n");
            Console.WriteLine(string.Join(" ", integer1));
            // copy to another array
            int[] integer2 = new int[storage];
            for (int i = 0; i < storage; i++)
            {
                integer2[i] = integer1[i];
            }
            Console.Write("The elements  copied to your array are:\n");
            Console.WriteLine(string.Join(" ", integer2));

        }
        // Uppgift 1.18
        static void CountDuplicateInArray()
        {
            int dupliCount = 0;
            Console.Write("How many elements do you want to store in your array?\nYour number of elements in the array are: ");
            int storage = Convert.ToInt32(Console.ReadLine());
            string[] integer = new string[storage];
            Console.WriteLine($"Input {storage} elemtens in the array:");
            for (int i = 0; i < storage; i++)
            {
                Console.Write($"element - {i}: ");
                integer[i] = Console.ReadLine();
            }
            //
            for (int i = 0; i < storage; i++)
            {
                for (int j = i + 1; j < storage; j++)
                {
                    if (integer[i] == integer[j])
                    {
                        dupliCount += 1;
                    }
                }
            }
            Console.WriteLine(dupliCount);
        }
    }
}
