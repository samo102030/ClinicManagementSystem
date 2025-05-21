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
    public partial class allvVisits : Form
    {
        clincEntities db = new clincEntities();
        public allvVisits()
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

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            //if (rad)
            //{

            //}
            var x = txtSearch.text;
            //int id = int.Parse(x);
            //int visId = int.Parse(x);
            if (RadBtnDate.Checked)
            {
                var dat = txtSearch.text;
                var search = from c in db.vists
                             join d in db.patients
                             on c.FKpt_id equals d.pt_id
                             where c.visitDate.ToString().Contains(txtSearch.text)
                             //|| d.pt_id== int.Parse(x)
                             //|| c.visit_id== int.Parse(x)
                             select new
                             {
                                 vId = c.visit_id,
                                 vDate = c.visitDate,
                                 id = d.pt_id,
                                 name = d.pt_name
                             };
                gridVisits.DataSource = search.ToList();
            }
            else if (RadBtnPtName.Checked)
            {
                var dat = txtSearch.text;
                var search = from c in db.vists
                             join d in db.patients
                             on c.FKpt_id equals d.pt_id
                             where d.pt_name.Contains(txtSearch.text)
                             //|| d.pt_id== int.Parse(x)
                             //|| c.visit_id== int.Parse(x)
                             select new
                             {
                                 vId = c.visit_id,
                                 vDate = c.visitDate,
                                 id = d.pt_id,
                                 name = d.pt_name
                             };
                gridVisits.DataSource = search.ToList();
            }
           
                
            
            

        }

        private void allvVisits_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

   
    }
}
