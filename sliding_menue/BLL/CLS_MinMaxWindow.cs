using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using sliding_menue.user_controls;

namespace sliding_menue.BLL
{
    class CLS_MinMaxWindow
    {
        clincEntities db = new clincEntities();
        //public FormWindowState WindowState { get; private set; }

        void populatecombo()
        {
            var symp = db.symptoms;
            CC_And_HPI.getinstance.comboSymp.ValueMember = "sympt_id";
            CC_And_HPI.getinstance.comboSymp.DisplayMember = "symptom_name";
            CC_And_HPI.getinstance.comboSymp.DataSource = symp.ToList();
            //CC_And_HPI.getinstance.comboSymp.SelectedIndex = -1;
        }

        public void mini()
        {
            FormWindowState WindowState = default(FormWindowState);
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

    }
}
