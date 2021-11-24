using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Post
    {
        private int _PostID;
        private string _NoiDung;
        private bool _TrangThai;

        public int PostID { get => _PostID; set => _PostID = value; }
        public string NoiDung { get => _NoiDung; set => _NoiDung = value; }
        public bool TrangThai { get => _TrangThai; set => _TrangThai = value; }
    }
}
