using System;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            const int InitialPosition = 0;
            const int Ladder = 1;
            const int Snake = 2;
            int PlayerPosition = InitialPosition;
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Player got the number on dice is: " + DiceRoll);
            Random random2 = new Random();
            int Checkoptions = random.Next(0, 3);
            switch (Checkoptions)
            {
                case Ladder:
                    PlayerPosition = PlayerPosition + DiceRoll;
                    Console.WriteLine("Player got Ladder. Player position is :" + PlayerPosition);
                    break;
                case Snake:
                    PlayerPosition = PlayerPosition - DiceRoll;
                    Console.WriteLine("Player got Snake. Player position is :" + PlayerPosition);
                    break;
                default:
                    Console.WriteLine("Player got Nothing. Player position is :" + PlayerPosition);
                    break;
            }
            Console.ReadLine();
        }
    }
}
