using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        // Overriding the Roll a player is given in order to have them obly roll 4-6.
        public override int Roll()
        {
            return new Random().Next(4, 6);
        }
        public override void Play(Player other)
        {
            int soreRoll = Roll();
            // other used from above, from public class declarartion
            int otherRoll = other.Roll();
            // Writing what each player will roll after the above method was used.
            Console.WriteLine($"{Name} rolls a {soreRoll}!");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}!");

            // We need to throw exception, since the player is a sore loser, who only rolls between a 4-6.
            if (soreRoll > otherRoll)
            {
                Console.WriteLine($"{Name} wins!");
            }
            else
            {
                throw new Exception($"{Name} throws a fit!");
            }
        }
    }
}