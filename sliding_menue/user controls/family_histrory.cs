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
    public partial class family_histrory : UserControl
    {
        private static user_controls.family_histrory instance;
        public static user_controls.family_histrory getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.family_histrory();
                return instance;
            }
        }
        public family_histrory()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            main.getmainform.exambtn.Enabled = false;
        }

    
    }
}
