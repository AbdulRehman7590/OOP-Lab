using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class PacmanPlayer:GameObject
    {
        public PacmanPlayer(GameObjectType type, char displayCharacter) :base(GameObjectType.PLAYER, displayCharacter)
        {

        }
        public PacmanPlayer(char displayCharacter, GameCell cell) : base(displayCharacter,cell)
        {

        }
        
    }
}
