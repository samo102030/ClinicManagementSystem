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
    public partial class add_patient : Form
    {
        clincEntities db = new clincEntities();
        patient model = new patient();
        vist visit = new vist();
        public add_patient()
        {
            InitializeComponent();
        }
        private static add_patient instance;
        public static add_patient getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_patient();
            else instance.BringToFront();
            return instance;

        }


        void clear()
        {
            dob.Value = DateTime.Now;
            txtId.Text = txtName.Text = txtage.Text = txtSearch.Text = txtaddress.Text = txtjob.Text =txtmob.Text=txtNotes.Text= "";
            comboBlood.SelectedIndex = comboGender.SelectedIndex = comboStates.SelectedIndex = -1;
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        void populateGridView()
        {
            gridPt.AutoGenerateColumns = false;
            var pt = db.patients;
            gridPt.DataSource = pt.ToList();
        }

        void save()
        {
            model.pt_name = txtName.Text.Trim();
            model.dob = dob.Value;
            model.job = txtjob.Text.Trim().Length < 1 ? null : txtjob.Text;
            model.gender = comboGender.Text.Trim().Length < 1 ? null : comboGender.Text;
            model.marital_status = comboStates.Text.Trim().Length < 1 ? null : comboStates.Text;
            model.address = txtaddress.Text.Trim().Length < 1 ? null : txtaddress.Text;
            model.blood_type = comboBlood.Text.Trim().Length < 1 ? null : comboBlood.Text;
            model.mobile = txtmob.Text.Trim().Length < 1 ? null : txtmob.Text;
            model.notes = txtNotes.Text.Trim().Length < 1 ? null : txtNotes.Text;
            db.patients.Add(model);
            db.SaveChanges();
            clear();
            populateGridView();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void add_patient_Load(object sender, EventArgs e)
        {
            clear();
            populateGridView();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dob_onValueChanged_1(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dob.Value;
            int years = DateTime.Now.Year - dob.Value.Year;
            if (dob.Value.AddYears(years) < DateTime.Now) years--;
            txtage.Text = years.ToString();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            gridPt.DataSource = db.patients.Where(x => x.pt_name.Contains(txtSearch.text)).ToList();

        }

        private void gridPt_DoubleClick(object sender, EventArgs e)
        {
            if (gridPt.CurrentRow.Index != -1)
            {
                var u = Convert.ToInt32(gridPt.CurrentRow.Cells[0].Value);
                var pt = db.patients.FirstOrDefault(i => i.pt_id == u);
                txtId.Text = pt.pt_id.ToString();
                txtName.Text = pt.pt_name;
                dob.Value = Convert.ToDateTime(pt.dob);
                txtjob.Text = pt.job;
                comboGender.Text = pt.gender;
                comboStates.Text = pt.marital_status;
                txtaddress.Text = pt.address;
                txtmob.Text = pt.mobile;
                comboBlood.Text = pt.blood_type;
                txtNotes.Text = pt.notes;

                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Enter All Needed Fields!");  
            else if (!string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtId.Text))
            {
                var p = txtName.Text;
                var pt = db.patients.FirstOrDefault(i => i.pt_name == p);
                if (pt != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Parient Already Exisit Are You Want To Update This Parient?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        pt.pt_name = txtName.Text.Trim();
                        pt.dob =Convert.ToDateTime( dob.Value);
                        pt.job = txtjob.Text.Trim().Length < 1 ? null : txtjob.Text;
                        pt.gender = comboGender.Text.Trim().Length < 1 ? null : comboGender.Text;
                        pt.marital_status = comboStates.Text.Trim().Length < 1 ? null : comboStates.Text;
                        pt.address = txtaddress.Text.Trim().Length < 1 ? null : txtaddress.Text;
                        pt.blood_type = comboBlood.Text.Trim().Length < 1 ? null : comboBlood.Text;
                        pt.mobile = txtmob.Text.Trim().Length < 1 ? null : txtmob.Text;
                        pt.notes = txtNotes.Text.Trim().Length < 1 ? null : txtNotes.Text;
                        db.Entry(pt).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGridView();
                    }
                }
                else save();
            }
            else if (!string.IsNullOrEmpty(txtId.Text))
            {
                var p = Convert.ToInt32(txtId.Text);
                var pt = db.patients.FirstOrDefault(i => i.pt_id == p);
                if (pt != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Parient?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        pt.pt_name = txtName.Text.Trim();
                        pt.dob = dob.Value;
                        pt.job = txtjob.Text.Trim().Length < 1 ? null : txtjob.Text;
                        pt.gender = comboGender.Text.Trim().Length < 1 ? null : comboGender.Text;
                        pt.marital_status = comboStates.Text.Trim().Length < 1 ? null : comboStates.Text;
                        pt.address = txtaddress.Text.Trim().Length < 1 ? null : txtaddress.Text;
                        pt.blood_type = comboBlood.Text.Trim().Length < 1 ? null : comboBlood.Text;
                        pt.mobile = txtmob.Text.Trim().Length < 1 ? null : txtmob.Text;
                        pt.notes = txtNotes.Text.Trim().Length < 1 ? null : txtNotes.Text;
                        db.Entry(pt).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGridView();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var p =Convert.ToInt32( txtId.Text);
            var pt = db.patients.FirstOrDefault(x => x.pt_id == p);
            if (pt != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Delete This Patient " + txtName.Text +" ? "  , "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.patients.Remove(pt);
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

        private void btnStartVist_Click(object sender, EventArgs e)
        {   
            var vis = db.vists.Select(x => x.visit_id).DefaultIfEmpty(0).Max();
            visit.visit_id = vis + 1;
            visit.FKpt_id = Convert.ToInt32(gridPt.CurrentRow.Cells[0].Value);
            visit.visitDate = DateTime.Now;
            visit.StaffName = main.getmainform.lblStaff.Text;
            db.vists.Add(visit);
            db.SaveChanges();
            main.getmainform.txtPtName.Text = gridPt.CurrentRow.Cells[1].Value.ToString();
            main.getmainform.txtDate.Text = DateTime.Now.ToString();
            main.getmainform.txtId.Text = (vis +1).ToString();
            main.getmainform.txtPtId.Text= gridPt.CurrentRow.Cells[0].Value.ToString();
            main.getmainform.panelslide.Width = 220;
            main.getmainform.pnlPt.Height = 86;
            main.getmainform.panelTrans.ShowSync(main.getmainform.panelslide);
            main.getmainform.examPanel.Visible = true;
            main.getmainform.pnlPtSlide.ShowSync(main.getmainform.pnlPt);
            main.getmainform.btnmenue.Visible = true;
            this.Close();
        }

    }
}
