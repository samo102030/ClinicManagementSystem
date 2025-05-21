using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sliding_menue.user_controls;
using System.Threading;
using System.Threading.Tasks;
using sliding_menue.BLL;

namespace sliding_menue
{
    public partial class main : Form
    {
        clincEntities db = new clincEntities();
        private static main frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static main getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
                
        public main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.panelslide.Visible = true;
            lblStaff.Text = Program.staff;
        }

        // to make main bttns visable = false 
         void mainbtnvis()
        {
            bunifuTileButton1.Visible = false;
            bunifuTileButton2.Visible = false;
            bunifuTileButton3.Visible = false;
            bunifuTileButton4.Visible = false;
            bunifuTileButton5.Visible = false;
            bunifuTileButton6.Visible = false;
            bunifuTileButton7.Visible = false;
            bunifuTileButton8.Visible = false;
        }
        private void btnmenue_Click(object sender, EventArgs e)
        {
            //if (!examPanel.Controls.Contains(user_controls.family_histrory.getinstance))
            //{
            //    examPanel.Controls.Add(user_controls.family_histrory.getinstance);
            //}
            //// to slide panel menu
            if (panelslide.Width == 50)
            {
                panelslide.Width = 220;
                panelTrans.ShowSync(panelslide);                
            }
            else
            { 
                panelslide.Width = 50;
                panelTrans.ShowSync(panelslide);
            }
            if (examPanel.Width == 1221)
            {
                examPanel.Width = 1400;
            }
            else
            {
                examPanel.Width = 1221;
            }   
        }

        void clear()
        {
            txtId.Text = txtPtName.Text = txtDate.Text = "";
            lblStaff.Text = "THE MEDICAL CLINC";
        }
        void populatecombo()
        {
            var symp = db.symptoms;
            CC_And_HPI.getinstance.comboSymp.ValueMember = "sympt_id";
            CC_And_HPI.getinstance.comboSymp.DisplayMember = "symptom_name";
            CC_And_HPI.getinstance.comboSymp.DataSource = symp.ToList();
            //CC_And_HPI.getinstance.comboSymp.SelectedIndex = -1;
        }
        
        private void main_Load(object sender, EventArgs e)
        {
            panelslide.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //Task t = new Task(populatecombo);
            //t.Start();
            //Thread t = new Thread(delegate() { populatecombo(); });
            //t.SetApartmentState(ApartmentState.STA);
            //t.Start();
        }

        //close button
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //maximized screen:
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal;
            }
        }
        //minimized screen:
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }

        }

        private void patintProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlPt.Visible = true;
            
            pnlPt.BringToFront();
            if (!pnlPt.Controls.Contains(user_controls.pt_profile.getinstance))
            {
                pnlPt.Controls.Add(user_controls.pt_profile.getinstance);
                user_controls.pt_profile.getinstance.Dock = DockStyle.Fill;
                user_controls.pt_profile.getinstance.BringToFront();
                //bunifuImageButton4.BringToFront();
                bunifuTileButton1.Visible = false;
                bunifuTileButton2.Visible = false;
                bunifuTileButton3.Visible = false;
                bunifuTileButton4.Visible = false;
                bunifuTileButton5.Visible = false;
                bunifuTileButton6.Visible = false;
                bunifuTileButton7.Visible = false;
                bunifuTileButton8.Visible = false;
            }
            else
            {
                user_controls.pt_profile.getinstance.BringToFront();
                //bunifuImageButton4.BringToFront();
            }
        }

        private void header_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPt.Visible = false;
        }
     
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            examPanel.Visible = false;
            pnlPt.Visible = false;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            add_patient addpt = add_patient.getinstance();
            addpt.ShowDialog();
        }

        //home btn
        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {
            pnlPt.Controls.Remove(user_controls.family_histrory.getinstance);
            //user_controls.family_histrory.getinstance.
            bunifuTileButton1.Visible = true;
            bunifuTileButton2.Visible = true;
            bunifuTileButton3.Visible = true;
            bunifuTileButton4.Visible = true;
            bunifuTileButton5.Visible = true;
            bunifuTileButton6.Visible = true;
            bunifuTileButton7.Visible = true;
            bunifuTileButton8.Visible = true;
            pnlPt.Visible = false;
            panelslide.Visible = false;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            add_stuff addstf = new add_stuff();
            addstf.ShowDialog();
        }

        private void genralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_symp symp = add_symp.getinstance();
            symp.ShowDialog();
        }

        private void bySystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_signs sign = add_signs.getinstance();
            sign.ShowDialog();
        }
    
        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_stuff stf = add_stuff.getinstance();
            stf.ShowDialog();

        }
        
        //Notifi Icon :
        bool ineedclose = false;
        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            if (!ineedclose)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "LEADERS SOFT", "PROGRAM STILL RUNNING...", ToolTipIcon.Info);
            }
        }

        private void systemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_system adsys = add_system.getinstance();
            adsys.ShowDialog();
        }

        private void diseaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_disease dise = new add_disease();
            dise.ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            //exambutn.Visible = false;
            //panel2.Controls.Remove(user_controls.pt_profile.getinstance);
            //panel2.Controls.Remove(user_controls.pt_profile.getinstance);
            user_controls.pt_profile.getinstance.Dispose();

            pnlPt.Visible = false;
            //user_controls.pt_profile.getinstance.tsttxtbo.Text = "samuel nashed بيحيكو من قلب الحدث";
            //user_controls.pt_profile.getinstance.bunifuCustomDataGrid1.Visible = false;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
           //user_controls.examination ex=new user_controls.examination();
           //    ex. metroComboBox1.Text = " ";
        }

        private void lapTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_lab_test lbtst = add_lab_test.getinstance();
            lbtst.ShowDialog();
        }

        private void radiologyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_radiology rdio = add_radiology.getinstance();
            rdio.ShowDialog();
        }

        private void scoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_score scr = add_score.getinstance();
            scr.ShowDialog();
        }

        private void newDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_drugs drg = add_drugs.getinstance();
            drg.ShowDialog();
        }

        //panel Marker :
        ////private void ecgbtn_Click(object sender, EventArgs e)
        ////{
        ////    panelscrol.Height = ecgbtn.Height;
        ////    panelscrol.Top = ecgbtn.Top;

        ////    examPanel.Visible = true;
        ////    if (!examPanel.Controls.Contains(user_controls.ecg.getinstance))
        ////    {
        ////        examPanel.Controls.Add(user_controls.ecg.getinstance);
        ////        user_controls.ecg.getinstance.Dock = DockStyle.Fill;
        ////        user_controls.ecg.getinstance.BringToFront();
        ////        mainbtnvis();

        ////    }
        ////    else
        ////    {
        ////        user_controls.ecg.getinstance.BringToFront();
        ////        mainbtnvis();
        ////    }
        ////}

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_classes cls = new add_classes();
            cls.ShowDialog();
        }

        private void sergicalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_sergical srg = new add_sergical();
            srg.ShowDialog();
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            pnlMarker.Visible = true;
            pnlMarker.Height = btnCc.Height;
            pnlMarker.Top = btnCc.Top;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(CC_And_HPI.getinstance))
            {
                examPanel.Controls.Add(CC_And_HPI.getinstance);
               CC_And_HPI.getinstance.Dock = DockStyle.Fill;
                CC_And_HPI.getinstance.BringToFront();
                mainbtnvis();
            }

            else
            {
               CC_And_HPI.getinstance.BringToFront();
                mainbtnvis();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            zz z = new zz();

            z.MdiParent = this;
            z.Show();
            //z.Dock = DockStyle.Fill;
        }

        private void btnCancelVisit_Click(object sender, EventArgs e)
        {
            var v = Convert.ToInt32(txtId.Text);
            var vis = db.vists.FirstOrDefault(i => i.visit_id == v);
            if (vis != null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Cancel This Visit?", "alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.vists.Remove(vis);
                    db.SaveChanges();
                    clear();
                    //examPanel.Controls.Remove(CC_And_HPI.getinstance);
                    CLS_ClearControls.CloseVisitObjects();
                    panelslide.Visible = false;
                    pnlPt.Visible = false;
                    btnmenue.Enabled = false;
                }
            }
            
            //foreach (Control item in this.examPanel.Controls)
            //{
            //    if (item is UserControl)
            //    {
            //        this.examPanel.Controls.Remove(item);
            //    }
            //}
            //examPanel.Controls.Remove(CC_And_HPI.getinstance);
            //examPanel.Visible = false;
            //CC_And_HPI.instance = null;
        }

        private void btnRos_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnRos.Height;
            pnlMarker.Top = btnRos.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(ROS.getinstance))
            {
                examPanel.Controls.Add(ROS.getinstance);
                ROS.getinstance.Dock = DockStyle.Fill;
                ROS.getinstance.BringToFront();
                mainbtnvis();
            }

            else
            {
                ROS.getinstance.BringToFront();
                mainbtnvis();
            }

        }

        private void btnPfsh_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnPfsh.Height;
            pnlMarker.Top = btnPfsh.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(PFSH.getinstance))
            {
                examPanel.Controls.Add(PFSH.getinstance);
                PFSH.getinstance.Dock = DockStyle.Fill;
                PFSH.getinstance.BringToFront();
                mainbtnvis();
            }

            else
            {
                PFSH.getinstance.BringToFront();
                mainbtnvis();
            }

        }

        private void btnExami_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnExami.Height;
            pnlMarker.Top = btnExami.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(Examin.getinstance))
            {
                examPanel.Controls.Add(Examin.getinstance);
                Examin.getinstance.Dock = DockStyle.Fill;
                Examin.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                Examin.getinstance.BringToFront();
                mainbtnvis();
            } 
        }

        private void btnProvisi_Click(object sender, EventArgs e)
        {
            
            pnlMarker.Height = btnProvisi.Height;
            pnlMarker.Top = btnProvisi.Top;
            pnlMarker.Visible = true;
            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(diagnosis.getinstance))
            {
                examPanel.Controls.Add(diagnosis.getinstance);
                diagnosis.getinstance.Dock = DockStyle.Fill;
                diagnosis.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                diagnosis.getinstance.BringToFront();
                mainbtnvis();
            }
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnLab.Height;
            pnlMarker.Top = btnLab.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(labtest.getinstance))
            {
                examPanel.Controls.Add(labtest.getinstance);
                labtest.getinstance.Dock = DockStyle.Fill;
                labtest.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                labtest.getinstance.BringToFront();
                mainbtnvis();
            }
        }

        private void btnRad_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnRad.Height;
            pnlMarker.Top = btnRad.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(PtRadiology.getinstance))
            {
                examPanel.Controls.Add(PtRadiology.getinstance);
                PtRadiology.getinstance.Dock = DockStyle.Fill;
                PtRadiology.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                PtRadiology.getinstance.BringToFront();
                mainbtnvis();
            }
        }

        private void btnFdiag_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnFdiag.Height;
            pnlMarker.Top = btnFdiag.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(finalDiag.getinstance))
            {
                examPanel.Controls.Add(finalDiag.getinstance);
                finalDiag.getinstance.Dock = DockStyle.Fill;
                finalDiag.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                finalDiag.getinstance.BringToFront();
                mainbtnvis();
            }
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnScores.Height;
            pnlMarker.Top = btnScores.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(PtsScr.getinstance))
            {
                examPanel.Controls.Add(PtsScr.getinstance);
                PtsScr.getinstance.Dock = DockStyle.Fill;
                PtsScr.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                PtsScr.getinstance.BringToFront();
                mainbtnvis();
            }
        }

        private void btnMangePlan_Click(object sender, EventArgs e)
        {
            pnlMarker.Height = btnMangePlan.Height;
            pnlMarker.Top = btnMangePlan.Top;
            pnlMarker.Visible = true;

            examPanel.Visible = true;
            //to show user control in my panel :)
            if (!examPanel.Controls.Contains(management.getinstance))
            {
                examPanel.Controls.Add(management.getinstance);
                management.getinstance.Dock = DockStyle.Fill;
                management.getinstance.BringToFront();
                mainbtnvis();
            }
            else
            {
                management.getinstance.BringToFront();
                mainbtnvis();
            }
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_patient pt = new add_patient();
            pt.ShowDialog();
        }

        private void searchVisitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allvVisits alv = new allvVisits();
            alv.ShowDialog();
        }

       
    }
}
