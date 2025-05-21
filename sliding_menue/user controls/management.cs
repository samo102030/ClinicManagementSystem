using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace sliding_menue.user_controls
{
    public partial class management : UserControl
    {
        clincEntities db = new clincEntities();
        string s1, s2, s3, s4, x1, x2, x3, x4;

        public static string ConvertNumeralsToArabic(string input)

        {

            return input = input.Replace('0', '٠')

                        .Replace('1', '۱')

                        .Replace('2', '۲')

                        .Replace('3', '۳')

                        .Replace('4', '٤')

                        .Replace('5', '۵')

                        .Replace('6', '٦')

                        .Replace('7', '٧')

                        .Replace('8', '٨')

                        .Replace('9', '٩');

        }

        public static user_controls.management instance;
        public static user_controls.management getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.management();
                return instance;
            }
        }

        public management()
        {
            InitializeComponent();
        }

        private void addLabReq_Click(object sender, EventArgs e)
        {
            txtLabReq.Text = txtLabReq.Text + " " + comboLab.Text + "\r\n";
            txtLabReq.Focus();
            txtLabReq.SelectionStart = txtLabReq.Text.Length;
            txtLabReq.SelectionLength = 0;
        }

        private void btnRadReq_Click(object sender, EventArgs e)
        {
            txtRadReq.Text = txtRadReq.Text + " " + comboRad.Text + "\r\n";
            txtRadReq.Focus();
            txtRadReq.SelectionStart = txtLabReq.Text.Length;
            txtRadReq.SelectionLength = 0;
        }

        private void btnAddDrugDoes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboDrug.Text) || string.IsNullOrEmpty( comboOften.Text) || string.IsNullOrEmpty(comboEvery.Text) || string.IsNullOrEmpty(comboFood.Text))
            {
                MessageBox.Show("Please complete Drug description");
            }
            else
            {
                for (int i = 0; i < gridPrsc.Rows.Count; i++)
                {
                    if (Convert.ToInt32(comboDrug.SelectedValue) == Convert.ToInt32(gridPrsc.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("this item was added before");
                        return;
                    }
                }
                string drgId = comboDrug.SelectedValue.ToString();
                string drgName = comboDrug.Text;
                string prscEng = lblEng.Text;
                string prscAra = lblArabic.Text;
                string prscNote = prscNotes.Text;
                string[] rows1 = { drgId, drgName, prscEng, prscAra, prscNote };
                gridPrsc.Rows.Add(rows1);
                clearPrsc();
            }
        }

        void populateClss()
        {
            var cls = db.classifis;
            comboClss.ValueMember = "id";
            comboClss.DisplayMember = "name";
            comboClss.DataSource = cls.ToList();
        }

        void populateDrugs()
        {
            var drug = db.drugs;
            comboDrug.ValueMember = "drug_id";
            comboDrug.DisplayMember = "drug_name";
            comboDrug.DataSource = drug.ToList();
        }

        void populateLab()
        {
            var symp = db.lab_tests;
            comboLab.ValueMember = "test_id";
            comboLab.DisplayMember = "test_name";
            comboLab.DataSource = symp.ToList();
        }

        void populateRad()
        {
            var symp = db.radiologies;
            comboRad.ValueMember = "radiology_id";
            comboRad.DisplayMember = "radio_name";
            comboRad.DataSource = symp.ToList();
        }

        void arab()
        {
            if (string.IsNullOrEmpty(txtDoes.Text) && string.IsNullOrEmpty(comboDays.Text)
                || string.IsNullOrEmpty(txtDoes.Text) && comboDays.Text != "life-time" )
            {
                lblArabic.Text = !string.IsNullOrEmpty(comboOften.Text) ? ConvertNumeralsToArabic(s1) + " " + s2 + " " + s3 : s1 
                    + " " + s2 + " " + s3 ;
            }
            else if (comboDays.Text == "life-time")
            {
                lblArabic.Text = !string.IsNullOrEmpty(comboOften.Text) ? ConvertNumeralsToArabic(s1)
                    + " " + s2 + " " + s3 + " " + " " + s4 + " " + ConvertNumeralsToArabic(prscNotes.Text) : s1
                    + " " + s2 + " " + s3 + " " + s4 + " " + ConvertNumeralsToArabic(prscNotes.Text);
            }
            else
            {
                lblArabic.Text =!string.IsNullOrEmpty(comboOften.Text )? ConvertNumeralsToArabic(s1) 
                    + " " + s2 + " " + s3 + " " + "لمدة " + ConvertNumeralsToArabic(txtDoes.Text) + " " + s4 + " " + ConvertNumeralsToArabic(prscNotes.Text) : s1 
                    + " " + s2 + " " + s3 + " " + "لمدة " + ConvertNumeralsToArabic(txtDoes.Text) + " " + s4 + " " + ConvertNumeralsToArabic(prscNotes.Text);
            }
        } 

        void eng()
        {
            if (string.IsNullOrEmpty(txtDoes.Text) || string.IsNullOrEmpty(comboDays.Text) || string.IsNullOrEmpty(prscNotes.Text))
            {
                lblEng.Text = x1 + " " + x2 + " " + x3 ;
            }
            else
            {
                lblEng.Text = x1 + " " + x2 + " " + x3 + " " + "for " + txtDoes.Text + " " + x4 + " " + prscNotes.Text ;
            }
        }

        void clearPrsc()
        {
            comboDrug.SelectedIndex = comboOften.SelectedIndex = comboDays.SelectedIndex
                = comboEvery.SelectedIndex = comboFood.SelectedIndex = -1;
            txtDoes.Text = "";
        }

        void clearall()
        {
            clearPrsc();
            gridPrsc.Rows.Clear();
            txtLabReq.Text = txtlife.Text = txtRadReq.Text = "";
            comboLab.SelectedIndex = comboRad.SelectedIndex = -1;
            dateFollow.Value = DateTime.Now;
        }

        void savePrsc()
        {
            for (int i = 0; i < gridPrsc.Rows.Count; i++)
            {
                db.InsertMangePlan(Convert.ToInt32(main.getmainform.txtId.Text),
                    Convert.ToInt32(gridPrsc.Rows[i].Cells[0].Value),
                    gridPrsc.Rows[i].Cells[2].Value.ToString(),
                    gridPrsc.Rows[i].Cells[3].Value.ToString());
            }
        }

        void saveAndUpdateVisit()
        {
            var v = Convert.ToInt32(main.getmainform.txtId.Text);
            var vis = db.vists.FirstOrDefault(i => i.visit_id == v);
            if (vis != null)
            {
                vis.followUpDate = dateFollow.Value;
                vis.lab_req = txtLabReq.Text.Trim();
                vis.radio_req = txtRadReq.Text.Trim();
                vis.lifeStyle = txtlife.Text.Trim();

                db.Entry(vis).State = EntityState.Modified;
                db.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Saved Successfully");

            }
        }

        private void btnRemovItem_Click(object sender, EventArgs e)
        {
            if (gridPrsc.Rows.Count == 0)
            {
                MessageBox.Show("there is no item to delete", "attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow item in gridPrsc.SelectedRows)
            {
                gridPrsc.Rows.Remove(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main.getmainform.txtId.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please chooe Patient to save vist");
            }
            else
            {
                savePrsc();
                saveAndUpdateVisit();
                btnPrintPrc.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void comboDrug_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ptID = Convert.ToInt32(main.getmainform.txtPtId.Text);
            if (string.IsNullOrEmpty(main.getmainform.txtPtId.Text))
            {
                comboDrug.SelectedIndex = -1;
            }
            else
            {
                var ptID = Convert.ToInt32(main.getmainform.txtPtId.Text);
                var drugId = Convert.ToInt32(comboDrug.SelectedValue);
                var drgCls = (from d in db.drugs
                              where d.drug_id == drugId
                              select d.FKclass_id).FirstOrDefault();

                var ptAllrg = db.allergies.FirstOrDefault(x => x.FKpt_id == ptID
                                                            && x.FKclass_id == drgCls);
                if (ptAllrg != null)
                {
                    MessageBox.Show("this Pt has Allergy anti this Drug");
                }
            }
            
        }

        private void prscNotes_TextChanged(object sender, EventArgs e)
        {
            arab();
            eng();

        }

        private void gridPrsc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridPrsc.CurrentRow.Index != 1)
                {
                    comboDrug.Text = gridPrsc.CurrentRow.Cells[1].Value.ToString();
                    lblEng.Text = gridPrsc.CurrentRow.Cells[2].Value.ToString();
                    lblArabic.Text = gridPrsc.CurrentRow.Cells[3].Value.ToString();
                    gridPrsc.Rows.RemoveAt(gridPrsc.CurrentRow.Index);
                    comboDrug.Focus();
                }
            }
            catch
            {

                return;
            }
            
        }

        private void management_Load(object sender, EventArgs e)
        {
            populateDrugs();
            populateLab();
            populateRad();
            populateClss();
            dateFollow.Value = DateTime.Now;
            
        }

        private void comboEvery_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboEvery.SelectedIndex)
            {
                case 0:
                    s2 = "فى اليوم";
                    x2 = "a day";
                    break;
                case 1:
                    s2 = "فى الأسبوع";
                    x2 = "a week";
                    break;
                case 2:
                    s2 = "فى الشهر";
                    x2 = "a month";
                    break;
                case 3:
                    s2 = "فى السنة";
                    x2 = "a year";
                    break;
                default:
                    break;
            }
            arab();
            eng();
        }
        enum MyEnum
        {
            sam,
                sam1,
                sam2

        }
        private void comboOften_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            switch (comboOften.SelectedIndex)
            {
               
                case 0:
                  
                    s1 = "مرة";
                    x1 = "Once";
                    break;
                case 1:
                    s1 = "مرتين";
                    x1 = "Twice";
                    break;
                case 2:
                    s1 = "ثلاث مرات";
                    x1 = "Three times";
                    break;
                case 3:
                    s1 = "أربع مرات";
                    x1 = "Four times";
                    break;
                case 4:
                    s1 = "خمس مرات";
                    x1 = "five times";
                    break;
                case 5:
                    s1 = "6 مرات";
                    x1 = "five times";
                    break;
                case 6:
                    s1 = "7 مرات";
                    x1 = "five times";
                    break;
                default:
                    break;
            }
            arab();
            eng();

        }

        private void comboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboFood.SelectedIndex)
            {
                case 0:
                    s3 = "قبل الأكل";
                    x3 = "before food"; 
                    break;
                case 1:
                    s3 = "بعد الأكل";
                    x3 = "after food";
                    break;
                case 2:
                    s3 = "مع الأكل";
                    x3 = "within food";
                    break;
                case 3:
                    s3 = "غير محدد";
                    x3 = "no regards";
                    break;
                default:
                    break;
            }
            arab();
            eng();
        }

        private void comboDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboDays.SelectedIndex)
            {
                case 0:
                    s4 = "أيام";
                    x4 = "days";
                    break;
                case 1:
                    s4 = "أسابيع";
                    x4 = "a week";
                    break;
                case 2:
                    s4 = "أشهر";
                    x4 = "a month";
                    break;
                case 3:
                    s4 = "سنوات";
                    x4 = "a year";
                    break;

                case 4:
                    s4 = "مدى الحياة";
                    x4 = "life time";
                    txtDoes.Text = "";
                    break;
                default:
                    break;
            }
            arab();
            eng();

        }

        private void txtDoes_TextChanged(object sender, EventArgs e)
        {
            arab();
            eng();
        }

       
    }
}
