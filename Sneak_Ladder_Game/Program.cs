using System;

namespace Sneak_Ladder_Game
{
    class Program
    {
        public int Roll_Dice()
        {
            Random random = new Random();
            int Player = random.Next(1, 7);
            return Player;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the sneak ladder Game");
            int Player_1 = 0;
            Console.WriteLine("Player 1 Position is " + Player_1);
            Program sneakladderobj = new Program();
            int Roll_Dice_Value = sneakladderobj.Roll_Dice();
            Console.WriteLine("Roll Dice value is : " + Roll_Dice_Value);
        }
    }
}