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
    public partial class add_signs : Form
    {
        clincEntities db = new clincEntities();
        sign model = new sign();
        public add_signs()
        {
            InitializeComponent();
        }

        private static add_signs instance;
        public static add_signs getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_signs();
            else instance.BringToFront();
            return instance;

        }

        private void minimized_Click(object sender, EventArgs e)
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            txtId.Text = txtName.Text = txtSearch.text = "";
            comboSys.SelectedIndex = -1;
            btnDelete.Enabled = false;
            btnSave.Text = "SAVE";
        }
        void populateGrid()
        {
            gridSigns.AutoGenerateColumns = false;
            var sin = from d in db.signs
                      join c in db.systs
                      on d.sys_id equals c.id
                      select new
                      {
                          id = d.sign_id,
                          name = d.sign_name,
                          sy = c.name
                      };
            gridSigns.DataSource = sin.ToList();

        }
        void fillcombo()
        {
            var drg = db.systs;
            comboSys.ValueMember = "id";
            comboSys.DisplayMember = "name";
            comboSys.DataSource = drg.ToList();
        }
        void save()
        {
            model.sys_id = Convert.ToInt32(comboSys.SelectedValue);
            model.sign_name = txtName.Text.Trim();


            db.signs.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void add_signs_Load(object sender, EventArgs e)
        {
            fillcombo();
            populateGrid();
            clear();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            var sin = from d in db.signs
                      join c in db.systs
                      on d.sys_id equals c.id
                      where d.sign_name.Contains(txtSearch.text)
                      select new
                      {
                          id = d.sign_id,
                          name = d.sign_name,
                          sy = c.name
                      };
            gridSigns.DataSource = sin.ToList();
        }

        private void gridSigns_DoubleClick(object sender, EventArgs e)
        {
            if (gridSigns.CurrentRow.Index != -1)
            {
                var id = Convert.ToInt32(gridSigns.CurrentRow.Cells[0].Value);
                var drg = db.signs.FirstOrDefault(sr => sr.sign_id == id);
                var fk = db.systs.FirstOrDefault(x => x.id == drg.sys_id);
                comboSys.Text = fk.name;
                txtId.Text = drg.sign_id.ToString();
                txtName.Text = drg.sign_name;

                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(comboSys.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Enter All Needed Fields!");
            else if (string.IsNullOrEmpty(txtId.Text))
            {
                var dr = txtName.Text;
                var sin = db.signs.FirstOrDefault(i => i.sign_name == dr);
                if (sin != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Sign Already Exisit Are You Want To Update This Disease?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sin.sys_id = Convert.ToInt32(comboSys.SelectedValue);
                        sin.sign_name = txtName.Text.Trim();
                        db.Entry(sin).State = EntityState.Modified;
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
                var sin = db.signs.FirstOrDefault(i => i.sign_id == s);
                if (sin != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This sign?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        sin.sys_id = Convert.ToInt32(comboSys.SelectedValue);
                        sin.sign_name = txtName.Text.Trim();
                        db.Entry(sin).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = gridSigns.CurrentRow.Cells[1].Value;
            var sin = db.signs.FirstOrDefault(i => i.sign_name == dr.ToString());
            if (sin != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This sign ?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.signs.Remove(sin);
                    db.SaveChanges();
                    clear();
                    populateGrid();
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
