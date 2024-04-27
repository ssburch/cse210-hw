using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNUmber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNUmber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNUmber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNUmber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}