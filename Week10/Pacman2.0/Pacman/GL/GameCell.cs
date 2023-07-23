using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class GameCell
    {
        public int X;
        public int Y;
        public GameObject CurrentGameObject;
        public GameGrid grid;

        public GameCell(int row, int col, GameGrid grid)
        {
            this.X = col;
            this.Y = row;
            this.grid = grid;
        }
        public GameCell(int row, int col, GameObject currentGameObject)
        {
            this.X = col;
            this.Y = row;
            this.CurrentGameObject = currentGameObject;
        }
        public GameCell NextCell(GameDirection direction)
        {
            if(direction == GameDirection.Left)
            {
                return this.grid.Grid[this.Y, this.X - 1];
            }
            else if(direction == GameDirection.Right)
            {
                return this.grid.Grid[this.Y, this.X + 1];

            }
            else if( direction == GameDirection.Up)
            {
                return this.grid.Grid[this.Y-1, this.X];
            }
            else if (direction == GameDirection.Down)
            {
                return this.grid.Grid[this.Y+1, this.X];
            }
            else
            {
                return null;
            }
        }
    }
}
