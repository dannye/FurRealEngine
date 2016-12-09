using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FurRealEngine
{
    static class DBManager
    {
        static public bool getUser(User u)
        {
            //connection to the database
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\furreal.mdf;Integrated Security=True");

            //query
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [User] WHERE username='" + u.getUsername() + "' AND password = '" + u.getPassword() + "'", connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            if (dt.Rows.Count > 0)
            {
                u.setAdminStatus(dt.Rows[0]["isAdmin"].Equals(1));
                return true;
            }
            return false;
        }
    }
}
