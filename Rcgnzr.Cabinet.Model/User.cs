using System;
using System.Security.Cryptography;
using System.Text;

namespace Rcgnzr.Cabinet.Model
{
    public class User
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public string PasswordHash { get; set; }

        public bool PasswordCorrect(string password)
        {
            return PasswordHash == Hash(password);
        }
        
        private static string Hash(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(md5data);
        }
    }
}