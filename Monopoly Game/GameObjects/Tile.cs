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

        private string label;
        private IBoard board;
        private List<IGameAction> availabelActions;

        /// <summary>
        /// Creator function for the Tile class. 
        /// this class represent a Tile with label and linked to a board.
        /// this class is simple - Classified classes will be needed to extend the 
        /// base class
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="board"></param>
        public Tile(string label, IBoard board)
        {
            this.label = label;
            this.board = board;
            this.availabelActions = new List<IGameAction>();

        }

        public void AddAction(IGameAction action)
        {
            if (availabelActions.Contains(action))
                return;
            action.linkTile(this);
            availabelActions.Add(action);
        }

        public void Buy(ITile tile)
        {
            throw new NotImplementedException();
        }

        public List<IGameAction> GetActions()
        {
            return availabelActions;
        }

        public string GetLabel()
        {
            return this.label;
        }

        public int GetPrice()
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
