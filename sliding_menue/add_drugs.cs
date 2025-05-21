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
    public partial class add_drugs : Form
    {
        CLS_CheckTxt isnum = new CLS_CheckTxt();
        clincEntities db = new clincEntities();
        drug model = new drug();
        public add_drugs()
        {
            InitializeComponent();
        }
        private static add_drugs instance;
        public static add_drugs getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_drugs();
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
            txtId.Text = txtName.Text = txtActive.Text = txtform.Text = txtQuan.Text=txtUnit.Text= "";
            comboClass.SelectedIndex = -1;
            btnDelete.Enabled = false;
            btnSave.Text = "SAVE";
        }
        void populateGrid()
        {
            gridDrug.AutoGenerateColumns = false;
            //var sd = db.drugs;
            //var dr = db.classifis;
            //gridDrug.DataSource = db.classifis.ToList();
            var drg = from d in db.drugs
                      join c in db.classifis
                      on d.FKclass_id equals c.id
                      select new
                      {
                          id = d.drug_id,
                          name = d.drug_name,
                          frm = d.form,
                          dq = d.default_quantity,
                          un = d.unit,
                          act = d.active,
                          cls = c.name
                      };
            gridDrug.DataSource = drg.ToList();

            //var s = db.drugs.
            //gridDrug.DataSource = db.drugs.ToList();
        }
        void fillcombo()
        {
            var drg = db.classifis;
            comboClass.ValueMember = "id";
            comboClass.DisplayMember = "name";
            comboClass.DataSource = drg.ToList();
        }
        void save()
        {
            model.FKclass_id =Convert.ToInt32( comboClass.SelectedValue);
            model.drug_name = txtName.Text.Trim();
            model.form = txtform.Text.Trim().Length < 1?null:txtform.Text;
            model.default_quantity = txtQuan.Text.Trim().Length < 1 ? null : txtQuan.Text;
            model.unit = txtUnit.Text.Trim().Length < 1 ? null : txtUnit.Text;
            model.active = txtActive.Text.Trim().Length < 1 ? null : txtActive.Text;

            db.drugs.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void SIGNTXTSE_OnTextChange(object sender, EventArgs e)
        {
            var drg = from d in db.drugs
                      join c in db.classifis
                      on d.FKclass_id equals c.id
                      where d.drug_name.Contains(txtSearch.text)
                      select new
                      {
                          id = d.drug_id,
                          name = d.drug_name,
                          frm = d.form,
                          dq = d.default_quantity,
                          un = d.unit,
                          act = d.active,
                          cls = c.name
                      };
            gridDrug.DataSource = drg.ToList();
            //gridDrug.DataSource = db.drugs.Where(x => x.drug_name.Contains(txtSearch.text)).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(comboClass.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Enter All Needed Fields!");
            else if (string.IsNullOrEmpty(txtId.Text))
            {
                var dr = txtName.Text;
                var drg = db.drugs.FirstOrDefault(i => i.drug_name == dr);
                if (drg != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Drug Already Exisit Are You Want To Update This Drug?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        drg.FKclass_id = Convert.ToInt32(comboClass.SelectedValue);
                        drg.drug_name = txtName.Text.Trim();
                        drg.form = txtform.Text.Trim().Length < 1 ? null : txtform.Text;
                        drg.default_quantity = txtQuan.Text.Trim().Length < 1 ? null : txtQuan.Text;
                        drg.unit = txtUnit.Text.Trim().Length < 1 ? null : txtUnit.Text;
                        drg.active = txtActive.Text.Trim().Length < 1 ? null : txtActive.Text;
                        db.Entry(drg).State = EntityState.Modified;
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
                var drg = db.drugs.FirstOrDefault(i => i.drug_id == s);
                if (drg != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This drug?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        drg.FKclass_id = Convert.ToInt32(comboClass.SelectedValue);
                        drg.drug_name = txtName.Text.Trim();
                        drg.form = txtform.Text.Trim().Length < 1 ? null : txtform.Text;
                        drg.default_quantity = txtQuan.Text.Trim().Length < 1 ? null : txtQuan.Text;
                        drg.unit = txtUnit.Text.Trim().Length < 1 ? null : txtUnit.Text;
                        drg.active = txtActive.Text.Trim().Length < 1 ? null : txtActive.Text;
                        db.Entry(drg).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = gridDrug.CurrentRow.Cells[1].Value;
            var drg = db.drugs.FirstOrDefault(i => i.drug_name == dr.ToString());
            if (drg != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This drug ?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.drugs.Remove(drg);
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

        private void txtQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isnum.isNumber(e.KeyChar, txtQuan.Text))
            {
                e.Handled = true;

            } 
        }

        private void gridDrug_DoubleClick(object sender, EventArgs e)
        {
            if (gridDrug.CurrentRow.Index != -1)
            {
                var id = Convert.ToInt32(gridDrug.CurrentRow.Cells[0].Value);
                var drg = db.drugs.FirstOrDefault(sr => sr.drug_id == id);
                var fk = db.classifis.FirstOrDefault(x => x.id == drg.FKclass_id);
                comboClass.Text = fk.name;
                txtId.Text = drg.drug_id.ToString();
                txtName.Text = drg.drug_name;
                txtform.Text = drg.form;
                txtQuan.Text = drg.default_quantity;
                txtUnit.Text = drg.unit;
                txtActive.Text = drg.active;

                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }

        private void Add_drugs_Load(object sender, EventArgs e)
        {
            fillcombo();
            populateGrid();
            clear();
        }



    }
}
