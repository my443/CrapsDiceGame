using System;
using System.Collections.Generic;
using System.Text;

namespace CrapsDiceGame
{
    internal class Scoreboard
    {
        private int _win = 0;
        private int _loss = 0;

        public void AddWin() { 
            _win++;
        }

        public void AddLoss()
        {
            _loss++;
        }

        public void ShowScore() {
            Console.WriteLine($"Wins: {_win}. Losses: {_loss}");
        }

    }
}
