using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sliding_menue.user_controls;

namespace sliding_menue.BLL
{
    class CLS_ClearControls
    {
        public static void CloseVisitObjects()
        {
            foreach (Control item in main.getmainform.examPanel.Controls)
            {
                if (item is UserControl)
                {
                    //UserControl uc = (UserControl)item;
                    main.getmainform.examPanel.Controls.Remove(item);
                }
            }

            //main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);
            //main.getmainform.examPanel.Controls.Remove(diagnosis.getinstance);
            //main.getmainform.examPanel.Controls.Remove(Examin.getinstance);
            //main.getmainform.examPanel.Controls.Remove(finalDiag.getinstance);
            //main.getmainform.examPanel.Controls.Remove(labtest.getinstance);
            //main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);
            //main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);
            //main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);
            //main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);
            //main.getmainform.examPanel.Controls.Remove(CC_And_HPI.getinstance);

            CC_And_HPI.instance = null;
            diagnosis.instance = null;
            Examin.instance = null;
            finalDiag.instance = null;
            labtest.instance = null;
            management.instance = null;
            PtsScr.instance = null;
            PFSH.instance = null;
            PtRadiology.instance = null;
            ROS.instnace = null;
            main.getmainform.examPanel.Visible = false;
        }
    }
}
