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
    public partial class add_system : Form
    {
        clincEntities db = new clincEntities();
        syst model = new syst();
        public add_system()
        {
            InitializeComponent();
        }

        private static add_system instance;
        public static add_system getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_system();
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
            txtName.Text = txtId.Text = txtSearch.text= "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();
        }
        void populateGrid()
        {
            gridSys.AutoGenerateColumns = false;
            var sy = db.systs;
            gridSys.DataSource = sy.ToList();
        }
        void save()
        {
            model.name = txtName.Text.Trim();
            db.systs.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void add_system_Load(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }

        private void gridSys_DoubleClick(object sender, EventArgs e)
        {
            if (gridSys.CurrentRow.Index != -1)
            {
                var s = Convert.ToInt32(gridSys.CurrentRow.Cells[0].Value);
                var sy = db.systs.FirstOrDefault(i => i.id == s);
                txtId.Text = sy.id.ToString();
                txtName.Text = sy.name;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtName.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Insert System Name");
            else if (!string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtId.Text))
            {
                var cl = txtName.Text;
                var sy = db.systs.FirstOrDefault(i => i.name == cl);
                if (sy != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "System Already Exisit Are You Want To Update This Class Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sy.name = txtName.Text.Trim();
                        db.Entry(sy).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }
                else save();
            }
            else if (!string.IsNullOrEmpty(txtId.Text))
            {
                var cl = Convert.ToInt32(txtId.Text);
                var sy = db.systs.FirstOrDefault(i => i.id == cl);
                if (sy != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This System?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sy.name = txtName.Text.Trim();
                        db.Entry(sy).State = EntityState.Modified;
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
                var s = Convert.ToInt32(txtId.Text);
                var sy = db.systs.FirstOrDefault(x => x.id == s);
                if (sy != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Delete This System ? It Will delete all Related Data!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        db.systs.Remove(sy);
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

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
             gridSys.DataSource = db.systs.Where(x => x.name.Contains(txtSearch.text)).ToList();
        }
    }
}
