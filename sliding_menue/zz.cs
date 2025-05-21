using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sliding_menue
{
    public partial class zz : Form
    {
        clincEntities db = new clincEntities();
        public zz()
        {
            InitializeComponent();
        }

         void populateGrid()
        {
            gridVisits.AutoGenerateColumns = false;
            var vis = from c in db.vists
                      join d in db.patients
                      on c.FKpt_id equals d.pt_id
                      select new
                      {
                          vId = c.visit_id,
                          vDate = c.visitDate,
                          id = d.pt_id,
                          name = d.pt_name   
                      };
            foreach (var item in vis)
            {
                gridVisits.DataSource = vis.ToList();
            }
           
        }

        void populateChkList()
        {
            for (int i = 0; i < gridVisits.Columns.Count; i++)
            {
                //gridVisits.Columns[i].HeaderText;
                chkList.Items.Add(gridVisits.Columns[i].HeaderText);

            }
            //foreach (var item in gridVisits.Columns)
            //{
            //    //string x=
            //    chkList.Items.Add(item);
            //}
        }

        public void repovis()
        {
            var vis = from c in db.vists
                     join d in db.patients
                     on c.FKpt_id equals d.pt_id
                     select new
                     {
                         vId = c.visit_id,
                         vDate = c.visitDate,
                         id = d.pt_id,
                         name = d.pt_name
                     };
        }

        private void zz_Load(object sender, EventArgs e)
        {
            //populateGrid();
            //populateChkList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CrystalReport2 repo = new CrystalReport2();
            CrystalReport1 rep1 = new CrystalReport1();
            repo.SetParameterValue("@ptId", gridVisits.CurrentRow.Cells[0].Value, repo.Subreports[0].Name.ToString());
            repo.SetParameterValue("@ptId", gridVisits.CurrentRow.Cells[0].Value, repo.Subreports[1].Name.ToString());
            rep1.Section3.ReportObjects[0].ObjectFormat.EnableSuppress = true;
            testReports frm = new testReports();
            frm.crystalReportViewer1.ReportSource = repo;
            frm.ShowDialog();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if (cb.Checked)
                    {
                        cb.Enabled = false;
                    }
                }
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            foreach (var item in chkList.Items)
            {
                int index = chkList.Items.IndexOf(item);
                if (chkList.GetItemCheckState(index) == CheckState.Checked)
                {
                    gridVisits.Columns[index].Visible = false;
                }
                else
                {
                    gridVisits.Columns[index].Visible = true;
                }
            }

            // anthoer work souluation for show and hide columns in grid depend on chklist box
            //for (int i = 0; i < chkList.Items.Count; i++)
            //{
            //    //if (chkList.GetItemChecked(i))
            //    //{
            //    //    gridVisits.Columns[i].Visible = false;
            //    //}

            //    //else if (chkList.GetItemCheckState(i) == CheckState.Unchecked)
            //    //{
            //    //    gridVisits.Columns[i].Visible = true;
            //    //}
               
            //    if (chkList.GetItemCheckState(i) == CheckState.Checked)
            //    {
            //        gridVisits.Columns[i].Visible = false;
            //    }
            //    else
            //    {
            //        gridVisits.Columns[i].Visible = true;
            //    }
            //}
        }

        private void gridVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
