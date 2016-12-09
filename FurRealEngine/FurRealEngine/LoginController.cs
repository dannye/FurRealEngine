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

        private bool adminPriv = true; //Is the User a valid admin from the database.

        

        public void verifyAccount(string username, string password)
        {


            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User] WHERE username='" + username + "' AND password = '" + password + "'", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ConfigGUI configGui = new ConfigGUI();//If User

            if (dt.Rows[0][0].ToString() == "1")
            {
                          
                Hide();

                adminPriv = true; //User has admin priv

                configGui.initConfigGui(new User(textBox1.Text, textBox2.Text, true));

                    MessageBox.Show("Logged privilege: Admin");//If Admin

                    //Put any admin access db stuff here if there is any.
                


            }
            else
            {

                adminPriv = false; //User does NOT have admin priv

                configGui.initConfigGui(new User(textBox1.Text, textBox2.Text, false));

                MessageBox.Show("Logged privilege: User");//If user

                
                

            }

            //validUser = false; // User is not a valid user
            

        }


        




    }

}
