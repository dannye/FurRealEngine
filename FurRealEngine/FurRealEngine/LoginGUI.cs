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
    public partial class LoginGUI : Form
    {

        //Public vars
        public string username;
        public string password;
        public string loginStatus; //Admin or User?

        public LoginGUI()
        {
            InitializeComponent();
        }

        //Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;

            username = uname; //Sets var username to the value in textBox1.
            password = pass; //Sets var password to the value in textBox2.



            //Users login status//

            // Temp hardcode to determine it the user is a user or an admin.

            //User Login Credentials
            string unameUser = "user";
            string passUser = "password";

            //Admin Login Credentials
            string unameAdmin = "admin";
            string passAdmin = "password";

            //If USER
            if (String.Equals(username, unameUser) && String.Equals(password, passUser))
            {

                //Zach - This is if they are a user.
                //Display next GUI..
                ConfigGUI configGui = new ConfigGUI();
                Hide();
                configGui.initConfigGui(new User(uname, passUser, false));
            }

            //If ADMIN
            else if (String.Equals(username, unameAdmin) && String.Equals(password, passAdmin))
            {

                //Zach - This is if they are an Admin.
                //Display next GUI..
                ConfigGUI configGui = new ConfigGUI();
                Hide();
                configGui.initConfigGui(new User(uname, passUser, true));
            }

            //If not a User or Admin 






        }

        //Remember Password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
