using System;
using Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Welcome to the classic game of Rock, Paper, Scissors!");
        Console.WriteLine("Best two out of three wins!!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        RPS rps  = new RPS();
        StartGame(rps);
    }

    public static void StartGame(RPS rps)
    {
        Console.WriteLine("Type rock, paper, or scissors (R/P/S):");
        string input = Console.ReadLine();
        rps.User.ChooseItem(input);
        rps.Comp.ChooseRandomly();
        Console.WriteLine(rps.GamePlay());

        Console.WriteLine("------------------------------");
        Console.WriteLine("You chose " + rps.User.Item);
        Console.WriteLine("Computer chose " + rps.Comp.Item);
        Console.WriteLine("------------------------------");

        if (rps.CheckForTwoWins())
        {
            Console.WriteLine("Play again? (Y/N)");
            string response = Console.ReadLine();
            if (response[0].ToString().ToUpper() == "Y")
            {
                StartGame(rps);
            }
            else
            {
                Console.WriteLine("Bye!");
            }
        }
        
    }
}