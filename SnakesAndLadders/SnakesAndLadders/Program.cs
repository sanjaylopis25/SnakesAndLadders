using System;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            const int InitialPosition = 0;
            const int WinningPosition = 100;
            const int Ladder = 1;
            const int Snake = 2;
            int Player1Position = InitialPosition;
            int Player2Position = InitialPosition;
            int count = 0;
            int count2 = 0;
            while (Player1Position <= WinningPosition)
            {
                Random random1 = new Random();
                int DiceRoll = random1.Next(1, 7);
                //To track the numbers of loop ran till winning, we have to assign an incremental variable within the loop
                count++;
                Console.WriteLine("Player1 got the number on dice is: " + DiceRoll);
                Random random2 = new Random();
                int Checkoptions = random2.Next(0, 3);
     
                switch (Checkoptions)
                {
                    case Ladder:
                        Player1Position = Player1Position + DiceRoll;
                        //Here to prevent the player position to surpass the winning position we have to give the if condition.
                        if (Player1Position > WinningPosition)
                        {
                            Player1Position = Player1Position - DiceRoll;
                            Console.WriteLine("Player1 got Ladder. Player1 position is :" + Player1Position);
                        }
                        //Here if player reaches to 100, we have to declare him the winner.
                        else if (Player1Position == WinningPosition)
                        {
                            Console.WriteLine("Player1 reached " + Player1Position);
                            //Player 1 ends his play here.Start the player 2 from here. 
                            while (Player2Position <= WinningPosition)
                            {
                                Random random3 = new Random();
                                int DiceRoll2 = random3.Next(1, 7);
                                //To track the numbers of loop ran till winning, we have to assign an incremental variable within the loop
                                count2++;
                                Console.WriteLine("Player2 got the number on dice is: " + DiceRoll2);
                                Random random4 = new Random();
                                int Checkoptions2 = random4.Next(0, 3);

                                switch (Checkoptions2)
                                {
                                    case Ladder:
                                        Player2Position = Player2Position + DiceRoll2;
                                        //Here to prevent the player position to surpass the winning position we have to give the if condition.
                                        if (Player2Position > WinningPosition)
                                        {
                                            Player2Position = Player2Position - DiceRoll2;
                                            Console.WriteLine("Player2 got Ladder. Player2 position is :" + Player2Position);
                                        }
                                        //Here if player reaches to 100, we have to declare him the winner.
                                        else if (Player2Position == WinningPosition)
                                        {
                                            Console.WriteLine("Player2 reached " + Player2Position);
                                            //To Count the number of times the dice was played
                                            //We have to write the incremental variable which we used to track the numbers of iterations performed by a loop.
                                            Console.WriteLine("Number of times the player1 rolled the dice is :" + count);
                                            Console.WriteLine("Number of times the player2 rolled the dice is :" + count2);
                                            if (count < count2)
                                            {
                                                Console.WriteLine("Player1 Won the game");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Player2 Won the game");
                                                Console.ReadLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Player2 got Ladder. Player2 position is :" + Player2Position);
                                        }
                                        break;
                                    case Snake:
                                        Player2Position = Player2Position - DiceRoll2;
                                        //Here we have to give the if condition so that player position doesn't goto negative value.
                                        if (Player2Position < InitialPosition)
                                        {
                                            Player2Position = InitialPosition;
                                            Console.WriteLine("Player2 got Snake. Player2 position is :" + Player2Position);
                                        }
                                        //Here if the player position is not negative player position is usually updated.
                                        else
                                        {
                                            Console.WriteLine("Player2 got Snake. Player2 position is :" + Player2Position);
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Player2 got Nothing. Player2 position is :" + Player2Position);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Player1 got Ladder. Player1 position is :" + Player1Position);
                        }
                        break;
                    case Snake:
                        Player1Position = Player1Position - DiceRoll;
                        //Here we have to give the if condition so that player position doesn't goto negative value.
                        if (Player1Position < InitialPosition)
                        {
                            Player1Position = InitialPosition;
                            Console.WriteLine("Player1 got Snake. Player1 position is :" + Player1Position);
                        }
                        //Here if the player position is not negative player position is usually updated.
                        else
                        {
                            Console.WriteLine("Player1 got Snake. Player1 position is :" + Player1Position);
                        }
                        break;
                    default:
                        Console.WriteLine("Player1 got Nothing. Player1 position is :" + Player1Position);
                        break;
                }
            }         
        }
    }
}
