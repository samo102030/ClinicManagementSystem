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
    public partial class add_sergical : Form
    {
        clincEntities db = new clincEntities();
        sergical model = new sergical();
        public add_sergical()
        {
            InitializeComponent();
        }

        private void btnMini_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            txtName.Text = txtId.Text = txtSearch.text = "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();
        }
        void populateGrid()
        {
            gridserg.AutoGenerateColumns = false;
            var sy = db.sergicals;
            gridserg.DataSource = sy.ToList();
        }
        void save()
        {
            model.sergicalName = txtName.Text.Trim();
            db.sergicals.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void add_sergical_Load(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            gridserg.DataSource = db.sergicals.Where(x => x.sergicalName.Contains(txtSearch.text)).ToList();
        }

        private void gridserg_DoubleClick(object sender, EventArgs e)
        {
            if (gridserg.CurrentRow.Index != -1)
            {
                var s = Convert.ToInt32(gridserg.CurrentRow.Cells[0].Value);
                var sy = db.sergicals.FirstOrDefault(i => i.serg_id == s);
                txtId.Text = sy.serg_id.ToString();
                txtName.Text = sy.sergicalName;
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
                var sy = db.sergicals.FirstOrDefault(i => i.sergicalName == cl);
                if (sy != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Sergical Already Exisit Are You Want To Update This Class Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sy.sergicalName = txtName.Text.Trim();
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
                var sy = db.sergicals.FirstOrDefault(i => i.serg_id == cl);
                if (sy != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Sergical Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sy.sergicalName = txtName.Text.Trim();
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
                var sy = db.sergicals.FirstOrDefault(x => x.serg_id == s);
                if (sy != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Delete This Sergical ? It Will delete all Related Data!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        db.sergicals.Remove(sy);
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
