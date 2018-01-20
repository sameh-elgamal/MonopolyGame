using Monopoly_Game.GameObjects.GameActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects
{
    public abstract class Tile : ITile
    {

        private string lable;
        private IBoard board;
        private List<IGameAction> availableActions;

        /// <summary>
        /// Creator function for the Tile class. 
        /// this class represent a Tile with lable and linked to a board.
        /// this class is simple - Classified classes will be needed to extend the 
        /// base class
        /// 
        /// </summary>
        /// <param name="lable"></param>
        /// <param name="board"></param>
        public Tile(string lable, IBoard board)
        {
            this.lable = lable;
            this.board = board;
            this.availableActions = new List<IGameAction>();

        }

        public void addAction(IGameAction action)
        {
            if (availableActions.Contains(action))
                return;
            action.linkTile(this);
            availableActions.Add(action);
        }

        public void Buy(ITile tile)
        {
            throw new NotImplementedException();
        }

        public List<IGameAction> GetActions()
        {
            return availableActions;
        }

        public string GetLable()
        {
            return this.lable;
        }

        public int getPrice()
        {
            throw new NotImplementedException();
        }




    public abstract void Perfom();
       

        public void Sell(ITile tile)
        {
            throw new NotImplementedException();
        }
    }
}
