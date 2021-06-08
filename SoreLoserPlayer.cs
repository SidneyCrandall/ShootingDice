using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int cryBabyRoll = Roll();
            // other used from above, from public class declarartion
            int otherRoll = other.Roll();
            // Writing what each player will roll after the above method was used.
            Console.WriteLine($"{Name} rolls a {cryBabyRoll}!");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}!");

            // An exception to be thrown. 
            if (cryBabyRoll > otherRoll)
            {
                Console.WriteLine($"{Name} wins");
            }
            else
            {
                throw new Exception($"{Name} cries hysterically!");
            }
        }
    }
}