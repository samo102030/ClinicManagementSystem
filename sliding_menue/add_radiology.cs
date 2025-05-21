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
    public partial class add_radiology : Form
    {
        clincEntities db = new clincEntities();
        radiology model = new radiology();
        public add_radiology()
        {
            InitializeComponent();
        }

        private static add_radiology instance;
        public static add_radiology getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_radiology();
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

        private void add_radiology_Load(object sender, EventArgs e)
        {
            clear();
            populateGrid();
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
            gridrad.AutoGenerateColumns = false;
            var rad = db.radiologies;
            gridrad.DataSource = rad.ToList();
        }
        void save()
        {
            model.radio_name = txtName.Text.Trim();
            db.radiologies.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            gridrad.AutoGenerateColumns = false;
            gridrad.DataSource = db.radiologies.Where(x => x.radio_name.Contains(txtSearch.text)).ToList();
        }

        private void gridrad_DoubleClick(object sender, EventArgs e)
        {
            if (gridrad.CurrentRow.Index != -1)
            {
                var s = Convert.ToInt32(gridrad.CurrentRow.Cells[0].Value);
                var rad = db.radiologies.FirstOrDefault(i => i.radiology_id == s);
                txtId.Text = rad.radiology_id.ToString();
                txtName.Text = rad.radio_name;
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
                var rad = db.radiologies.FirstOrDefault(i => i.radio_name == cl);
                if (rad != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Radiology Already Exisit Are You Want To Update This Class Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        rad.radio_name = txtName.Text.Trim();
                        db.Entry(rad).State = EntityState.Modified;
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
                var rad = db.radiologies.FirstOrDefault(i => i.radiology_id == cl);
                if (rad != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Radiology Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        rad.radio_name = txtName.Text.Trim();
                        db.Entry(rad).State = EntityState.Modified;
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
                var rad = db.radiologies.FirstOrDefault(x => x.radiology_id == s);
                if (rad != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Delete This Radiology ? It Will delete all Related Data!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        db.radiologies.Remove(rad);
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
