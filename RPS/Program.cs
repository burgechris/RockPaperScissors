using System;
using Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Welcome to the classic game of Rock, Paper, Scissors!");
        Console.WriteLine("Best two out of three wins the match!!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        RPS rps  = new RPS();
        StartGame(rps);
    }

    public static void StartGame(RPS rps)
    {
        while (!rps.CheckForTwoWins())
        {
            Console.WriteLine("Choose rock, paper, or scissors (R/P/S):");
            string input = Console.ReadLine();
            rps.User.ChooseItem(input);
            rps.Comp.ChooseRandomly();
            Console.WriteLine("------------------------------");
            Console.WriteLine("You chose: " + rps.User.Item);
            Console.WriteLine("Computer chose: " + rps.Comp.Item);
            Console.WriteLine(rps.GamePlay());
            Console.WriteLine("------------------------------");
        }
        Console.WriteLine("Play again? (Y/N)");
        string response = Console.ReadLine();
        if (response[0].ToString().ToUpper() == "Y")
        {
            rps.User.Wins = 0;
            rps.Comp.Wins = 0;
            StartGame(rps);
        }
        else
        {
            Console.WriteLine("Bye!");
        }
    }
}