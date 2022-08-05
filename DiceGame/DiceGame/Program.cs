using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int prize = 0;
            Random x = new Random();

            int i = 1;
            while (i <= 1)
            {
                int number = x.Next(1, 6); // We roll the dice...
                Console.Write("in the range 1-6 " + (prize + 1) + ". roll the dice...:");
                int login = int.Parse(Console.ReadLine());
                if (login == number) // This part works when we find the number...
                {
                    Console.WriteLine("Congratulations! " + (prize + 1) + ". Your Dice Roll Is Correct...");
                    prize++; // Each time it is found, the reward is increased by one...
                }
                else
                {
                    // If a wrong guess is made, the loop is exited... Switching to the reward section...
                    Console.WriteLine((prize + 1) + ". You got it wrong in the game... Game Over...");
                    break; // We're breaking the cycle...
                }
            }
            if (prize > 0) // If the reward is greater than zero, we give money...
            {
                // Every time the prize increases, 10000 TL is given more money...
                Console.ForegroundColor = ConsoleColor.Yellow; // The command that allows us to write in yellow...
                Console.WriteLine("Your prize = " + prize * 10000 + "TL... Congratulations...");
            }
            else
            {
                // // If the prize is zero, it means that she did not know any of the competitors and we do not give money ...
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Unfortunately we can't give prizes... ");
            }
            Console.ReadKey();
        }
    }
}