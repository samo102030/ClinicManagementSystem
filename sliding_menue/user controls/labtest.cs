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
    public partial class labtest : UserControl
    {
        clincEntities db = new clincEntities();
        public static user_controls.labtest instance;
        public static user_controls.labtest getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.labtest();
                return instance;
            }
        }
        public labtest()
        {
            InitializeComponent();
        }

        public static void clearLabTst()
        {
            labtest.getinstance.txtResault.Text = "";
            labtest.getinstance.comboLabTest.SelectedIndex = -1;
            labtest.getinstance.comboLabTest.Focus();
            labtest.getinstance.DateLabTest.Value = DateTime.Now;
        }
       
        void populatecombo()
        {
            var symp = db.lab_tests;
            comboLabTest.ValueMember = "test_id";
            comboLabTest.DisplayMember = "test_name";
            comboLabTest.DataSource = symp.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labtest_Load(object sender, EventArgs e)
        {
            populatecombo();
            clearLabTst();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboLabTest.Text) || string.IsNullOrEmpty(txtResault.Text))
            {
                MessageBox.Show("there is no data to Add");
            }
            else
            {
                for (int i = 0; i < GridPtLab.Rows.Count; i++)
                {
                    if (Convert.ToInt32( comboLabTest.SelectedValue) ==Convert.ToInt32( GridPtLab.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("this item was added before");
                        return;
                    }
                }
                string id = comboLabTest.SelectedValue.ToString();
                string s1 = comboLabTest.Text;
                string p1 = txtResault.Text;

                string[] rows1 = {id, s1, p1 };
                GridPtLab.Rows.Add(rows1);
            }
        }

        private void GridPtLab_DoubleClick(object sender, EventArgs e)
        {
            if (GridPtLab.CurrentRow.Index != -1)
            {
                comboLabTest.Text = GridPtLab.CurrentRow.Cells[1].Value.ToString();
                txtResault.Text = GridPtLab.CurrentRow.Cells[2].Value.ToString();
                GridPtLab.Rows.RemoveAt(GridPtLab.CurrentRow.Index);
                txtResault.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to start vist");
            }
            else
            {
                for (int i = 0; i < GridPtLab.Rows.Count; i++)
                {
                    db.InsertPatientLab(Convert.ToInt32(main.getmainform.txtId.Text),
                       Convert.ToInt32( GridPtLab.Rows[i].Cells[0].Value),
                       Convert.ToDecimal( GridPtLab.Rows[i].Cells[2].Value.ToString()),
                       Convert.ToDateTime(DateLabTest.Value));
                }
            }
            clearLabTst();
            GridPtLab.Rows.Clear();
        }

    }
}
