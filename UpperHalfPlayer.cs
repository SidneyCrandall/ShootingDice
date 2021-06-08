using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Most players have a 6 sided di. Therefore, Mugen will only be able to a 4 or higher
            return new Random().Next(4, 6);
        }
    }
}