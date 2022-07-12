using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Class1
    {
        public static bool logare(string user, string pass)

        {
            if(user.Equals("admin")&& pass.Equals("admin"))
                return true;
            return false;
        }
    }
}
