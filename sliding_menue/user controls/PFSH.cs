using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sliding_menue.user_controls
{
   
    public partial class PFSH : UserControl
    {
        clincEntities db = new clincEntities();
        public static user_controls.PFSH instance;
        public static user_controls.PFSH getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.PFSH();
                return instance;
            }
        }
        public PFSH()
        {
            InitializeComponent();
        }

        void populateDiseas()
        {
            var diseas = db.diseases;
            comboDiseas.ValueMember = "diseaseId";
            comboDiseas.DisplayMember = "disease_name";
            comboDiseas.DataSource = diseas.ToList();
        }

        void populateDise()
        {
            var dise = db.diseases;
            comboDise.ValueMember = "diseaseId";
            comboDise.DisplayMember = "disease_name";
            comboDise.DataSource = dise.ToList();
        }

        void populateDrugs()
        {
            var drug = db.drugs;
            comboDrug.ValueMember = "drug_id";
            comboDrug.DisplayMember = "drug_name";
            comboDrug.DataSource = drug.ToList();
        }

        void clear()
        {
             txtCronic.Text = txtDrug.Text = txtDrugg.Text = txtFamDiseas.Text = txtHospitalAdm.Text
                = txtNotWoman.Text= txtNoteSC.Text = txtNotes.Text = txtSergical.Text = "";
            comboDise.SelectedIndex = comboDiseas.SelectedIndex = comboDrive.SelectedIndex 
                = comboDrug.SelectedIndex
                = comboMenst.SelectedIndex = comboPregnancy.SelectedIndex = comboSmoking.SelectedIndex
                = comboAlchol.SelectedIndex = comboPills.SelectedIndex=comboAbortion.SelectedIndex = -1;
            comboDiseas.Focus();
        }
        private void PFSH_Load(object sender, EventArgs e)
        {
            populateDiseas();
            populateDise();
            populateDrugs();
            clear();
        }

        private void btnAddDiseas_Click(object sender, EventArgs e)
        {
            txtCronic.Text = txtCronic.Text + " " + comboDiseas.Text + " ";
            txtCronic.Focus();
            txtCronic.SelectionStart = txtCronic.Text.Length;
            txtCronic.SelectionLength = 0;
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            txtDrug.Text = txtDrug.Text + " " + comboDrug.Text + " ";
            txtDrug.Focus();
            txtDrug.SelectionStart = txtDrug.Text.Length;
            txtDrug.SelectionLength = 0;
        }

        private void btnAddDise_Click(object sender, EventArgs e)
        {
            txtFamDiseas.Text = txtFamDiseas.Text + " " + comboDise.Text + " ";
            txtFamDiseas.Focus();
            txtFamDiseas.SelectionStart = txtFamDiseas.Text.Length;
            txtFamDiseas.SelectionLength = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.InsertPastMedicalHistory(Convert.ToInt32(main.getmainform.txtId.Text),
                txtCronic.Text, txtSergical.Text, txtHospitalAdm.Text,
                txtDrug.Text, txtNotes.Text);

            db.InsertFamHistory(Convert.ToInt32(main.getmainform.txtId.Text), txtFamDiseas.Text);

            db.InsertSocialHistory(Convert.ToInt32(main.getmainform.txtId.Text), 
                comboSmoking.Text, comboAlchol.Text,txtDrugg.Text, comboDrive.Text, 
                comboMenst.Text, comboPregnancy.Text, comboAbortion.Text,
                comboPills.Text,txtNoteSC.Text, txtNotWoman.Text);
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

    
    }
}
