using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial code with normal players. 
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";
            player2.Play(player1);
            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";
            player3.Play(player3);
            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";
            player1.Play(large);
            Console.WriteLine("-------------------");

            // Creating a smacktalkingplayer
            SmackTalkingPlayer smacks = new SmackTalkingPlayer();
            smacks.Name = "Gobi";
            smacks.Taunt = "Eat my shorts!";

            // OneHigherPlayer creation. (We get and set a name)
            OneHigherPlayer upper = new OneHigherPlayer();
            upper.Name = "Auska";

            // Creation of the HumanPlayer
            HumanPlayer hunam = new HumanPlayer();
            hunam.Name = "K-9";

            // Creating the CreativeSmackTalkingPLayer, who is different than the SmackTalking
            CreativeSmackTalkingPlayer caddy = new CreativeSmackTalkingPlayer();
            caddy.Name = "Inouske";

            // Adding to list of Players
            List<Player> players = new List<Player>() {
                player1, player2, player3, large, smacks, upper, hunam, caddy
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}