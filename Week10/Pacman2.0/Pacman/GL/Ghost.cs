using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    abstract class Ghost : GameObject
    {
        public Ghost (GameObjectType type, char displayCharacter) : base(GameObjectType.ENEMY, displayCharacter) { }

        public abstract void Move(); 
    }
}
