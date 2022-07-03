using System;
using System.Collections.Generic;
namespace PlayerManager1
{
    class Program
    {
        private static List<Player> playerList;
        
        static void Main(string[] args)
        {
            Console.WriteLine("How many players are there?");
            int numPlayers = Int32.Parse(Console.ReadLine());
            playerList = new List<Player>();

            for (int i = 0; i < numPlayers; i++)
            {
                System.Console.WriteLine("Player's name?");
                string name = Console.ReadLine();
                System.Console.WriteLine("Player's score?");
                int score = Int32.Parse(Console.ReadLine());

                
                playerList.Add(new Player(name, score));
            }
            CompareScore();
        }

        public static void CompareScore()
        {
            System.Console.WriteLine("What is the value you wish to compare?");
            int compareScore = Int32.Parse(Console.ReadLine());

            foreach (Player item in playerList)
            {
                if (item.Score > compareScore)
                {
                    System.Console.WriteLine($"{item.Name} has a higher score than {compareScore}");

                }
            } 
        }
    }
}
