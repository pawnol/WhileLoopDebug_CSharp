/*
 * While Loop Debug 
 * Pawelski
 * 1/121/2022
 * This program does not work as intended. Using your debugging skills,
 * find and fix all the bugs so the program works as intended. Record 
 * your changes on the code provided on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinFlip;
            string flipAgain = "Y";
            Random randomGen = new Random();
            while (flipAgain == "Y")
            {
                coinFlip = randomGen.Next(0, 2);
                if (coinFlip == 0)
                {
                    Console.WriteLine("Heads!");
                }
                else
                {
                    Console.WriteLine("Tails!");
                }
            }
        }
    }
}
