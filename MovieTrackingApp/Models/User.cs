using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTrackingApp.UserInfo
{
    public class User
    {
        public int Id { get; set; }
        public string Username {  get; set; }
        public byte[] PasswordHash { get; set; }
        public string Email { get; set; }

    }
}
