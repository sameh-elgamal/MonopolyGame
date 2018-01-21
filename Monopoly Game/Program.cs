using Monopoly_Game.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            MonopolyGame mp = new MonopolyGame();
            IPlayer sameh = new Player("Sameh", 1500, mp);
            IPlayer mido = new Player("Mido", 1500, mp);
            IPlayer jeff = new Player("Jeff", 1500, mp);
            Console.WriteLine(mp.GetBoard().ToString());
            Console.ReadLine();

            for (int i=0; i<20; i++)
            {
                sameh.PlayTurn();
                mido.PlayTurn();
                jeff.PlayTurn();
            }

        }
    }
}
