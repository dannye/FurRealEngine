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

        public bool updateUserPassword(User user, string password)
        {
            return DBManager.updatePassword(user, password);
        }

        public bool updateUserUsername(User user, string username)
        {
            return DBManager.updateUsername(user, username);
        }

        public bool updateUserType(User user, bool admin)
        {
            return DBManager.updateType(user, admin);
        }

    }
}
