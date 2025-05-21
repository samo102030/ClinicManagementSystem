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
    public partial class treatment : UserControl
    {
        private static user_controls.treatment instance;
        public static user_controls.treatment getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.treatment();
                return instance;
            }
        }
        public treatment()
        {
            InitializeComponent();
        }
     
    }
}
