﻿using System;

namespace GuessingGameCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "toyota";
            string guess = "";


            while(guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }

            Console.Write("You Win!");


            Console.ReadLine();
        }
    }
}
