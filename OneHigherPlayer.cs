using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            // Have the player roll one higher than their opponent. Which means that they should always win
            int otherRoll = other.Roll();
            int myRoll = otherRoll + 1;
            // Have the program tell the player the roll. 
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}.");
            Console.WriteLine($"{Name} wins!");
        }
    }
}
