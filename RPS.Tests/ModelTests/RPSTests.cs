//testing
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Test
{
    [TestClass]
    public class RPSTest
    {
        RPS rps = new RPS();

        [TestMethod]
        public void GamePlay_SameItem_Draw()
        {
        //Arrange
        rps.User.ChooseItem("rock");
        rps.Comp.ChooseItem("rock");
        //Act
        string result = rps.GamePlay();
        //Assert
        Assert.AreEqual("It's a DRAW!", result);
        }

        [TestMethod]
        public void GamePlay_PaperBeatsRock_UserWins()
        {
        //Arrange
        rps.User.ChooseItem("paper");
        rps.Comp.ChooseItem("rock");
        //Act
        string result = rps.GamePlay();
        //Assert
        Assert.AreEqual("User wins!", result);
        }

        [TestMethod]
        public void GamePlay_RockBeatsScissors_UserWins()
        {
        //Arrange
        rps.User.ChooseItem("rock");
        rps.Comp.ChooseItem("scissors");
        //Act
        string result = rps.GamePlay();
        //Assert
        Assert.AreEqual("User wins!", result);
        }
    }
}