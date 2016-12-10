using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurRealEngine
{
    public partial class ModifyAccountsGUI : Form
    {

        //User properties, deprecated, only used in unit tests
        public static string currUname;
        public static string currPass;
        public static string accountType;
        private User user;
        //Change to currUname = Value clicked in userAccountsBox.
        //Change to currPass = some DBMS value.
        ModifyAccountsController controller = new ModifyAccountsController();

        List<User> users;

        public ModifyAccountsGUI()
        {
            InitializeComponent();
            // eventually, loaded users from database rather than hardcode users
            users = controller.init(userAccountsBox);

            userAccountsBox.SelectedIndex = 0;
        }

        private void userAccountsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userAccountsBox.SelectedIndex >= 0)
            {
                user = users[userAccountsBox.SelectedIndex];
                unameBox.Text = user.getUsername();
                confirmUnameBox.Text = "";
                passBox.Text = user.getPassword();
                confirmPassBox.Text = "";
                if (user.getAdminStatus())
                {
                    adminButton.Checked = true;
                }
                else
                {
                    userButton.Checked = true;
                }
            }
        }

        public User getUser()
        {
            return user;
        }

        public void setActiveUser(User user)
        {
            this.user = user;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string username = unameBox.Text;
            string confirmUsername = confirmUnameBox.Text;
            string password = passBox.Text;
            string confirmPassword = confirmPassBox.Text;
            string accountType = "User";
            bool admin = false;

            //If username and confirm username DO NOT match
            if (username != confirmUsername)
            {
                MessageBox.Show("The Username and Confirm Username fields do not match!");
                return;
            }

            //If password and confirm password DO NOT match
            if (password != confirmPassword)
            {
                MessageBox.Show("The Password and Confirm Password fields do not match!");
                return;
            }


            //Check to see if both buttons are checked
            if (adminButton.Checked && userButton.Checked)
            {
                MessageBox.Show("A user can not be BOTH a user and an admin.");
                return;
            }

            //Check to see if both buttons are unchecked
            if ((adminButton.Checked == false) && (userButton.Checked == false))
            {
                MessageBox.Show("Please select user's Account Type.");
                return;
            }

            User user = users[userAccountsBox.SelectedIndex];
            if (user.getAdminStatus())
            {
                accountType = "Admin";
            }

            //If Admin Button is checked make the user an admin
            if (adminButton.Checked)
            {
                //Make User am Admin
                admin = true;
            }

            //If User Button checked make the user a user
            if (userButton.Checked)
            {
                //Make User a User
                admin = false;
            }

            bool passSuccess;
            bool nameSuccess;
            bool adminSuccess;

            //Updates the user's password
            passSuccess = controller.updateUserPassword(getUser(), password);

            if (passSuccess)
            {
                user.setPassword(password);
            }

            //Updates the user's username
            nameSuccess = controller.updateUserUsername(getUser(), username);

            if (nameSuccess)
            {
                user.setUsername(username);
                userAccountsBox.Items[userAccountsBox.SelectedIndex] = username;
            }

            //Updates the user's privileges
            adminSuccess = controller.updateUserType(getUser(), admin);

            if (adminSuccess)
            {
                user.setAdminStatus(admin);
                if (admin)
                {
                    accountType = "Admin";
                }
                else
                {
                    accountType = "User";
                }
            }

            if (passSuccess || nameSuccess || adminSuccess)
            {
                //At this point we would redirect back to where we want. This takes place after the user clicks "SAVE"
                MessageBox.Show("User's account has been updated.\n" +
                                " Username = " + user.getUsername() + ".\n" +
                                " Password = " + user.getPassword() + ".\n" +
                                " Account Type = " + accountType + ".");
            }
        }

        private void ModifyAccountsGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            ConfigGUI configGui = new ConfigGUI();
            Hide();
            configGui.ShowDialog();
        }
    }
}
