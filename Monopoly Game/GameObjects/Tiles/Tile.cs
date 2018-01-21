using Monopoly_Game.GameObjects.GameActions;
using Monopoly_Game.GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.Tiles
{
    public abstract class Tile : ITile
    {
        private IPlayer owner; 
        private string label;
        private IBoard board;
        private List<IGameAction> actions;

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
            this.actions = new List<IGameAction>();
        
        }

        public void AddAction(IGameAction action)
        {
            if (actions.Contains(action))
                return;
            action.LinkTile(this);
            actions.Add(action);
        }

        public void Buy(IPlayer owner)
        {
            this.owner = owner;
        }

        public List<IGameAction> GetActions()
        {
            List<IGameAction> availableActions = new List<IGameAction>(actions.Where(x => x.IsAllowed()));
            return availableActions;
        }

        public string GetLabel()
        {
            return this.label;
        }

        public IPlayer GetOwner()
        {
            return owner;
        }

        public int GetPrice()
        {
            throw new NotImplementedException();
        }

        public virtual int GetRent() 
        {
            return 0;
        }

        public bool IsOwned()
        {
            return owner == null ? false : true;
        }

        public abstract void Perfom();
       

        public void Sell(ITile tile)
        {
            throw new NotImplementedException();
        }
    }
}
