using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace sliding_menue
{
    public partial class Login : Form
    {
        clincEntities db = new clincEntities();
        user model = new user();
        private static Login frm;

    
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Login getloginform
        {
            get
            {
                if (frm == null)
                {
                    frm = new Login();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public Login()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var user = db.users.FirstOrDefault(x => x.user_name == txtUserName.Text);
            if (user != null)
            {
                if (user.user_pw == txtUserPwd.Text)
                {
                    Program.staff = user.FullName; 
                    //MessageBox.Show("Login Succeded");
                    Thread thr = new Thread(startNew);
                    thr.SetApartmentState(ApartmentState.STA);
                    thr.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                    txtUserPwd.Focus();
                }
            }
            else
            {
                MessageBox.Show("No User Called " + txtUserName.Text);
                txtUserName.Focus();              
            }
        }

        static void startNew()
        {
            Application.Run(new main());
        }

       
        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(user_controls.Register.getinstance))
            {
                panel1.Controls.Add(user_controls.Register.getinstance);
                user_controls.Register.getinstance.Dock = DockStyle.Fill;
                panel2.Visible = false;
                this.Size = new System.Drawing.Size(575, 501);
            }
        }

        private void chkPwdch()
        {
            if (chkShpwd.Checked)
            {
                txtUserPwd.isPassword = false;
            }
            else if (!chkShpwd.Checked)
            {
                txtUserPwd.isPassword = true;

            }
        }
        private void txtUserPwd_OnValueChanged(object sender, EventArgs e)
        {
            chkPwdch();
        }

        private void chkShpwd_CheckedChanged(object sender, EventArgs e)
        {
            chkPwdch();
        }

     
    }
}
