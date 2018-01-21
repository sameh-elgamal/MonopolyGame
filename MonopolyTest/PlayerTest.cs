using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly_Game.GameObjects;

namespace MonopolyTest
{
    [TestClass]
    public class Player
    {
        [TestMethod]
        public void TestIPlayerCreation()
        {
            MonopolyGame mp = new MonopolyGame();

            Assert.AreEqual(0, mp.CountPlayer());
            
            Monopoly_Game.GameObjects.Player Mido = new Monopoly_Game.GameObjects.Player("Mido", 200, mp);
            Assert.AreEqual(1, mp.CountPlayer());

            Assert.AreEqual("Mido", Mido.GetName());
            Assert.AreEqual(200, Mido.GetBalance());
            Assert.IsInstanceOfType(Mido.GetGame(), mp.GetType());
            Assert.AreEqual(0, Mido.GetPosition());


            Monopoly_Game.GameObjects.Player Sameh = new Monopoly_Game.GameObjects.Player();

            Assert.AreEqual(1, mp.CountPlayer());

            Assert.IsNull(Sameh.GetGame());
            Assert.AreEqual( 0 , Sameh.GetBalance());
            Assert.AreEqual("Player", Sameh.GetName());
            Sameh.Join(mp);
            Assert.IsInstanceOfType(Sameh.GetGame(), mp.GetType());
            Assert.AreEqual(2, mp.CountPlayer());

        }


        [TestMethod]
        public void TestIPosition()
        {

        }


        [TestMethod]
        public void TestJoinGameLeave()
        {
            MonopolyGame mp = new MonopolyGame();
            Monopoly_Game.GameObjects.Player mido = new Monopoly_Game.GameObjects.Player("Mido", 200);
            Monopoly_Game.GameObjects.Player sameh = new Monopoly_Game.GameObjects.Player("Sameh", 200);
            mido.Join(mp);
            sameh.Join(mp);
            Assert.AreEqual(2, mp.CountPlayer());
            mp.RemovePlayer(mido);
            Assert.IsNull(mido.GetGame());
            Assert.AreEqual(1, mp.CountPlayer());
            sameh.Leave();
            Assert.AreEqual(0, mp.CountPlayer());
            Assert.IsNull(sameh.GetGame());

            Monopoly_Game.GameObjects.Player Dodo = new Monopoly_Game.GameObjects.Player("Dodo", 200, mp);
            Assert.AreEqual(1, mp.CountPlayer());
            Assert.IsNotNull(Dodo.GetGame());
            Dodo.Leave();
            Assert.IsNull(Dodo.GetGame());
            Assert.AreEqual(0, mp.CountPlayer());


            mido.Join(mp);
            Assert.AreEqual(1, mp.CountPlayer());
            mido.Join(mp);
            Assert.AreEqual(1, mp.CountPlayer());


        }



        [TestMethod]
        public void TestMove()
        {
            MonopolyGame mp = new MonopolyGame();
            Monopoly_Game.GameObjects.Player mido = new Monopoly_Game.GameObjects.Player("Mido", 1500);
            mido.Join(mp);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(0, mido.GetPosition());
            Assert.AreEqual(1500, mido.GetBalance());
            mido.Jump(0);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(0, mido.GetPosition());
            Assert.AreEqual(1700, mido.GetBalance());
            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(1, mido.GetPosition());
            Assert.AreEqual(1700, mido.GetBalance());
            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(2, mido.GetPosition());
            Assert.AreEqual(1500, mido.GetBalance());

            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(3, mido.GetPosition());
            Assert.AreEqual(1500, mido.GetBalance());

            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(4, mido.GetPosition());
            Assert.AreEqual(1500, mido.GetBalance());

            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(5, mido.GetPosition());
            Assert.AreEqual(1500, mido.GetBalance());

            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(6, mido.GetPosition());
            Assert.AreEqual(1500, mido.GetBalance());

            mido.Jump(3);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(9, mido.GetPosition());
            Assert.AreEqual(1400, mido.GetBalance());

            mido.Jump(1);
            Console.WriteLine(mp.GetBoard().ToString());
            Assert.AreEqual(0, mido.GetPosition());
            Assert.AreEqual(1600, mido.GetBalance());

        }




    }
}
