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
        static public string username;
        static public string password;
        static public string loginStatus; //Admin or User?

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Cancel
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Submit
        private void button1_Click(object sender, EventArgs e)
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
            if (String.Equals(username, unameUser) && String.Equals(password,passUser))
            {

            }

            //If ADMIN
            else if (String.Equals(username, unameAdmin) && String.Equals(password, passAdmin))
            {

            }

            //If not a User or Admin 



            //Zach - Add the onClick command to load the next GUI HERE!.


        }

        //Remember Password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
