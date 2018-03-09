using System;
using System.Collections.Generic;
using System.Text;

namespace Login
{
    class Account
    {
        public string AccountName { get; set; }

        public string Password { get; set; }
        
        public string EncryptedPassword
        {
            get
            {
                byte[] b = Encoding.UTF8.GetBytes(this.Password);
                Array.Reverse(b, 0, b.Length);
                return System.Convert.ToBase64String(b);
            }
            set
            {
                byte[] b = System.Convert.FromBase64String(value);
                Array.Reverse(b, 0, b.Length);
                this.Password = Encoding.UTF8.GetString(b);
            }
        }
    }
}
