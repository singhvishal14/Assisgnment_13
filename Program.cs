using System.Threading.Tasks;
using System;

//Task 1: Hello World


namespace BasicCSharpAssignment
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //        Console.ReadKey();
    //    }

    //}




    //Task 2: Variables and User Input (Write a Program that asks user for their Name)


    //class Program1
    //{
    //    static void Main(string[] args)
    //    {
    //        string UserName;
    //        Console.WriteLine("What is your name?");
    //        UserName = Console.ReadLine();

    //        Console.WriteLine($"Hello, {UserName}!");




            ////Task 3:Basic Arithmetic (Write a program that takes two integers as input from the user.)




            class Program2
            {
                static void Main(string[] args)
               {
                    Console.WriteLine("Enter the first number:");
                   int num1 = int.Parse(Console.ReadLine());

                   Console.WriteLine("Enter the second number:");
                   int num2 =int.Parse (Console.ReadLine());

                   int sum = num1 + num2;
                   int difference = num1 - num2;
                   int product = num1 * num2;

                  Console.WriteLine($"The Sum of {num1} and {num2} is: {sum}");
                    Console.WriteLine($"The Difference of {num1} and {num2} is: {difference}");
                   Console.WriteLine($"Rhe Product of {num1} and {num2} is: {product}");

                  if (num2 != 0)
                  {
                        double division = (double)num1 / num2;
                        double modulus = num1 % num2;

                       Console.WriteLine($"The Division of {num1} and {num2} is: {division}");
                        Console.WriteLine($"The Modulus of {num1} and {num2} is: {modulus}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
            Console.ReadKey();
        }
            }



    ////Task 4: Control Structures(Write a program to determine if a given number is even or odd.
    // Ask the user to enter an integer.)



    //class Program3
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter an integer:");
    //        int number = Convert.ToInt32(Console.ReadLine());

    //        if (number % 2 == 0)
    //        {
    //            Console.WriteLine($"{number} is even.");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{number} is odd.");
    //        }
    //    }
    //}



    ////Task 5: Loops




    //class Program4(Write a program that prints the numbers from 1 to 10 on the console.)
    //{
    //    static void Main(string[] args)
    //    {
    //        for (int i = 1; i <= 10; i++)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}




    ////Task 6: Arrays(Declare an integer array with five elements.)



    //class Program5
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = { 5, 10, 15, 20, 25 };

    //        int sum = 0;
    //        foreach (int num in numbers)
    //        {
    //            sum += num;
    //        }

    //        double average = (double)sum / numbers.Length;

    //        Console.WriteLine($"Sum: {sum}");
    //        Console.WriteLine($"Average: {average}");
    //    }
    //}



    ////Task 7: Methods(Write a method called &quot;CalculateFactorial&quot; that calculates the factorial of a given positive
    // integer.)



    //class Program6
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter an integer to calculate its factorial:");
    //        int number = int.Parse(Console.ReadLine());

    //        long factorial = CalculateFactorial(number);

    //        Console.WriteLine($"Factorial of {number} is {factorial}");
    //    }

    //    static long CalculateFactorial(int n)
    //    {
    //        if (n == 0)
    //            return 1;

    //        return n * CalculateFactorial(n - 1);
    //    }
    //}





    ////Task 8: Exception Handling(Write a program to prompt the user for their age.)



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int age = 0;
    //        bool isValidInput = false;

    //        while (!isValidInput)
    //        {
    //            Console.Write("Please enter your age: ");
    //            string input = Console.ReadLine();

    //            if (int.TryParse(input, out age))
    //            {
    //                if (age >= 0)
    //                {
    //                    isValidInput = true;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Invalid input. Age cannot be negative.");
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("Invalid input. Please enter a valid age (an integer).");
    //            }
    //        }

    //        if (age < 18)
    //        {
    //            Console.WriteLine("You are a minor.");
    //        }
    //        else if (age >= 18 && age < 65)
    //        {
    //            Console.WriteLine("You are an adult.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("You are a senior.");
    //        }

}

