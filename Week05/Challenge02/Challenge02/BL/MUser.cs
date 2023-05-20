using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge02.DL;

namespace Challenge02.BL
{
    public class MUser
    {
        public MUser(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public string Username;
        public string Password;

        public int CheckRole()
        {
            int opt = 0;
            if (Username == "AAA" && Password == "111")
            {
                opt = 1;
            }
            else
            {
                foreach (var user in MUserCRUD.Users)
                {
                    if (Username == user.Username && Password == user.Password)
                    {
                        opt = 2;
                        break;
                    }
                }
            }
            return opt;
        }
    }
}
