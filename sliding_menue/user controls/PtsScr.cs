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
    public partial class PtsScr : UserControl
    {
        clincEntities db = new clincEntities();
        public static user_controls.PtsScr instance;
        public static user_controls.PtsScr getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.PtsScr();
                return instance;
            }
        }
        public PtsScr()
        {
            InitializeComponent();
        }

        public static void clearPtScore()
        {
            PtsScr.getinstance.txtResault.Text = "";
            PtsScr.getinstance.comboScores.SelectedIndex = -1;
            PtsScr.getinstance.comboScores.Focus();
        }

        void populatecombo()
        {
            var symp = db.scores;
            comboScores.ValueMember = "score_id";
            comboScores.DisplayMember = "score_name";
            comboScores.DataSource = symp.ToList();
        }

        private void PtsScr_Load(object sender, EventArgs e)
        {
            populatecombo();
            clearPtScore();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboScores.Text) || string.IsNullOrEmpty(txtResault.Text))
            {
                MessageBox.Show("there is no data to Add");
            }
            else
            {
                for (int i = 0; i < GridPtScore.Rows.Count; i++)
                {
                    if (Convert.ToInt32( comboScores.SelectedValue) ==Convert.ToInt32( GridPtScore.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("this item was added before");
                        return;
                    }
                }
                string id = comboScores.SelectedValue.ToString();
                string s1 = comboScores.Text;
                string p1 = txtResault.Text;

                string[] rows1 = { id, s1, p1 };
                GridPtScore.Rows.Add(rows1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to start vist");
            }
            else
            {
                for (int i = 0; i < GridPtScore.Rows.Count; i++)
                {
                    db.InsertPatientScore(Convert.ToInt32(main.getmainform.txtId.Text),
                        Convert.ToInt32(GridPtScore.Rows[i].Cells[0].Value),
                        GridPtScore.Rows[i].Cells[2].Value.ToString());
                   
                }
            }
            clearPtScore();
            GridPtScore.Rows.Clear();
        }

        private void GridPtScore_DoubleClick(object sender, EventArgs e)
        {
            if (GridPtScore.CurrentRow.Index != -1)
            {
                comboScores.Text = GridPtScore.CurrentRow.Cells[1].Value.ToString();
                txtResault.Text = GridPtScore.CurrentRow.Cells[2].Value.ToString();
                GridPtScore.Rows.RemoveAt(GridPtScore.CurrentRow.Index);
                txtResault.Focus();
            }
        }
    }
}
