using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    class LoginController
    {
        public bool verifyAccount(User user)
        {
            if (DBManager.getUser(user))
            {
                return true;
            }
            else
            {
                // User is not a valid user
                MessageBox.Show("Please check your username and password.");

                return false;
            }
        }
    }
}
