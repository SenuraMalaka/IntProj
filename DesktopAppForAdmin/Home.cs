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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        Timer tmr;
        LoadingScreen ld = new LoadingScreen();

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            InfoMessages.setMessege("Logging out  ...");

            ld.Show();


            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 2000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_TickLogOut;




            //Login a = new Login();
            //a.Show();
            this.Hide();
        }



        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InfoMessages.setMessege("Loading user information...");
            
            ld.Show();
            

            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 1100;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_TickOpenAdminInfo;

        }

        void tmr_TickOpenAdminInfo(object sender, EventArgs e)

        {

            //after 1 sec stop the timer

            tmr.Stop();

            //display mainform

            UserDetails aa = new UserDetails();
            aa.StartPosition = FormStartPosition.Manual;
            aa.Location = new Point(this.Location.X + 240, this.Location.Y + 100);
            //this.Visible = false;
            aa.Show();

            //mf.Show();

            //hide this form
            ld.Hide();
            //this.Hide();


        }




        void tmr_TickLogOut(object sender, EventArgs e)

        {

            //after 2 sec stop the timer

            tmr.Stop();

            //display mainform

            Login aa = new Login();
            //this.Visible = false;
            aa.Show();

            //mf.Show();

            //hide this form
            ld.Hide();
            //this.Hide();


        }


        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        public static void setColorAdminSettingIconBlack(bool a)
        {
            //implementation

            if(a)
            pictureBox2.BackColor = Color.Black;
            else
                pictureBox2.BackColor = Color.White;

        }

    }
}
