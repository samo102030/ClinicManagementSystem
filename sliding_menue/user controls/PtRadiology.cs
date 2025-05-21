using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;

namespace sliding_menue.user_controls
{
    public partial class PtRadiology : UserControl
    {
        clincEntities db = new clincEntities();
        public static user_controls.PtRadiology instance;
        public static user_controls.PtRadiology getinstance
        {
            get
            {
                if (instance == null)
                    instance = new user_controls.PtRadiology();
                return instance;
            }
        }
        public PtRadiology()
        {
            InitializeComponent();
        }

        void clearRad()
        {
            txtNotes.Text = "";
            imgRad.Image = null;
        }
        void populatecombo()
        {
            var symp = db.radiologies;
            comboRad.ValueMember = "radiology_id";
            comboRad.DisplayMember = "radio_name";
            comboRad.DataSource = symp.ToList();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image |*.JPG;*.JPEG;*.GIF;*.BMP;*.PNG;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgRad.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void radiology_Load(object sender, EventArgs e)
        {
            populatecombo();
            clearRad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var fkvisId = Convert.ToInt32(main.getmainform.txtId.Text);
            var fkradId = Convert.ToInt32(comboRad.SelectedValue);
            var rad =db.patient_radiology.FirstOrDefault(x=> x.FKvisit_id== fkvisId
                                                 && x.FKradio_id==fkradId);
            if (comboRad.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Radiology test Name");
            }
            else if (imgRad.Image == null)
            {
                MessageBox.Show("there is no images to save please choose one");
            }
            else if (rad!= null)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Radiology Already Exisit Are You Want To Update This Radiology?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    imgRad.Image.Save(ms, imgRad.Image.RawFormat);
                    byte[] Picture = ms.ToArray();
                    rad.FKvisit_id = Convert.ToInt32(main.getmainform.txtId.Text);
                    rad.FKradio_id = Convert.ToInt32(comboRad.SelectedValue);
                    rad.attchment = Picture;
                    rad.notes = txtNotes.Text.Trim();
                    db.Entry(rad).State = EntityState.Modified;
                        db.SaveChanges();
                    clearRad();
                }
                
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                imgRad.Image.Save(ms, imgRad.Image.RawFormat);
                byte[] Picture = ms.ToArray();
                db.InsertPatientRadio(Convert.ToInt32(main.getmainform.txtId.Text),
                    Convert.ToInt32(comboRad.SelectedValue), Picture, txtNotes.Text.Trim());
                clearRad();
            }
        }
    }
}
