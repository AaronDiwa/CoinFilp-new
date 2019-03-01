using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            //Query the user
            Console.Write("Enter your guess Heads or Trails (H or T)");
            userGuess = Console.ReadLine();

            //Get a random number for coin flip
            coin = rng.Next(0, 2);

            if (coin == 0 && userGuess == "T")
            {
                Console.WriteLine("Coin was Tails, you win!");
            }
            else if (coin ==1 && userGuess == "H")
            {
                Console.WriteLine("Coin was Heads, you win!");
            }            
            else {
                if (coin == 0)
                {
                    Console.WriteLine("Coin was Tails, you lose!");
                }
                else {
                    Console.WriteLine("Coin was Heads, you lose!");
                }
            }
            
            Console.ReadLine();
        }
    }
}
