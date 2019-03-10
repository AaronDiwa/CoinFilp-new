using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription = "Tails";
            Random rng = new Random();

            //Query the user
            Console.Write("Enter your guess Heads or Trails (H or T)");
            userGuess = Console.ReadLine();

            //Get a random number for coin flip
            coin = rng.Next(0, 2);

            if (coin == 1) {
                coinDescription = "Heads";
            }
        
            if ((coin == 0 && userGuess == "T") || (coin ==1 && userGuess == "H")) {
                Console.WriteLine("Coin was {0}, you win!", coinDescription);
            }      
            else {
                Console.WriteLine("Coin was {0}, you lose!", coinDescription);
            }
            Console.ReadLine();
        }
    }
}
