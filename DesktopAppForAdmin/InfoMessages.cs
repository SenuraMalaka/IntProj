using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppForAdmin
{
    class InfoMessages
    {

        private static string msg = "null";

        public static void setMessege(String a)
        {
            msg = a;
        }

        public static string getMessege()
        {
            return msg;
        }

    }
}
