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

           
            //If username and confirm username match
            if (username == confirmUsername)
            {
                //Set currUsername to username

            }

            //If username and confirm username DO NOT match
            if (username != confirmUsername)
            {
                //Throw an error message

            }

            //If password and confirm password match
            if (password == confirmPassword)
            {
                //Set currPassword to password

            }

            //If password and confirm password DO NOT match
            if (password != confirmPassword)
            {
                //Throw an error message

            }


            //Check to see if both buttons are checked
            if (adminButton.Checked && userButton.Checked)
            {

                //Error message stating to select one or the other
            }

            //Check to see if both buttons are unchecked
            if ((adminButton.Checked = false) || (userButton.Checked = false))
            {

                //Error message stating to select one or the other
            }


            //If Admin Button is checked make the user an admin
            if (adminButton.Checked)
            {

                //Make User am Admin
            }


            //If User Botton checked make the user a user
            if (userButton.Checked)
            {

                //Make User a User
            }



            //At this point we would redirect back to where we want.

        }
    }
}
