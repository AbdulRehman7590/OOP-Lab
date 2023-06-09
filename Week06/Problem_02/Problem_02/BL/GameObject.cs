using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_02.UI;

namespace Problem_02.BL
{
    public class GameObject
    {
        public char[,] Shape;
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;
        string dir;
        int count;

        public GameObject()
        {
            Shape = new char[,] { { 'o', ' ', 'o' }, { ' ', 'o', ' ' }, { 'o', ' ', 'o' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
            if (Direction == "Patrol")
            {
                dir = "Right";
            }
            if (Direction == "Projectile")
            {
                count = 0;
            }
        }

        public GameObject(char[,] Shape, Point StartingPoint)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            Premises = new Boundary();
            Direction = "LeftToRight";
            if (Direction == "Patrol")
            {
                dir = "Left";
            }
            if (Direction == "Projectile")
            {
                count = 0;
            }
        }

        public GameObject(char[,] Shape, Point StartingPoint, string Direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Direction = Direction;
            Premises = new Boundary();
            if (Direction == "Patrol")
            {
                dir = "Left";
            }
            if (Direction == "Projectile")
            {
                count = 0;
            }
        }

        public GameObject(char[,] Shape, Point StartingPoint, Boundary Premises, string Direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
            if (Direction == "Patrol")
            {
                dir = "Left";
            }
            if (Direction == "Projectile")
            {
                count = 0;
            }
        }

        public void Erase()
        {
            Display.ClearScreen(Shape, StartingPoint);
        }

        public void Draw()
        {
            Display.DrawShape(Shape, StartingPoint);
        }

        public void Move()
        {

            if (this.Direction == "LeftToRight")
            {
                MovetoRight();
            }

            else if (this.Direction == "RightToLeft")
            {
                MovetoLeft();
            }

            else if (this.Direction == "Patrol")
            {
                if (this.StartingPoint.GetX() == this.Premises.TopLeft.GetX())
                {
                    dir = "Right";
                }

                else if (this.StartingPoint.GetX() == this.Premises.TopRight.GetX())
                {
                    dir = "Left";
                }

                if (dir == "Right")
                {
                    MovetoRight();
                }

                else if (dir == "Left")
                {
                    MovetoLeft();
                }
            }

            else if (this.Direction == "Diagonal")
            {
                MoveToBottomDiagonal();
            }

            else if (this.Direction == "Projectile")
            {
                if (count <= 4)
                {
                    MoveToUpperDiagonal();
                    count++;
                }
                else if (count > 4 && count <= 6)
                {
                    MovetoRight();
                    count++;
                }
                else if (count > 6 && count <= 10)
                {
                    MoveToBottomDiagonal();
                    count++;
                }
                if (count > 10)
                {
                    count = 0;
                }
            }

        }

        private void MovetoRight()
        {
            if(this.StartingPoint.GetX() < Premises.TopRight.GetX())
            {
                this.StartingPoint.SetX(StartingPoint.GetX() + 1);
            }
        }

        private void MovetoLeft()
        {
            if(this.StartingPoint.GetX() > this.Premises.TopLeft.GetX())
            {
                this.StartingPoint.SetX(StartingPoint.GetX() - 1);
            }
        }

        private void MoveToBottomDiagonal()
        {
            if ((this.StartingPoint.GetX() < this.Premises.BottomRight.GetX()) && (this.StartingPoint.GetY() < this.Premises.BottomRight.GetY()))
            {
                this.StartingPoint.SetX(StartingPoint.GetX() + 1);
                this.StartingPoint.SetY(StartingPoint.GetY() + 1);
            }
        }
        
        private void MoveToUpperDiagonal()
        {
            if ((this.StartingPoint.GetX() < this.Premises.BottomRight.GetX()) && (this.StartingPoint.GetY() < this.Premises.BottomRight.GetY()))
            {
                this.StartingPoint.SetX(StartingPoint.GetX() + 1);
                this.StartingPoint.SetY(StartingPoint.GetY() - 1);
            }
        }

    }
}
