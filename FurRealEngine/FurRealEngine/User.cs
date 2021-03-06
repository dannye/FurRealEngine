﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    public class User
    {
        private string username;
        private string password;
        private bool isAdmin;

        public User(string username, string password, bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setAdminStatus(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public bool getAdminStatus()
        {
            return isAdmin;
        }

    }
}
