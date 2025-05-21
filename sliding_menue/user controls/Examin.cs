using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using sliding_menue.BLL;
using sliding_menue.user_controls;
using System.IO;

namespace sliding_menue.user_controls
{
    public partial class Examin : UserControl
    {
        clincEntities db = new clincEntities();
        public static Examin instance;
        public static Examin getinstance
        {
            get
            {
                if (instance == null)
                    instance = new Examin();
                return instance;
            }
        }


        public Examin()
        {
            InitializeComponent();
        }

        void populateSigns()
        {
            var sign = db.signs;
            comboSigns.ValueMember = "sign_id";
            comboSigns.DisplayMember = "sign_name";
            comboSigns.DataSource = sign.ToList();

        }

        void clear()
        {
            txtAbdo.Text = txtArm.Text = txtBmi.Text = txtBp.Text = txtCardiac.Text = txtChest.Text = txtEcgNotes.Text =
                txtFce.Text = txtHand.Text = txtHigh.Text = txtLowerLemb.Text = txtNeck.Text = txtO2.Text = txtPulse.Text
                = txtRbs.Text = txtRr.Text = txtTemp.Text = txtWeight.Text = "";
            imgEcg.Image=null;
            comboSigns.SelectedIndex = -1;
        }

        private void examination_Load(object sender, EventArgs e)
        {
            populateSigns();
        }

        private void btnAddHand_Click(object sender, EventArgs e)
        {
            txtHand.Text = txtHand.Text + " " + comboSigns.Text + " ";
            txtHand.Focus();
            txtHand.SelectionStart = txtHand.Text.Length;
            txtHand.SelectionLength = 0;
        }

        private void btnArm_Click(object sender, EventArgs e)
        {
            txtArm.Text = txtArm.Text + " " + comboSigns.Text + " ";
            txtArm.Focus();
            txtArm.SelectionStart = txtArm.Text.Length;
            txtArm.SelectionLength = 0;
        }

        private void btnNec_Click(object sender, EventArgs e)
        {
            txtNeck.Text = txtNeck.Text + " " + comboSigns.Text + " ";
            txtNeck.Focus();
            txtNeck.SelectionStart = txtNeck.Text.Length;
            txtNeck.SelectionLength = 0;
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            txtFce.Text = txtFce.Text + " " + comboSigns.Text + " ";
            txtFce.Focus();
            txtFce.SelectionStart = txtFce.Text.Length;
            txtFce.SelectionLength = 0;
        }

        private void btnLowerLemb_Click(object sender, EventArgs e)
        {
            txtLowerLemb.Text = txtLowerLemb.Text + " " + comboSigns.Text + " ";
            txtLowerLemb.Focus();
            txtLowerLemb.SelectionStart = txtLowerLemb.Text.Length;
            txtLowerLemb.SelectionLength = 0;
        }

        private void btnCardiac_Click(object sender, EventArgs e)
        {
            txtCardiac.Text = txtCardiac.Text + " " + comboSigns.Text + " ";
            txtCardiac.Focus();
            txtCardiac.SelectionStart = txtCardiac.Text.Length;
            txtCardiac.SelectionLength = 0;
        }

        private void btnChest_Click(object sender, EventArgs e)
        {
            txtChest.Text = txtChest.Text + " " + comboSigns.Text + " ";
            txtChest.Focus();
            txtChest.SelectionStart = txtChest.Text.Length;
            txtChest.SelectionLength = 0;
        }

        private void btnAbdo_Click(object sender, EventArgs e)
        {
            txtAbdo.Text = txtAbdo.Text + " " + comboSigns.Text + " ";
            txtAbdo.Focus();
            txtAbdo.SelectionStart = txtAbdo.Text.Length;
            txtAbdo.SelectionLength = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                
            if (imgEcg.Image == null)
            {
                db.InsertExamination(Convert.ToInt32(main.getmainform.txtId.Text),
                    string.IsNullOrEmpty(txtPulse.Text) ? (int?)null : Convert.ToInt32(txtPulse.Text),
                    txtBp.Text,
                   string.IsNullOrEmpty(txtTemp.Text) ? (decimal?)null : Convert.ToDecimal(txtTemp.Text),
                    string.IsNullOrEmpty(txtO2.Text) ? (decimal?)null : Convert.ToDecimal(txtO2.Text),
                   string.IsNullOrEmpty(txtRr.Text) ? (decimal?)null : Convert.ToDecimal(txtRr.Text),
                    string.IsNullOrEmpty(txtRbs.Text) ? (decimal?)null : Convert.ToDecimal(txtRbs.Text),
                   string.IsNullOrEmpty(txtBmi.Text) ? (decimal?)null : Convert.ToDecimal(txtBmi.Text),
                    txtHand.Text, txtArm.Text, txtNeck.Text, txtFce.Text, txtLowerLemb.Text,
                    txtCardiac.Text, txtChest.Text, txtAbdo.Text,
                    null,
                    txtEcgNotes.Text);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                imgEcg.Image.Save(ms, imgEcg.Image.RawFormat);
                byte[] Picture = ms.ToArray() /*== null ? null : ms.ToArray()*/;
                db.InsertExamination(Convert.ToInt32(main.getmainform.txtId.Text),
                 string.IsNullOrEmpty(txtPulse.Text) ? (int?)null : Convert.ToInt32(txtPulse.Text),
                 txtBp.Text,
                string.IsNullOrEmpty(txtTemp.Text) ? (decimal?)null : Convert.ToDecimal(txtTemp.Text),
                 string.IsNullOrEmpty(txtO2.Text) ? (decimal?)null : Convert.ToDecimal(txtO2.Text),
                string.IsNullOrEmpty(txtRr.Text) ? (decimal?)null : Convert.ToDecimal(txtRr.Text),
                 string.IsNullOrEmpty(txtRbs.Text) ? (decimal?)null : Convert.ToDecimal(txtRbs.Text),
                string.IsNullOrEmpty(txtBmi.Text) ? (decimal?)null : Convert.ToDecimal(txtBmi.Text),
                 txtHand.Text, txtArm.Text, txtNeck.Text, txtFce.Text, txtLowerLemb.Text,
                 txtCardiac.Text, txtChest.Text, txtAbdo.Text,
                 Picture,
                 txtEcgNotes.Text);
            }

            clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image |*.JPG;*.JPEG;*.GIF;*.BMP;*.PNG;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgEcg.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

     
    }
}
