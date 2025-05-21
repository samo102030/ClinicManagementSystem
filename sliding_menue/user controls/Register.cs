using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace sliding_menue.user_controls
{
    public partial class Register : UserControl
    {
        clincEntities db = new clincEntities();
        private static user_controls.Register instance;
        public static user_controls.Register getinstance
        {
            get
            {
                if (instance == null)
                
                    instance = new user_controls.Register();
                    return instance;
            }
        }

        public Register()
        {
            InitializeComponent();
        }
 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login.getloginform.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.getloginform.panel1.Controls.Remove(user_controls.Register.getinstance);
            Login.getloginform.Size = new System.Drawing.Size(970, 501);
            Login.getloginform.panel2.Visible = true;
        }

        void fillcombo()
        {
            //var quest = db.Questions;
            //comboQuest.DisplayMember = "QuestName";
            //comboQuest.DataSource = quest.ToList();
            comboQuest.SelectedIndex = -1;
        }

        public void findUser()
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var id = Convert.ToInt32(txtId.Text);
                var user = db.users.FirstOrDefault(x => x.id == id);
                if (user != null)
                {
                    user.user_pw = txtPw.Text;
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    clear();
                }
            }
            else if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtName.Text))
            {
                var xx = txtUserName.Text;
                var y = txtName.Text;
                var user = db.users.FirstOrDefault(x => x.user_name == xx && x.FullName == y);
                if (user != null)
                {
                    if (user.secret_Quest == comboQuest.Text && user.answer == txtAnswer.Text)
                    {
                        txtPw.Enabled = true;
                        txtPwConf.Enabled = true;
                        user.user_pw = txtPw.Text;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                    }
                }
            }
        }

        void clear()
        {
            txtId.Text = txtUserName.Text = txtName.Text = txtAnswer.Text = txtPw.Text = txtPwConf.Text = "";
            comboQuest.SelectedIndex = -1;
            txtPw.Enabled = false;
            txtPwConf.Enabled = false;
            btnSave.Enabled = false;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                var id = Convert.ToInt32(txtId.Text);
                var user = db.users.FirstOrDefault(x => x.id == id);
                if (user != null)
                {
                    if (user.secret_Quest == comboQuest.Text && user.answer == txtAnswer.Text)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Correct Answer, Insert New Password!");
                        txtPw.Enabled = true;
                        txtPwConf.Enabled = true;
                        btnSave.Enabled = true;
                        txtPw.Focus();
                    }
                    else MetroFramework.MetroMessageBox.Show(this, "Wrong Question Or Answer Try Again !");
                }
                else MetroFramework.MetroMessageBox.Show(this, "no user founded!");
            }
            else if (!string.IsNullOrEmpty(comboQuest.Text) && !string.IsNullOrEmpty(txtAnswer.Text))
            {
                var xx = txtUserName.Text;
                var y = txtName.Text;
                var user = db.users.FirstOrDefault(x => x.user_name == xx && x.FullName == y);
                if (user != null)
                {
                    if (user.secret_Quest == comboQuest.Text && user.answer == txtAnswer.Text)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Correct Answer, Insert New Password!");
                        txtPw.Enabled = true;
                        txtPwConf.Enabled = true;
                        btnSave.Enabled = true;
                        txtPw.Focus();
                    }
                    else MetroFramework.MetroMessageBox.Show(this, "Wrong Question Or Answer Try Again !");
                }
                else MetroFramework.MetroMessageBox.Show(this, "no user founded!");

            }
            else
            {
                MessageBox.Show("pleaser insert ID Or ( User Name And Password )!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPw.Text))
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Ther Is No Password Inserted! .. Are You Sure You Want To Save Empty Password ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    findUser();
                    MetroFramework.MetroMessageBox.Show(this, "Password Saved Empty Successfully , This User Hasn't Password");
                }
                txtPw.Focus();
            }
            else
            {
                if (txtPwConf.Text != txtPw.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password Not Matched");
                    txtPwConf.Focus();
                    txtPwConf.SelectAll();
                }
                else
                {
                    findUser();
                    MetroFramework.MetroMessageBox.Show(this, "Password Saved Successfully");
                }
            }
        }


    }
}
