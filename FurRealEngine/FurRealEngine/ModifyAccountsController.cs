using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    class ModifyAccountsController
    {
        public List<User> init(ListBox userAccountsBox)
        {
            List<User> users = DBManager.getUsers();
            foreach (User user in users)
            {
                userAccountsBox.Items.Add(user.getUsername());
            }
            return users;
        }

        public void updateUserPassword(User user, string password)
        {
            DBManager.updatePassword(user, password);
        }

        public void updateUserUsername(User user, string username)
        {
            DBManager.updateUsername(user, username);
        }

    }
}
