using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.BL;
using System.IO;

namespace Challenge02.DL
{
    class MUserCRUD
    {
        public static List<MUser> Users = new List<MUser>();
        public static string path = "Users.txt";
        public static void LoadUsers()
        {
            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                string[] set = record.Split(',');
                string username = set[0];
                string password = set[1];
                MUser user = new MUser(username, password);
                UserToList(user);
            }
            file.Close();
        }
        public static void UserToList(MUser U)
        {
            Users.Add(U);
        }
        public static void UserToFile(MUser U)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(U.Username + "," + U.Password);
            file.Flush();
            file.Close();
        }
    }
}
