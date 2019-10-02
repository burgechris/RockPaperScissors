using System;

namespace Game
{
    public class RPS
    {
        public Player User { get; set; }
        public Player Comp { get; set; }
        public RPS()
        {
            User = new Player();
            Comp = new Player();
        }
        public string GamePlay()
        {
            string result = "";
            string userChoice = User.Item[0].ToString().ToLower();
            string compChoice = Comp.Item[0].ToString().ToLower();
            if (userChoice == compChoice)
            {
                result = "It's a DRAW!";
            }
            else if (userChoice == "p" && compChoice == "r" || userChoice == "r" && compChoice == "s" || userChoice == "s" && compChoice == "p")
            {
                result = "User wins!";
            }
            else if (compChoice == "p" && userChoice == "r" || compChoice == "r" && userChoice == "s" || compChoice == "s" && userChoice == "p")
            {
                result = "Computer wins!";
            }
            else
            {
                result = "Try again.";
            }
            return result;
        }
    }

    public class Player
    {
        public string Item { get; set; }
        public void ChooseItem(string item)
        {
            if (item[0].ToString().ToLower() == "r")
            {
                Item = "rock";
            }
            else if (item[0].ToString().ToLower() == "p")
            {
                Item = "paper";
            }
            else if (item[0].ToString().ToLower() == "s")
            {
                Item = "scissors";
            }
        }
        public void ChooseRandomly()
        {
            string[] items = { "rock", "paper", "scissors" };
            Random random = new Random();
            int i = random.Next(0, items.Length-1);
            Item = items[i];
        }
    }
}