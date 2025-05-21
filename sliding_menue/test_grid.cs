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
    public partial class test_grid : Form
    {
        clincEntities db = new clincEntities();
        score model = new score();
        public test_grid()
        {
            InitializeComponent();
        }

        private void test_grid_Load(object sender, EventArgs e)
        {
            metroGrid1.AutoGenerateColumns = false;
            var scr = db.scores;
            metroGrid1.DataSource = scr.ToList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                bunifuCustomDataGrid1.Columns[0].Visible = false;
            }
            else
            {
                bunifuCustomDataGrid1.Columns[0].Visible = true;

            }
        }
    }
}
