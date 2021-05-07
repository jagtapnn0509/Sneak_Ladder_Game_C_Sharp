using System;

namespace Sneak_Ladder_Game
{
    class Program
    {
        static int flag = 0;
        public int Roll_Dice()
        {
            Random random = new Random();
            int Roll_Dice_Value = random.Next(1, 7);
            return Roll_Dice_Value;
        }
        public void Change_Player()
        {
            if (flag == 1)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
            }
        }

        public int Check_Option(int Roll_Dice_Value, int Player_1,int Privious_postion)
        {
            Random random = new Random();
            int Option = random.Next(0, 3);

            switch (Option)
            {
                case 1:
                    Console.WriteLine("Player got Ladder");
                    Player_1 = Player_1 + Roll_Dice_Value;

                    break;
                case 2:
                    Console.WriteLine("Player got Sneak");
                    Player_1 = Player_1 - Roll_Dice_Value;
                    if (Player_1 < 0)
                    {
                        Player_1 = 0;
                    }
                    Change_Player();
                    break;
                default:
                    Console.WriteLine("Player got No Play");
                    Change_Player();
                    break;
            }
            return Player_1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the sneak ladder Game");
            int Player_1 = 0;
            int Player_2 = 0;
            int Player_1_count = 0;
            int Player_2_count = 0;
            int Roll_Dice_value;
            while (Player_1 < 100 && Player_2 < 100)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Program sneakladderobj = new Program();
                if (flag == 0)
                {
                    Console.WriteLine("********Player One Played the game*******");
                    Roll_Dice_value = sneakladderobj.Roll_Dice();
                    Console.WriteLine("Roll Dice value is : " + Roll_Dice_value);
                    Player_1_count = Player_1_count + 1;
                    int Player1_Privious_postion = Player_1;
                    Player_1 = sneakladderobj.Check_Option(Roll_Dice_value, Player_1, Player1_Privious_postion);
                    if (Player_1 > 100)
                    {
                        Player_1 = Player1_Privious_postion;
                    }
                    
                }
                else
                {
                    Console.WriteLine("********Player Two Played the game*******");
                    Roll_Dice_value = sneakladderobj.Roll_Dice();
                    Console.WriteLine("Roll Dice value is : " + Roll_Dice_value);
                    Player_2_count = Player_2_count + 1;
                    int Player2_Privious_postion = Player_2;
                    Player_2 = sneakladderobj.Check_Option(Roll_Dice_value, Player_2, Player2_Privious_postion);
                    if (Player_2 > 100)
                    {
                        Player_2 = Player2_Privious_postion;
                    }
                    
                }
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Player1 Position is : " + Player_1);
                Console.WriteLine("Player2 Position is : " + Player_2);
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("No of times dice roll for player 1: " + Player_1_count);
            Console.WriteLine("No of times dice roll for player 2: " + Player_2_count);
            if ( Player_1 == 100)
            {
                Console.WriteLine("Player 1 Won the game");
            }
            else
            {
                Console.WriteLine("Player 2 Won the game");
            }
        }
    }
}