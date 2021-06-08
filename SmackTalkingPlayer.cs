using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        // Random taunt we will give player later
        public string Taunt { get; set; }

        // Randomly have the character play.
        public override void Play(Player other)
        {
            Console.WriteLine($"{Name} says '{Taunt}!'"); 
            base.Play(other);
        }
    }
}
