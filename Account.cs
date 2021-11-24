using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Account
    {
        private string _email;
        private string _password;
        private bool _trangthai;

        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public bool Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
