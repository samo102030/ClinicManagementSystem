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
    public partial class add_classes : Form
    {
        clincEntities db = new clincEntities();
        classifi model = new classifi();
        public add_classes()
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
            txtName.Text = txtId.Text = "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        void populateGrid()
        {
            gridSys.AutoGenerateColumns = false;
            var cls = db.classifis;
            gridSys.DataSource = cls.ToList();
        }

        void save()
        {
            model.name = txtName.Text.Trim();
            db.classifis.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtName.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Insert Class Name");
            else if (!string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtId.Text))
            {
                var cl = txtName.Text;
                var cls = db.classifis.FirstOrDefault(i => i.name == cl);
                if (cls != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Class Already Exisit Are You Want To Update This Class Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls.name = txtName.Text.Trim();
                        db.Entry(cls).State = EntityState.Modified;
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
                var cls = db.classifis.FirstOrDefault(i => i.id == cl);
                if (cls != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Class Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls.name = txtName.Text.Trim();
                        db.Entry(cls).State = EntityState.Modified;
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
                var cl = Convert.ToInt32(txtId.Text);
                var cls = db.classifis.FirstOrDefault(x => x.id == cl);
                if (cls != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Delete This Class It Will delete Permanently", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        db.classifis.Remove(cls);
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

        private void gridSys_DoubleClick(object sender, EventArgs e)
        {
            if (gridSys.CurrentRow.Index != -1)
            {
                var s = Convert.ToInt32(gridSys.CurrentRow.Cells[0].Value);
                var occ = db.classifis.FirstOrDefault(i => i.id == s);
                txtId.Text = occ.id.ToString();
                txtName.Text = occ.name;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void add_classes_Load(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            gridSys.DataSource = db.classifis.Where(x => x.name.Contains(txtSearch.text)).ToList();
        }

    }
}
