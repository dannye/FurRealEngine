using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace FurRealEngine
{

    class LoginController : LoginGUI
    {

        public static bool validUser = true; //Is the User a valid user from the database.

        

        public void verifyAccount(string username, string password)
        {


            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ethan\Source\Repos\cs325-2_16f_guldukat\FurRealEngine\FurRealEngine\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Count(*) FROM User WHERE username='" + textBox1.Text + "' and password = '" + textBox2.Text + "'", connection);

            DataTable dt = new DataTable();

            if (dt.Rows[0][0].ToString() == "1")
            {

                validUser = true; //User has been verified

                ConfigGUI configGui = new ConfigGUI();//If User
                Hide();

                if ( textBox1.Text == "Admin")//If admin
                {
                    
                    configGui.initConfigGui(new User(textBox1.Text, textBox2.Text, true));

                    MessageBox.Show("Logged privilege: Admin");

                    //Put any admin access db stuff here if there is any.
                }


                
                configGui.initConfigGui(new User(textBox1.Text, textBox2.Text, false));

                MessageBox.Show("Logged privilege: User");

            }
            else
            {
                validUser = false; // User is not a valid user
                MessageBox.Show("Please check your username and password.");

            }

    
        }







    }

}
