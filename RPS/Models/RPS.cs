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
                User.Wins ++;
            }
            else if (compChoice == "p" && userChoice == "r" || compChoice == "r" && userChoice == "s" || compChoice == "s" && userChoice == "p")
            {
                result = "Computer wins!";
                Comp.Wins ++;
            }
            else
            {
                result = "Try again.";
            }
            if (CheckForTwoWins())
            {
                if (User.Wins == 2)
                {
                    result = "USER HAS WON THE MATCH!";
                }
                else if (Comp.Wins == 2)
                {
                    result = "COMPUTER HAS WON THE MATCH!";
                }
            }
            return result;
        }

        public bool CheckForTwoWins()
        {
            bool matchWinner = false;
            if(User.Wins == 2)
            {
                matchWinner = true;
            }     
            else if(Comp.Wins == 2)
            {
                matchWinner = true;
            }   
            return matchWinner;
        }
    }

    public class Player
    {
        public string Item { get; set; }
        public int Wins { get; set; }
        public Player()
        {
            Wins = 0;
        }
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