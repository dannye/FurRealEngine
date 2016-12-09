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

        public bool verifyAccount(User user)
        {

            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User] WHERE username='" + user.getUsername() + "' AND password = '" + user.getPassword() + "'", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            if (dt.Rows.Count > 0)
            {

                //User has been verified
                user.setAdminStatus(dt.Rows[0]["isAdmin"].Equals(1));
                
                return true;
            }
            else
            {
                // User is not a valid user
                MessageBox.Show("Please check your username and password.");

                return false;
            }
        }
    }

}
