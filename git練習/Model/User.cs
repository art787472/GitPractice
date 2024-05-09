﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git練習
{
    internal class User
    {
        public string id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string id, string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }
    }
}
