using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public interface IBoard
    {
        void CreateBoard();
        //ITile getTiles();
        int getTileCount();
        ITile getTileAt(int index);
    }
}
