using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;


namespace sliding_menue.user_controls
{
    public partial class diagnosis : UserControl
    {
        clincEntities db = new clincEntities();
        public static user_controls.diagnosis instance;
        public static user_controls.diagnosis getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.diagnosis();
                return instance;
            }
        }
        public diagnosis()
        {
            InitializeComponent();
        }

         void clearProvi()
        { 
           txtProvisional.Text = "";
            comboDiseas.SelectedIndex = comboClass.SelectedIndex= - 1;
            
        }
        void clearAllrgy()
        {
            txtnotesAllergy.Text = "";
            GridPallrg.Rows.Clear();
        }
        void populatecombocls()
        {
            var clss = db.classifis;
            comboClass.ValueMember = "id";
            comboClass.DisplayMember = "name";
            comboClass.DataSource = clss.ToList();
        }

        void populatecomboDis()
        {
            var dis = db.diseases;
            comboDiseas.ValueMember = "diseaseId";
            comboDiseas.DisplayMember = "disease_name";
            comboDiseas.DataSource = dis.ToList();
        }

        void save()
        {
            for (int i = 0; i < GridPallrg.Rows.Count; i++)
            {
                allergy model = new allergy();
                //var fkpId = Convert.ToInt32(main.getmainform.txtPtId.TabIndex);
                //var fkClsId = Convert.ToInt32(GridPallrg.Rows[i].Cells[0].Value);
                //var ptAllrg = db.allergies.FirstOrDefault(x => x.FKpt_id == fkpId
                //                                            && x.FKclass_id == fkClsId);
                //if (ptAllrg!= null)
                //{
                //    MessageBox.Show("this allergy already exist");
                //}
                //else
                //{
                    model.FKclass_id = Convert.ToInt32(GridPallrg.Rows[i].Cells[0].Value);
                    model.FKpt_id = Convert.ToInt32(main.getmainform.txtPtId.Text);
                    model.notes = GridPallrg.Rows[i].Cells[2].Value.ToString();
                    db.allergies.Add(model);
                    db.SaveChanges();
                    clearProvi();
                //}
                
                
            }
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to start vist");
            else if (string.IsNullOrEmpty(txtProvisional.Text) )
            {
                MessageBox.Show("there is no data to save");
            }
            else
            {
                //var p= 
                var v = Convert.ToInt32(main.getmainform.txtId.Text);
                var vis = db.vists.FirstOrDefault(i => i.visit_id == v);
                if (vis != null)
                {
                    vis.provisional_diag = txtProvisional.Text.Trim();
                    db.Entry(vis).State = EntityState.Modified;
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
                    clearProvi();
                }
                

            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboDiseas.SelectedIndex == -1)
            {
                MessageBox.Show("Please select diseas");
            }
            else
            {
                txtProvisional.Text = txtProvisional.Text + " " + comboDiseas.Text + " ";
                txtProvisional.Focus();
                txtProvisional.SelectionStart = txtProvisional.Text.Length;
                txtProvisional.SelectionLength = 0;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearProvi();
            comboDiseas.Focus();
        }

        private void diagnosis_Load(object sender, EventArgs e)
        {
            populatecombocls();
            populatecomboDis();
            clearProvi();
            clearAllrgy();
        }

        private void btnAddCls_Click(object sender, EventArgs e)
        {
            var p = Convert.ToInt32(main.getmainform.txtPtId.Text);
            var cls = Convert.ToInt32(comboClass.SelectedValue);
            var pt = db.allergies.FirstOrDefault(x => (x.FKpt_id == p)
                                                        &&(x.FKclass_id==cls));
            if (pt!=null)
            {
                MessageBox.Show("this Allergy Class Already exisit");
            }
            else
            {
                if (string.IsNullOrEmpty(comboClass.Text))
                {
                    MessageBox.Show("there is no data to Add");
                }
                else
                {
                    for (int i = 0; i < GridPallrg.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(comboClass.SelectedValue) == Convert.ToInt32(GridPallrg.Rows[i].Cells[0].Value))
                        {
                            MessageBox.Show("this item was added before");
                            return;
                        }
                    }
                    string id = comboClass.SelectedValue.ToString();
                    string cln = comboClass.Text;
                    string n = txtnotesAllergy.Text;
                    string[] rows1 = { id, cln,n };
                    GridPallrg.Rows.Add(rows1);
                }
            }
        }

        private void btnSaveAllrgy_Click(object sender, EventArgs e)
        {
            if (GridPallrg.Rows.Count == 0)
            {
                MessageBox.Show("there is no data to save");
            }
            
            else save();
        }

    }
}
