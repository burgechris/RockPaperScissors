using System;
using Game;

class Program
{
    static void Main()
    {
        StartGame();
    }

    public static void StartGame()
    {
        Console.WriteLine("Type rock, paper, or scissors (R/P/S):");
        string input = Console.ReadLine();
        RPS rps  = new RPS();
        rps.User.ChooseItem(input);
        Console.WriteLine("------------------------------");
        Console.WriteLine("You chose " + rps.User.Item);
        rps.Comp.ChooseRandomly();
        Console.WriteLine("Computer chose " + rps.Comp.Item);
        Console.WriteLine(rps.GamePlay());
        Console.WriteLine("------------------------------");
        Console.WriteLine("Play again? (Y/N)");
        string response = Console.ReadLine();
        if (response[0].ToString().ToUpper() == "Y")
        {
            StartGame();
        }
        else
        {
            Console.WriteLine("Bye!");
        }
    }
}