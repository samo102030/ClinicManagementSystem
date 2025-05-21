namespace sliding_menue.user_controls
{
    partial class PtRadiology
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PtRadiology));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgRad = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboRad = new System.Windows.Forms.ComboBox();
            this.txtNotes = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(517, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(141, 20);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "PT RADIOLOGY";
            // 
            // imgRad
            // 
            this.imgRad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgRad.Location = new System.Drawing.Point(55, 115);
            this.imgRad.Name = "imgRad";
            this.imgRad.Size = new System.Drawing.Size(513, 367);
            this.imgRad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRad.TabIndex = 102;
            this.imgRad.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(55, 82);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 27);
            this.btnBrowse.TabIndex = 101;
            this.btnBrowse.Text = "Browse Radiology";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(935, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 39);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 123;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboRad
            // 
            this.comboRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRad.FormattingEnabled = true;
            this.comboRad.Location = new System.Drawing.Point(55, 42);
            this.comboRad.Name = "comboRad";
            this.comboRad.Size = new System.Drawing.Size(200, 28);
            this.comboRad.TabIndex = 124;
            // 
            // txtNotes
            // 
            // 
            // 
            // 
            this.txtNotes.CustomButton.Image = null;
            this.txtNotes.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtNotes.CustomButton.Name = "";
            this.txtNotes.CustomButton.Size = new System.Drawing.Size(157, 157);
            this.txtNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotes.CustomButton.TabIndex = 1;
            this.txtNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotes.CustomButton.UseSelectable = true;
            this.txtNotes.CustomButton.Visible = false;
            this.txtNotes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(574, 115);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(331, 159);
            this.txtNotes.TabIndex = 125;
            this.txtNotes.UseCustomBackColor = true;
            this.txtNotes.UseCustomForeColor = true;
            this.txtNotes.UseSelectable = true;
            this.txtNotes.UseStyleColors = true;
            this.txtNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PtRadiology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.comboRad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.imgRad);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "PtRadiology";
            this.Size = new System.Drawing.Size(997, 672);
            this.Load += new System.EventHandler(this.radiology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox imgRad;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private System.Windows.Forms.ComboBox comboRad;
        public MetroFramework.Controls.MetroTextBox txtNotes;
    }
}
