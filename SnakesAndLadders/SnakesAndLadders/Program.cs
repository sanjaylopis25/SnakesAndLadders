using System;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            const int InitialPosition = 0;
            int PlayerPosition = InitialPosition;
            Console.WriteLine("Single player is starting with position " + PlayerPosition);
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Player got the number on dice is: " + DiceRoll);
            Console.ReadLine();
        }
    }
}
