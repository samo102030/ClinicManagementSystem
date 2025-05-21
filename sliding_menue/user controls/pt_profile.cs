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
    public partial class pt_profile : UserControl
    {
        //main m = new main();
        private static user_controls.pt_profile instance;
        public static user_controls.pt_profile getinstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new user_controls.pt_profile();
                return instance;
            }
        }
    
        public pt_profile()
        {
            InitializeComponent();
        }

  
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           //user_controls.pt_profile.getinstance.Dispose();
          
            //main m = new main();
            //m.panel2.Visible = false;
            //m.examPanel.Visible = false;

          
        }

     
    }
}
