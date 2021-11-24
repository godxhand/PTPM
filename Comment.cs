using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap
{
    public class Comment
    {
        private int _CmtId;
        private string _NoiDung;
        private User _NguoiCmt;

        public int CmtId { get => _CmtId; set => _CmtId = value; }
        public string NoiDung { get => _NoiDung; set => _NoiDung = value; }
        public User NguoiCmt { get => _NguoiCmt; set => _NguoiCmt = value; }
    }
}
