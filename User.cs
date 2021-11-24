using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap
{
    public class User
    {
        private string _HoTen;
        private string _email;

        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
