using System;
using System.Collections.Generic;
using System.Text;


namespace CrapsDiceGame
{
    internal class Die
    {
        private string[] _dicePictures = {  "-----\n|   |\n| O |\n|   |\n-----",
                                            "-----\n|   |\n|O O|\n|   |\n-----",
                                            "-----\n|  O|\n| O |\n|O  |\n-----",
                                            "-----\n|O O|\n|   |\n|O O|\n-----",
                                            "-----\n|O O|\n| O |\n|O O|\n-----",
                                            "-----\n|O O|\n|O O|\n|O O|\n-----"};

        public int RollDie()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public int RollTwoDiceAndPrintOutput() { 
            int roll1 = RollDie();
            int roll2 = RollDie();

            PrintDie(roll1);
            PrintDie(roll2);
            return roll1 + roll2;
        }

        public void PrintDie(int number) {
            Console.WriteLine(_dicePictures[number-1]);
        }
    }
}
