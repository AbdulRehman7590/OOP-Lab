using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Problem_02.BL;
using Problem_02.UI;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            
            GameObject g1 = new GameObject(triangle, new Point(10, 30), "Projectile");
            GameObject g2 = new GameObject(optriangle, new Point(10, 40), "Patrol");
            

            List<GameObject> lst = new List<GameObject>() { g1, g2 };            
            
            while (true)
            {
                Thread.Sleep(200);
                foreach (GameObject x in lst)
                {
                    x.Erase();
                    x.Move();
                    x.Draw();
                }
            }
        }
    }
}
