using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopAppForAdmin
{
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();

            LoggedInUser usr = new LoggedInUser();

            Home.setColorAdminSettingIconBlack(true);

            labelUsername.Text = usr.getUsername();
            labelLname.Text = usr.getlname();
            labelFname.Text = usr.getfname();
            labelEmail.Text = usr.getemail();

            if(int.Parse(labelEmail.Text.Length.ToString()) >16)
            {
                labelEmail.Font = new Font("Microsoft Sans Serif", 10);
            }


        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {


            Home.setColorAdminSettingIconBlack(false);
            this.Hide();

            
        }
    }
}
