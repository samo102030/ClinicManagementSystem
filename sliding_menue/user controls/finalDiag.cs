using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sliding_menue.user_controls;
using System.Data.Entity;

namespace sliding_menue.user_controls
{
    public partial class finalDiag : UserControl
    {
        clincEntities db = new clincEntities();
        public static finalDiag instance;
        public static finalDiag getinstance
        {
            get
            {
                if (instance ==null)
                    instance = new finalDiag();                 
                return instance;
            }
        }
        public finalDiag()
        {
            InitializeComponent();
        }

        void clearFinal()
        {
            txtFinalDiag.Text = "";
            comboDiseas.SelectedIndex = -1;
        }

        void populatecombo()
        {
            var dise = db.diseases;
            comboDiseas.ValueMember = "diseaseId";
            comboDiseas.DisplayMember = "disease_name";
            comboDiseas.DataSource = dise.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to start vist");
            else if (string.IsNullOrEmpty(txtFinalDiag.Text))
            {
                MessageBox.Show("there is no data to save");
            }
            else
            {
                var v = Convert.ToInt32(main.getmainform.txtId.Text);
                var vis = db.vists.FirstOrDefault(i => i.visit_id == v);
                if (vis != null)
                {
                    vis.fina_diag = txtFinalDiag.Text.Trim();
                    db.Entry(vis).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
                    clearFinal();
                }
            }
        }

        private void finalDiag_Load(object sender, EventArgs e)
        {
            populatecombo();
            clearFinal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFinalDiag.Text = txtFinalDiag.Text + " " + comboDiseas.Text + " ";
            txtFinalDiag.Focus();
            txtFinalDiag.SelectionStart = txtFinalDiag.Text.Length;
            txtFinalDiag.SelectionLength = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFinal();
            comboDiseas.Focus();
        }
    }
}
