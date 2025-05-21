using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sliding_menue.BLL;

namespace sliding_menue
{
    public partial class add_lab_test : Form
    {
        CLS_CheckTxt chk = new CLS_CheckTxt();
        clincEntities db = new clincEntities();
        lab_tests model = new lab_tests();
        public add_lab_test()
        {
            InitializeComponent();
        }
        private static add_lab_test instance;
        public static add_lab_test getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_lab_test();
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clear()
        {
            txtName.Text = txtId.Text =txtMini.Text=txtMax.Text=txtUnit.Text= txtSearch.text = "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();
        }
        void populateGrid()
        {
            gridTest.AutoGenerateColumns = false;
            var sy = db.lab_tests;
            gridTest.DataSource = sy.ToList();
        }
        void save()
        {
            model.test_name = txtName.Text.Trim();
            model.mini = Convert.ToDecimal(txtMini.Text.Trim());
            model.maxi = Convert.ToDecimal(txtMax.Text.Trim());
            model.unit = txtUnit.Text.Trim();
            db.lab_tests.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }
        private void add_lab_test_Load(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            gridTest.AutoGenerateColumns = false;
            gridTest.DataSource = db.lab_tests.Where(x => x.test_name.Contains(txtSearch.text)).ToList();
        }

        private void gridTest_DoubleClick(object sender, EventArgs e)
        {
            if (gridTest.CurrentRow.Index != -1)
            {
                var s = Convert.ToInt32(gridTest.CurrentRow.Cells[0].Value);
                var ts = db.lab_tests.FirstOrDefault(i => i.test_id == s);
                txtId.Text = ts.test_id.ToString();
                txtName.Text = ts.test_name;
                txtMini.Text = ts.mini.ToString();
                txtMax.Text = ts.maxi.ToString();
                txtUnit.Text = ts.unit;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void txtMini_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!chk.isDecimal(e.KeyChar, txtMini.Text))
                e.Handled = true;
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!chk.isDecimal(e.KeyChar, txtMax.Text))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMini.Text) || string.IsNullOrEmpty(txtMax.Text) || string.IsNullOrEmpty(txtUnit.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Enter All Needed Fields!");
            else if (string.IsNullOrEmpty(txtId.Text))
            {
                var s = txtName.Text;
                var tst = db.lab_tests.FirstOrDefault(i => i.test_name == s);
                if (tst != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Test Already Exisit Are You Want To Update This Service Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tst.test_name = txtName.Text.Trim();
                        tst.mini = Convert.ToDecimal(txtMini.Text.Trim());
                        tst.maxi = Convert.ToDecimal(txtMax.Text.Trim());
                        tst.unit = txtUnit.Text.Trim();
                        db.Entry(tst).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }
                else save();
            }
            else if (!string.IsNullOrEmpty(txtId.Text))
            {
                var s = Convert.ToInt32(txtId.Text);
                var tst = db.lab_tests.FirstOrDefault(i => i.test_id == s);
                if (tst != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Test?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tst.test_name = txtName.Text.Trim();
                        tst.mini = Convert.ToDecimal(txtMini.Text.Trim());
                        tst.maxi = Convert.ToDecimal(txtMax.Text.Trim());
                        tst.unit = txtUnit.Text.Trim();
                        db.Entry(tst).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "there no Record To delete");
            }

            else
            {
                var sa = Convert.ToInt32(txtId.Text);
                var test = db.lab_tests.FirstOrDefault(x => x.test_id == sa);
                if (test != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This Test ?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        db.lab_tests.Remove(test);
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }
    }
}
