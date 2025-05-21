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
    public partial class ROS : UserControl
    {
        clincEntities db = new clincEntities();
        hoo model = new hoo();
        public static ROS instnace;
        public static ROS getinstance
        {
            get
            {
                if (instnace==null)
                {
                    instnace = new ROS();
                }
                return instnace;
            }
        }
        public ROS()
        {
            InitializeComponent();
            
        }
        public static void clearRos()
        {
           ROS.getinstance.txtRos.Text = "";
           ROS.getinstance.comboSys.SelectedIndex = ROS.getinstance.comboSymp.SelectedIndex = -1;
           ROS.getinstance.comboSys.Focus();
        }

        void populatecombo1()
        {
            var symp = db.symptoms;
            ROS.getinstance.comboSymp.ValueMember = "sympt_id";
            ROS.getinstance.comboSymp.DisplayMember = "symptom_name";
            ROS.getinstance.comboSymp.DataSource = symp.ToList();
            //CC_And_HPI.getinstance.comboSymp.SelectedIndex = -1;
        }

        void populatecomboSys()
        {
            var symp = db.systs;
            ROS.getinstance.comboSys.ValueMember = "id";
            ROS.getinstance.comboSys.DisplayMember = "name";
            ROS.getinstance.comboSys.DataSource = symp.ToList();
            //CC_And_HPI.getinstance.comboSymp.SelectedIndex = -1;
        }

        private void ROS_Load(object sender, EventArgs e)
        {
            populatecombo1();
            populatecomboSys();
            //clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRos.Text = txtRos.Text + " " + comboSymp.Text + " ";
            txtRos.Focus();
            txtRos.SelectionStart = txtRos.Text.Length;
            txtRos.SelectionLength = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to start vist");
            }
            else
            {
                for (int i = 0; i < gridRos.Rows.Count; i++)
                {
                    db.InsertHoos(Convert.ToInt32(main.getmainform.txtId.Text), 
                        gridRos.Rows[i].Cells[0].Value.ToString(), gridRos.Rows[i].Cells[1].Value.ToString());
                }
            }
            clearRos();
            gridRos.Rows.Clear();
           
        }

        private void btnAddToGrid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRos.Text))
            {
                MessageBox.Show("there is no data to Add");
            }
            else
            {
                for (int i = 0; i < gridRos.Rows.Count; i++)
                {
                    if (comboSys.Text == gridRos.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("this item was added before");
                        return;
                    }
                }
                string s1 = comboSys.Text;
                string p1 = txtRos.Text;

                string[] rows1 = { s1, p1 };
                gridRos.Rows.Add(rows1);
            }
            clearRos();
           
        }

        private void gridRos_DoubleClick(object sender, EventArgs e)
        {
            if (gridRos.CurrentRow.Index != -1)
            {
                comboSys.Text = gridRos.CurrentRow.Cells[0].Value.ToString();
                txtRos.Text = gridRos.CurrentRow.Cells[1].Value.ToString();
                gridRos.Rows.RemoveAt(gridRos.CurrentRow.Index);
                txtRos.Focus();
            }
        }
    }
}
