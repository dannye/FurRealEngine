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

        //User properties
        public static string currUname;
        public static string currPass;
        public static string accountType;
        //Change to currUname = Value clicked in userAccountsBox.
        //Change to currPass = some DBMS value.

        public struct editedUser
        {
            string userN;//username
            string userP;//password
            string userAT;//account type
        };



        //Checks to see if the user selected is an admin or not.
        public void checkActType()
        {

            if (currUname == "Admin")
            {
                accountType = "Admin";
            }
            accountType = "User";

        }

        public ModifyAccountsGUI()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string username = unameBox.Text;
            string confirmUsername = confirmUnameBox.Text;
            string password = passBox.Text;
            string confirmPassword = confirmPassBox.Text;

            checkActType();


            //If username and confirm username match
            if (username == confirmUsername)
            {
                setUsername(currUname , username);

            }

            //If username and confirm username DO NOT match
            if (username != confirmUsername)
            {
                MessageBox.Show("The Username and Confirm Username fields do not match!");

            }

            //If password and confirm password match
            if (password == confirmPassword)
            {
                setPassword(currPass, password);

            }

            //If password and confirm password DO NOT match
            if (password != confirmPassword)
            {
                MessageBox.Show("The Password and Confirm Password fields do not match!");

            }


            //Check to see if both buttons are checked
            if (adminButton.Checked && userButton.Checked)
            {

                MessageBox.Show("A user can not be BOTH a user and an admin.");
            }

            //Check to see if both buttons are unchecked
            if ((adminButton.Checked = false) || (userButton.Checked = false))
            {

                MessageBox.Show("Please select user's Account Type.");
            }


            //If Admin Button is checked make the user an admin
            if (adminButton.Checked)
            {

                //Make User am Admin
                editedUser user;

                user.userAT = "admin";
            }


            //If User Botton checked make the user a user
            if (userButton.Checked)
            {

                //Make User a User
            }

       


            //At this point we would redirect back to where we want. This takes place after the user clicks "SAVE"

        }

        //Changes the current username to the username listed in the unameBox
        public string setUsername(string currName, string username)
        {
            return currName = username;
        }

        //Changes the current password to the password listed in the unameBox
        public string setPassword(string currPass, string password)
        {
            return currPass = password;
        }
    }
}
