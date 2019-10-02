
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
            if(User.Item == Comp.Item)
            {
                result = "It's a DRAW!";
            }
            else if (User.Item == "paper" && Comp.Item == "rock")
            {
                result = "User wins!";
            }



            return result;
        }
    }

    public class Player
    {
        public string Item { get; set; }
        public void ChooseItem(string item)
        {
            Item = item;
        }
        public void ChooseRandomly()
        {

        }
    }
}