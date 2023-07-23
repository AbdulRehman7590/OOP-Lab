using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType type;

        public GameObject(char displayCharacter, GameCell cell)
        {
            this.CurrentCell = cell;
            this.DisplayCharacter = displayCharacter;
            this.type=GameObject.GetGameObjectType(displayCharacter);
        }
        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.type = type;
            this.DisplayCharacter = displayCharacter;
            this.type = GameObject.GetGameObjectType(displayCharacter);

        }
        public static GameObjectType GetGameObjectType(char displayCharacter) 
        {
            if(displayCharacter == '#'|| displayCharacter=='%'||displayCharacter=='|')
            {
                return GameObjectType.WALL;
            }
            else if (displayCharacter == '.')
            {
                return GameObjectType.REWARD;
            }
            else if (displayCharacter == 'P')
            {
                return GameObjectType.PLAYER;
            }
            else if (displayCharacter == 'G')
            {
                return GameObjectType.ENEMY;
            }
            else
            {
                return GameObjectType.NONE;
            }
        }
    }
}
