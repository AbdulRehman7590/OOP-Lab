using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class GameGrid
    {
        public GameCell[,] Grid;
        public int Rows;
        public int Cols;

        public GameGrid(string filename, int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.Grid = new GameCell[rows, cols];
            LoadGrid(filename);

        }
        public GameCell getCell(int row, int col)
        {
            return Grid[row, col];
        }
        private void LoadGrid(string filename)
        {
            string path = filename;
            if (File.Exists(path))
            {
                string line;
                StreamReader stage = new StreamReader(path);
                for (int row = 0; row < this.Rows; row++)
                {
                    line = stage.ReadLine();
                    for (int col = 0; col < this.Cols; col++)
                    {
                        GameCell cell = new GameCell(row, col, this);
                        Char tempChar = line[col];
                        GameObjectType type = GameObject.GetGameObjectType(tempChar);
                        GameObject gameObject = new GameObject(type, tempChar);
                        cell.CurrentGameObject = gameObject;
                        Grid[row, col] = cell;
                    }
                }

                stage.Close();
            }
            else
            {
                Console.WriteLine("Stage Loading Error!!!");
            }
        }

    }
}
