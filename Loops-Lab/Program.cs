using System;
using System.ComponentModel;

namespace Loops_Lab;
class Program
{
    static void Main(string[] args)
    {
        //Task 1
        //Console.WriteLine("Hello, World!");

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Hello");
        //}

        //Task 2
        //for (int i = 0; i < 11; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //Task 3
        //for (int i = 10; i > -1; i--)
        //{
        //    Console.WriteLine(i);
        //}

        //Task 4
        //Console.WriteLine("How many times do you want to write the prompt?");
        //int answer = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < answer; i++)
        //{
        //    Console.WriteLine("devCodeCamp");
        //}

        //Task 5
        //string packers = "packers";
        //foreach (char letter in packers)
        //{
        //    Console.WriteLine(letter);
        //}

        //Task 6
        //for (int num=0; num<=100; num++)
        //{
        //    //Console.WriteLine(num);
        //    if (num % 3 == 0 && num % 5 == 0)
        //    {
        //        Console.WriteLine("fizzbuzz");
        //    }
        //    else if (num % 3 == 0)
        //    {
        //        Console.WriteLine("fizz");
        //    }
        //    else if(num % 5 == 0)
        //    {
        //        Console.WriteLine("buzz");
        //    }
        //    else
        //    {
        //        Console.WriteLine(num);
        //    }
        //}

        //Task 7
        //int count = 0;

        //while (count < 5)
        //{
        //    Console.WriteLine("Hello!");
        //    count++;
        //}

        //Task 8
        string correctPassword = "password1";
        Console.WriteLine("Please enter your password: ");
        string userPassword = Console.ReadLine();

        while (userPassword != correctPassword)
        {
            Console.WriteLine("Incorrect password. Try again: ");
            userPassword = Console.ReadLine();
        }
        Console.WriteLine("User Validated!");
        Console.WriteLine("new token");
    }
}

