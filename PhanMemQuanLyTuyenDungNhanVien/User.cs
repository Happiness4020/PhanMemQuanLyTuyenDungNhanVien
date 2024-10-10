using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyTuyenDungNhanVien
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }    
        public string email { get; set; }
        public string fullname { get; set; }
    }
}
