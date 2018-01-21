using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Game.GameObjects.GameActions
{
    public abstract class SimpleGameAction : IGameAction
    {
        private string actionKey;
        private string actionLabel;
        private ITile tile;
        private IMonopolyGame game;

        public SimpleGameAction(string actionKey, string actionLabel,  IMonopolyGame game)
        {
            this.actionKey = actionKey;
            this.actionLabel = actionLabel;
            this.game = game;
        }

        public string GetActionKey()
        {
            return actionKey;
        }

        public string GetActionText()
        {
            return actionLabel;
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
