using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CMP307_TayMark_App
{
    public class gvars
    {
        private static int Userid;

        public static int Userid1 { get => Userid; set => Userid = value; }

        private static int Admin;

        public static int Admin1 { get => Admin; set => Admin = value; }

        public static String PasswordHashed(String Var)
        {
            SHA1 var2 = SHA1.Create();
            byte[] tohash = var2.ComputeHash(Encoding.Default.GetBytes(Var));

            StringBuilder vartoreturn = new StringBuilder();

            for (int i = 0; i < tohash.Length; i++)
            {
                vartoreturn.Append(tohash[i].ToString());
            }
            return vartoreturn.ToString();

        }
    }
}
