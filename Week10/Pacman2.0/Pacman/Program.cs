using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using Pacman.GL;

namespace Pacman
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(15, 22, grid);
            PacmanPlayer pacman = new PacmanPlayer('P', start);
            printMaze(grid);
            printGameObject(pacman);


            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.Up);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.Down);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);
                }
            }
            Console.ReadLine();
        }

        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.X, gameCell.Y);
            Console.Write(newGameObject.DisplayCharacter);

        }

        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.X, gameObject.CurrentCell.Y);
            Console.Write(gameObject.DisplayCharacter);

        }

        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.NextCell(direction);
            if (nextCell.CurrentGameObject.DisplayCharacter == ' ' || nextCell.CurrentGameObject.DisplayCharacter == '.')
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void printMaze(GameGrid grid)
        {
            for (int row = 0; row < grid.Rows; row++)
            {
                for (int col = 0; col < grid.Cols; col++)
                {
                    GameCell cell = grid.getCell(row, col);
                    printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

    }
}
