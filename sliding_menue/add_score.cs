using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sliding_menue
{
    public partial class add_score : Form
    {
        clincEntities db = new clincEntities();
        score model = new score();
        public add_score()
        {
            InitializeComponent();
        }

        private static add_score instance;
        public static add_score getinstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new add_score();
            else instance.BringToFront();
            return instance;

        }

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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void add_score_Load(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }

        void clear()
        {
            txtName.Text = txtId.Text = txtSearch.text = "";
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
            txtName.Focus();
        }

        void populateGrid()
        {
            //var drg = from d in db.scores
            //          select new
            //          {
            //              id = d.score_id,
            //              name = d.score_name,     
            //          };
            //gridScore.DataSource = drg.ToList();
            gridscr.AutoGenerateColumns = false;
            gridscr.DataSource = db.scores.ToList();
            //gridscr.AutoGenerateColumns = false;
            //var scr = db.scores;
            //gridscr.DataSource = scr.ToList();
        }

        void save()
        {
            model.score_name = txtName.Text.Trim();
            db.scores.Add(model);
            db.SaveChanges();
            clear();
            populateGrid();
            MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            gridscr.AutoGenerateColumns = false;
            gridscr.DataSource = db.scores.Where(x => x.score_name.Contains(txtSearch.text)).ToList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) && string.IsNullOrEmpty(txtName.Text)) MetroFramework.MetroMessageBox.Show(this, "Please Insert System Name");
            else if (!string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtId.Text))
            {
                var cl = txtName.Text;
                var score = db.scores.FirstOrDefault(i => i.score_name == cl);
                if (score != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Score Already Exisit Are You Want To Update This Class Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        score.score_name = txtName.Text.Trim();
                        db.Entry(score).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }
                else save();
            }
            else if (!string.IsNullOrEmpty(txtId.Text))
            {
                var cl = Convert.ToInt32(txtId.Text);
                var rad = db.scores.FirstOrDefault(i => i.score_id == cl);
                if (rad != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Want To Update This Score Name?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        rad.score_name = txtName.Text.Trim();
                        db.Entry(rad).State = EntityState.Modified;
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "there no Record To delete");
            }
            else
            {
                var s = Convert.ToInt32(txtId.Text);
                var score = db.scores.FirstOrDefault(x => x.score_id == s);
                if (score != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are You Sure You Want To Delete This Score ? It Will delete all Related Data!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        db.scores.Remove(score);
                        db.SaveChanges();
                        clear();
                        populateGrid();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            populateGrid();
        }

        private void gridscr_DoubleClick(object sender, EventArgs e)
        {
            if (gridscr.CurrentRow.Index != -1)
            {
                var s = Convert.ToInt32(gridscr.CurrentRow.Cells[0].Value);
                var src = db.scores.FirstOrDefault(i => i.score_id == s);
                txtId.Text = src.score_id.ToString();
                txtName.Text = src.score_name;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}
