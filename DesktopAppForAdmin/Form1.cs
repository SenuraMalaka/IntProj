using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppForAdmin
{
    public partial class Login : Form
    {

        bool isUN = false;
        bool isPW = false;

        public Login()
        {
            InitializeComponent();

            pictureBoxLoginAnim.Parent = pictureBoxBack;
            pictureBoxLoginAnim.BackColor = Color.Transparent;

            pictureBoxUser.Parent = pictureBoxBack;
            pictureBoxUser.BackColor = Color.Transparent;

            pictureBoxKey.Parent = pictureBoxBack;
            pictureBoxKey.BackColor = Color.Transparent;

            textBoxUsername.Select();

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {

            if (textBoxPassword.Text != null || textBoxPassword.Text != "")
            {
                isPW = true;
                if (isUN == true)
                {
                    pictureBoxLoginAnim.Visible = true;
                }
                else
                {
                    pictureBoxLoginAnim.Visible = false;
                }
            }
            else
            {
                isPW = false;
                pictureBoxLoginAnim.Visible = false;
            }


        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != null || textBoxUsername.Text != "")
            {
                isUN = true;
                if (isPW == true)
                {
                    pictureBoxLoginAnim.Visible = true;
                }
                else
                {
                    pictureBoxLoginAnim.Visible = false;
                }
            }
            else
            {
                isUN = false;
                pictureBoxLoginAnim.Visible = false;
            }

        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername_Leave(sender,e);
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword_Leave(sender, e);
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        Timer tmr;
        LoadingScreen ld = new LoadingScreen();

        private void pictureBoxLoginAnim_Click(object sender, EventArgs e)
        {



            if (textBoxUsername.Text != "")

            {

                if (textBoxPassword.Text != "")
                {

                    ipEntities a = new ipEntities();



                    string sequenceMaxQuery = "Select s.username from staff s, Users u where s.Position like '%admin%' and u.password='" + textBoxPassword.Text + "' and s.username='" + textBoxUsername.Text + "'";

                    var sequenceQueryResult = a.Database.SqlQuery<string>(sequenceMaxQuery).FirstOrDefault();

                    string username = string.Empty;

                    if (sequenceQueryResult != null)
                    {
                        //username = sequenceQueryResult.ToString();
                        //if (username == textBoxUsername.Text)
                        //{


                        InfoMessages.setMessege("Logging in  ...");

                        ld.Show();


                        tmr = new Timer();

                        //set time interval 3 sec

                        tmr.Interval = 3000;

                        //starts the timer

                        tmr.Start();

                        tmr.Tick += tmr_TickLogOut;



                        LoggedInUser usr = new LoggedInUser();
                        usr.setUsername(textBoxUsername.Text);
                        
                        //Home b = new Home();
                        //b.Show();
                        this.Hide();
                        //}
                        //else
                        //{
                        //    //wrong 
                        //    MessageBox.Show("inner messege", "caption",
                        //                 MessageBoxButtons.OK,
                        //                 MessageBoxIcon.Question);
                        //}
                    }
                    else
                    {
                        //wrong
                        MessageBox.Show("Wrong Username or Password", "Try again..!",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Password box is empty...! Type the Password and continue.", "Type Password",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }

               



        

            }
          
        
            else

            {
                MessageBox.Show("Username box is empty...! Type the Username and continue.", "Type username",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
            
        }





        void tmr_TickLogOut(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            Home aa = new Home();
            //this.Visible = false;
            aa.Show();

            //mf.Show();

            //hide this form
            ld.Hide();
            //this.Hide();


        }




        //Encrypt
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }


    }
}
