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
    public partial class testReports : Form
    {
        clincEntities db = new clincEntities();
        public testReports()
        {
            InitializeComponent();
        }

        void visReport()
        {
            //gridVisits.AutoGenerateColumns = false;
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
                //gridVisits.DataSource = vis.ToList();
  
        }
        private void testReports_Load(object sender, EventArgs e)
        {

        }
    }
}
