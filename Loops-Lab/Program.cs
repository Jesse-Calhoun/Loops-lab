﻿namespace Loops_Lab;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Hello");
        //}

        //for (int i = 0; i < 11; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //for (int i = 10; i > -1; i--)
        //{
        //    Console.WriteLine(i);
        //}

        Console.WriteLine("How many times do you want to write the prompt?");
        int answer = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < answer; i++)
        {
            Console.WriteLine("devCodeCamp");
        }
    }
}

