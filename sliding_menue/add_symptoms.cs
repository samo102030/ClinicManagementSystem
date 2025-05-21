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
    public partial class add_symp : Form
    {
        clincEntities db = new clincEntities();
        symptom model = new symptom();
        public add_symp()
        {
            InitializeComponent();
        }

        private static add_symp instance;
        public static add_symp getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_symp();
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
            txtId.Text = txtName.Text =txtSearch.text= "";
            comboSys.SelectedIndex = -1;
            btnDelete.Enabled = false;
            btnSave.Text = "SAVE";
        }
        void populateGrid()
        {
            gridSymp.AutoGenerateColumns = false;
            var sin = from d in db.symptoms
                      join c in db.systs
                      on d.sys_id equals c.id
                      select new
                      {
                          id = d.sympt_id,
                          name = d.symptom_name,
                          sy = c.name
                      };
            gridSymp.DataSource = sin.ToList();

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
            model.symptom_name = txtName.Text.Trim();


            db.symptoms.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void add_symp_Load(object sender, EventArgs e)
        {
            fillcombo();
            populateGrid();
            clear();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            var sin = from d in db.symptoms
                      join c in db.systs
                      on d.sys_id equals c.id
                      where d.symptom_name.Contains(txtSearch.text)
                      select new
                      {
                          id = d.sympt_id,
                          name = d.symptom_name,
                          sy = c.name
                      };
            gridSymp.DataSource = sin.ToList();
        }

        private void gridSymp_DoubleClick(object sender, EventArgs e)
        {
            if (gridSymp.CurrentRow.Index != -1)
            {
                var id = Convert.ToInt32(gridSymp.CurrentRow.Cells[0].Value);
                var drg = db.symptoms.FirstOrDefault(sr => sr.sympt_id == id);
                var fk = db.systs.FirstOrDefault(x => x.id == drg.sys_id);
                comboSys.Text = fk.name;
                txtId.Text = drg.sympt_id.ToString();
                txtName.Text = drg.symptom_name;

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
                var symp = db.symptoms.FirstOrDefault(i => i.symptom_name == dr);
                if (symp != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Symptom Already Exisit Are You Want To Update This Disease?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        symp.sys_id = Convert.ToInt32(comboSys.SelectedValue);
                        symp.symptom_name = txtName.Text.Trim();
                        db.Entry(symp).State = EntityState.Modified;
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
                var symp = db.symptoms.FirstOrDefault(i => i.sympt_id == s);
                if (symp != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Symptom?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        symp.sys_id = Convert.ToInt32(comboSys.SelectedValue);
                        symp.symptom_name = txtName.Text.Trim();
                        db.Entry(symp).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = gridSymp.CurrentRow.Cells[1].Value;
            var symp = db.symptoms.FirstOrDefault(i => i.symptom_name == dr.ToString());
            if (symp != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This Symptom ?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.symptoms.Remove(symp);
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
