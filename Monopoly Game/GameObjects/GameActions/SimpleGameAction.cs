using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public abstract class SimpleGameAction : IGameAction
    {
        private string actionLable;
        private ITile tile;
        private IMonopolyGame game;

        public SimpleGameAction(string actionLabel,  IMonopolyGame game)
        {
            this.actionLable = actionLabel;
            this.game = game;
        }

        public string GetActionText()
        {
            return actionLable;
        }

        public IMonopolyGame GetGame()
        {
            return game;
        }

        public ITile GetTile()
        {
            return tile;
        }

        public void linkTile(ITile tile)
        {
            this.tile = tile;
        }

        public abstract void Perform();
    
    }
}
