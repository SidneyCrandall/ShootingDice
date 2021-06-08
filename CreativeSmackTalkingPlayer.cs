using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        // Using a constructor, we will create smack talk for our players to randomly generate. 
        public List<string> SmackTalk { get; } = new List<string>()
        {
            "today's the day you become useful.",
            "you are the reason they put instructions on shampoo.",
            "you're a planting plant.",
            "you fight like a dairy farmer!",
            "every enemy I've met, I've annihilated.",
            "let me just get you a menu, because you're about to get served.",
            "did you hear a bell ring? Because someone just got schooled.",
            "you think you're too cool for school, but I got a newsflash for you, Walter Cronkite. You aren't."
        };

        public override void Play(Player other)
        {
            // Called from the player file
            base.Play(other);
            // we need to randomize the nu,ber of taunts
            int RandomizeTaunt = new Random().Next(8);
            // Console for when the player is playing they atunt the other player.
            Console.WriteLine($"You, {other.Name}, {SmackTalk[RandomizeTaunt]}"); 
        }
    }
}