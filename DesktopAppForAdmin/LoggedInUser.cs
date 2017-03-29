using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppForAdmin
{
    class LoggedInUser
    {
        private static string username = "";
        private static string sfname = "";
        private static string slname = "";
        private static string semail = "";


        public void setUsername(string name)
        {
            username = name;


            ipEntities a = new ipEntities();



            string getfname = "Select fname from Users where username='" + name + "'";
            string getlname = "Select lname from Users where username='" + name + "'";
            string getemail = "Select email from Users where username='" + name + "'";

            var fname = a.Database.SqlQuery<string>(getfname).FirstOrDefault();
            var lname = a.Database.SqlQuery<string>(getlname).FirstOrDefault();
            var email = a.Database.SqlQuery<string>(getemail).FirstOrDefault();


            //string abc = string.Empty;

            if (fname != null && lname != null && email != null)
            {
                sfname = fname.ToString();
                slname = lname.ToString();
                semail = email.ToString();
            }



         }

        public string getUsername()
        {
            return username;

        }

        public string getfname()
        {
            return sfname;

        }

        public string getlname()
        {
            return slname;

        }

        public string getemail()
        {
            return semail;

        }



    }
}
