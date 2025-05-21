using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sliding_menue
{
    public partial class add_stuff : Form
    {
        clincEntities db = new clincEntities();
        user model = new user();
        public add_stuff()
        {
            InitializeComponent();
        }

        private static add_stuff instance;
        public static add_stuff getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_stuff();
            else instance.BringToFront();
            return instance;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        void clear()
        {
            txtId.Text = txtName.Text = txtUserName.Text = txtPw.Text = txtPwConf.Text = txtAnswer.Text = "";
            comboQuest.SelectedIndex = comboRole.SelectedIndex = -1;
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();

        }

        void populateGridView()
        {
            gridUsers.AutoGenerateColumns = false;
            var user = db.users;
            gridUsers.DataSource = user.ToList();
        }

        void save()
        {
            model.user_name = txtUserName.Text.Trim();
            model.user_pw = txtPw.Text.Trim();/*.Length < 1 ? null : txtPw.Text;*/
            model.FullName = txtName.Text.Trim().Length < 1 ? null : txtName.Text;
            model.user_role = int.Parse(comboRole.Text); /*< 1 ?  0:int.Parse(comboRole.Text);*/
            model.secret_Quest = comboQuest.Text.Trim().Length < 1 ? null : comboQuest.Text;
            model.answer = txtAnswer.Text.Trim().Length < 1 ? null : txtAnswer.Text;
            db.users.Add(model);
            db.SaveChanges();
            clear();
            populateGridView();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void add_stuff_Load(object sender, EventArgs e)
        {
            clear();
            populateGridView();
        }

        private void gridUsers_DoubleClick(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow.Index != -1)
            {
                var u = Convert.ToInt32(gridUsers.CurrentRow.Cells[0].Value);
                var user = db.users.FirstOrDefault(i => i.id == u);
                txtId.Text = user.id.ToString();
                txtUserName.Text = user.user_name;
                txtPw.Text = user.user_pw;
                txtName.Text = user.FullName;
                comboRole.Text = user.user_role.ToString();
                comboQuest.Text = user.secret_Quest;
                txtAnswer.Text = user.answer;
                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(comboRole.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Enter All Needed Fields!");
            else if (txtPwConf.Text != txtPw.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password Not Matched");
                txtPwConf.Focus();
                txtPwConf.SelectAll();
            }
            else if (string.IsNullOrEmpty(txtId.Text))
            {
                var u = txtName.Text;
                var user = db.users.FirstOrDefault(i => i.user_name == u);
                if (user != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "User Already Exisit Are You Want To Update This User?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        user.user_name = txtUserName.Text.Trim();
                        user.user_pw = txtPw.Text.Trim().Length < 1 ? null : txtPw.Text;
                        user.FullName = txtName.Text.Trim().Length < 1 ? null : txtName.Text;
                        user.user_role = int.Parse(comboRole.Text);/* >= 1 ? comboRole.Text : null;*/
                        user.secret_Quest = comboQuest.Text.Trim().Length < 1 ? null : comboQuest.Text;
                        user.answer = txtAnswer.Text.Trim().Length < 1 ? null : txtAnswer.Text;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGridView();
                    }
                }
                else save();
            }
            else if (!string.IsNullOrEmpty(txtId.Text))
            {
                var u = Convert.ToInt32(txtId.Text);
                var user = db.users.FirstOrDefault(i => i.id == u);
                if (user != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This User Details?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        user.user_name = txtUserName.Text.Trim();
                        user.user_pw = txtPw.Text.Trim().Length < 1 ? null : txtPw.Text;
                        user.FullName = txtName.Text.Trim().Length < 1 ? null : txtName.Text;
                        user.user_role = int.Parse(comboRole.Text);/*.Trim().Length < 1 ? null : comboRole.Text;*/
                        user.secret_Quest = comboQuest.Text.Trim().Length < 1 ? null : comboQuest.Text;
                        user.answer = txtAnswer.Text.Trim().Length < 1 ? null : txtAnswer.Text;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGridView();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var u = gridUsers.CurrentRow.Cells[1].Value;
            var user = db.users.FirstOrDefault(predicate: x => x.user_name == u.ToString());
            if (user != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This Customer ?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.users.Remove(user);
                    db.SaveChanges();
                    clear();
                    populateGridView();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            populateGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
