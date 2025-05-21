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
//using System.Threading;
//using System.Threading.Tasks;

namespace sliding_menue.user_controls
{
    public partial class CC_And_HPI : UserControl
    {
        clincEntities db = new clincEntities();
        public static CC_And_HPI instance;
        public static CC_And_HPI getinstance
        {
            get
            {
                if (instance == null)
                    instance = new CC_And_HPI();
                return instance;
            }
        }

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        public CC_And_HPI()
        {
            InitializeComponent();
        }
        void populateLlist()
        {
            //var symp = db.symptoms;
            //CC_And_HPI.getinstance.lisymp.DataSource = symp.ToList();
            //CC_And_HPI.getinstance.lisymp.DisplayMember = "symptom_name";
            //CC_And_HPI.getinstance.lisymp.ValueMember = "sympt_id";
        }

       public static void clearCc()
        {
           CC_And_HPI.getinstance.txtCpi.Text = "";
            CC_And_HPI.getinstance.comboSymp.Focus();
        }
        //void populatecombo()
        //{
        //    var symp = db.symptoms;
        //    CC_And_HPI.getinstance.comboSymp.ValueMember = "sympt_id";
        //    CC_And_HPI.getinstance.comboSymp.DisplayMember = "symptom_name";
        //    CC_And_HPI.getinstance.comboSymp.DataSource = symp.ToList();
        //    //CC_And_HPI.getinstance.comboSymp.SelectedIndex = -1;
        //}
        void populatecombo()
        {
            var symp = db.symptoms;
            comboSymp.ValueMember = "sympt_id";
            comboSymp.DisplayMember = "symptom_name";
            comboSymp.DataSource = symp.ToList();   
        }

        private void CC_And_HPI_Load(object sender, EventArgs e)
        {
            populatecombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCpi.Text = txtCpi.Text + " " + comboSymp.Text + " ";
            txtCpi.Focus();
            txtCpi.SelectionStart = txtCpi.Text.Length;
            txtCpi.SelectionLength = 0;
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            //lisymp.DataSource = db.symptoms.Where(x => x.symptom_name.Contains(txtSearch.text)).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to start vist");
            else if (string.IsNullOrEmpty(txtCpi.Text))
            {
                MessageBox.Show("there is no data to save");
            }
            else
            {
                var v = Convert.ToInt32(main.getmainform.txtId.Text);
                var vis = db.vists.FirstOrDefault(i => i.visit_id == v);
                if (vis != null)
                {
                    vis.complaint = txtCpi.Text.Trim();
                    db.Entry(vis).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
                    clearCc();
                }
            }
        }

        private void testClose_Click(object sender, EventArgs e)
        {
            main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);
            main.getmainform.examPanel.Visible = false;
            instance = null;
        }
    }
}
