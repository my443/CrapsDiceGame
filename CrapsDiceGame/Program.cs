using CrapsDiceGame;



Console.WriteLine($"Hello, World!{GameState.Win}");
Die die = new Die();
int roll = die.RollDie();
Console.WriteLine(roll);
die.PrintDie(roll);
