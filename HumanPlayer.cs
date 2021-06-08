using System; 

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            // Propmt the player to choose a number
            Console.Write($"Welcome, {Name}! What's the number of your Roll? (Any number between 1-6): ");
            // Parse the choice into a number for Human Players roll.
            int myRoll = int.Parse(Console.ReadLine());
            return myRoll; 
        } 
    }
}