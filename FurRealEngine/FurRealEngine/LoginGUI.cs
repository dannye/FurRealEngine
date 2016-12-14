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
        private LoginController loginController;

        public LoginGUI()
        {
            InitializeComponent();
            AudioController.playAcquisition();
        }

        //Submit
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            loginController = new LoginController();
            string uname = textBox1.Text;
            string pass = textBox2.Text;

            User user = new User(uname, pass, false);

            if (loginController.verifyAccount(user))
            {
                ConfigGUI configGui = new ConfigGUI();
                Hide();
                configGui.initConfigGui(user);
            }
        }

        //Remember Password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
