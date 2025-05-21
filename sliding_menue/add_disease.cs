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
    public partial class add_disease : Form
    {
        //CLS_MinMaxWindow mini = new CLS_MinMaxWindow();
        clincEntities db = new clincEntities();
        disease model = new disease();
        public add_disease()
        {
            InitializeComponent();
        }

        private void add_disease_Load(object sender, EventArgs e)
        {
            fillcombo();
            populateGrid();
            clear();
        }

        void clear()
        {
            txtId.Text = txtName.Text =  "";
            comboSys.SelectedIndex = -1;
            btnDelete.Enabled = false;
            btnSave.Text = "SAVE";
        }
        void populateGrid()
        {
            gridDiese.AutoGenerateColumns = false; 
            var drg = from d in db.diseases
                      join c in db.systs
                      on d.fksys_id equals c.id
                      select new
                      {
                          id = d.diseaseId,
                          name = d.disease_name,
                          sy = c.name
                      };
            gridDiese.DataSource = drg.ToList();
  
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
            model.fksys_id = Convert.ToInt32(comboSys.SelectedValue);
            model.disease_name = txtName.Text.Trim();


            db.diseases.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            var search = from d in db.diseases
                                   join c in db.systs
                                   on d.fksys_id equals c.id
                                   where d.disease_name.Contains(txtSearch.text)
                                  select new
                                  {
                                      id = d.diseaseId,
                                      name = d.disease_name,
                                      sy = c.name
                                  };
            gridDiese.DataSource = search.ToList();
        }

        private void gridDiese_DoubleClick(object sender, EventArgs e)
        {
            if (gridDiese.CurrentRow.Index != -1)
            {
                var id = Convert.ToInt32(gridDiese.CurrentRow.Cells[0].Value);
                var drg = db.diseases.FirstOrDefault(sr => sr.diseaseId == id);
                var fk = db.systs.FirstOrDefault(x => x.id == drg.fksys_id);
                comboSys.Text = fk.name;
                txtId.Text = drg.diseaseId.ToString();
                txtName.Text = drg.disease_name;

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
                var dis = db.diseases.FirstOrDefault(i => i.disease_name == dr);
                if (dis != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Disease Already Exisit Are You Want To Update This Disease?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dis.fksys_id = Convert.ToInt32(comboSys.SelectedValue);
                        dis.disease_name = txtName.Text.Trim();
                        db.Entry(dis).State = EntityState.Modified;
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
                var dis = db.diseases.FirstOrDefault(i => i.diseaseId == s);
                if (dis != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Disease?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dis.fksys_id = Convert.ToInt32(comboSys.SelectedValue);
                        dis.disease_name = txtName.Text.Trim();
                        db.Entry(dis).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr =Convert.ToInt32( txtId.Text);
            var dis = db.diseases.FirstOrDefault(i => i.diseaseId == dr);
            if (dis != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This Disease ?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.diseases.Remove(dis);
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
