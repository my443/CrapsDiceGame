using System;
using System.Collections.Generic;
using System.Text;
using CrapsDiceGame;

namespace CrapsDiceGame
{
    internal class Game
    {
        private GameState _gameState = GameState.RollAgain;
        private bool _isComingOutRoll = true;
        private int _pointNumber = 0;
        private Die Die = new Die();
        private List<int> winNumbers = new List<int> { 7, 11 };
        private List<int> loseNumbers = new List<int> { 2, 3, 12 };
        public Game()
        {
            NextRoll();
        }

        private void NextRoll()
        {
            if (_isComingOutRoll)
            {
                DoComingOutRoll();
            }
            else
            {
                DoPointNumberRoll();
            }
        }

        private void DoComingOutRoll()
        {
            Console.WriteLine($"------       Coming Out Roll      ------");
            int comingOutRoll = Die.RollTwoDiceAndPrintOutput();

            if (winNumbers.Contains(comingOutRoll)) {
                _gameState = GameState.Win;
            }

            if (loseNumbers.Contains(comingOutRoll)) {
                _gameState = GameState.Lose;
            }

            _isComingOutRoll = false;
            _pointNumber = comingOutRoll;
            GoToNextStep();
        }

        private void DoPointNumberRoll()
        {
            Console.WriteLine($"------Point Number: {_pointNumber}------");
            int roll = Die.RollTwoDiceAndPrintOutput();

            Console.WriteLine($"------Your roll: {roll}------");
            if (roll == 7)
            {
                _gameState = GameState.Lose;
            }
            else if (roll == _pointNumber) {
                _gameState = GameState.Win;
            }

            GoToNextStep();
        }

        private void GoToNextStep()
        {
            switch (_gameState)
            {
                case(GameState.Lose):
                    Console.WriteLine("You lost this game.");
                    PlayAgain();
                    break;
                case (GameState.Win):
                    Console.WriteLine("You won!");
                    PlayAgain();
                    break;
                default:

                    NextRoll();
                    break;
            }
        }

        private void PlayAgain() {
            Console.WriteLine("\nPlay again? (y/n)");

            // ReadKey(true) hides the pressed key from appearing in the console
            char again = Console.ReadKey(true).KeyChar;

            if (char.ToLower(again) == 'y')
            {
                // Call your StartGame logic here
                _isComingOutRoll = true;
                _pointNumber = 0;
                _gameState= GameState.RollAgain;
                //Console.Clear();
                NextRoll();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
