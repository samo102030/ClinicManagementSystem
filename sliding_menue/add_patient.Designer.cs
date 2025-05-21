namespace sliding_menue
{
    partial class add_patient
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_patient));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.ADDPT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.comboGender = new MetroFramework.Controls.MetroComboBox();
            this.comboBlood = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboStates = new MetroFramework.Controls.MetroComboBox();
            this.dob = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtNotes = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtjob = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtmob = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtaddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.gridPt = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnStartVist = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPt)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(136, 43);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // ADDPT
            // 
            this.ADDPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ADDPT.AutoSize = true;
            this.ADDPT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.ADDPT.Location = new System.Drawing.Point(413, 14);
            this.ADDPT.Name = "ADDPT";
            this.ADDPT.Size = new System.Drawing.Size(144, 19);
            this.ADDPT.TabIndex = 8;
            this.ADDPT.Text = "ADD NEW PATIENT";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.header.Controls.Add(this.logo);
            this.header.Controls.Add(this.ADDPT);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuImageButton3);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1017, 50);
            this.header.TabIndex = 32;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(939, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(974, 8);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(28, 33);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.White;
            this.comboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 23;
            this.comboGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboGender.Location = new System.Drawing.Point(116, 186);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(165, 29);
            this.comboGender.TabIndex = 71;
            this.comboGender.UseCustomBackColor = true;
            this.comboGender.UseCustomForeColor = true;
            this.comboGender.UseSelectable = true;
            this.comboGender.UseStyleColors = true;
            // 
            // comboBlood
            // 
            this.comboBlood.BackColor = System.Drawing.Color.White;
            this.comboBlood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.comboBlood.FormattingEnabled = true;
            this.comboBlood.ItemHeight = 23;
            this.comboBlood.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.comboBlood.Location = new System.Drawing.Point(116, 378);
            this.comboBlood.Name = "comboBlood";
            this.comboBlood.Size = new System.Drawing.Size(84, 29);
            this.comboBlood.TabIndex = 70;
            this.comboBlood.UseCustomBackColor = true;
            this.comboBlood.UseCustomForeColor = true;
            this.comboBlood.UseSelectable = true;
            this.comboBlood.UseStyleColors = true;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "  SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 130D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(17, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(138, 51);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "  SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(347, 146);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(36, 16);
            this.bunifuCustomLabel11.TabIndex = 69;
            this.bunifuCustomLabel11.Text = "AGE";
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.White;
            this.txtage.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtage.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtage.BorderThickness = 1;
            this.txtage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtage.Enabled = false;
            this.txtage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtage.isPassword = false;
            this.txtage.Location = new System.Drawing.Point(384, 145);
            this.txtage.Margin = new System.Windows.Forms.Padding(4);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(58, 33);
            this.txtage.TabIndex = 68;
            this.txtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboStates
            // 
            this.comboStates.BackColor = System.Drawing.Color.White;
            this.comboStates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.comboStates.FormattingEnabled = true;
            this.comboStates.ItemHeight = 23;
            this.comboStates.Items.AddRange(new object[] {
            "Singel",
            "Married",
            "Divorced",
            "Widow"});
            this.comboStates.Location = new System.Drawing.Point(116, 260);
            this.comboStates.Name = "comboStates";
            this.comboStates.Size = new System.Drawing.Size(165, 29);
            this.comboStates.TabIndex = 67;
            this.comboStates.UseCustomBackColor = true;
            this.comboStates.UseCustomForeColor = true;
            this.comboStates.UseSelectable = true;
            this.comboStates.UseStyleColors = true;
            // 
            // dob
            // 
            this.dob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.dob.BorderRadius = 0;
            this.dob.ForeColor = System.Drawing.Color.White;
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.FormatCustom = null;
            this.dob.Location = new System.Drawing.Point(116, 145);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(222, 36);
            this.dob.TabIndex = 66;
            this.dob.Value = new System.DateTime(2018, 1, 25, 15, 34, 22, 141);
            this.dob.onValueChanged += new System.EventHandler(this.dob_onValueChanged_1);
            // 
            // txtNotes
            // 
            // 
            // 
            // 
            this.txtNotes.CustomButton.Image = null;
            this.txtNotes.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.txtNotes.CustomButton.Name = "";
            this.txtNotes.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotes.CustomButton.TabIndex = 1;
            this.txtNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotes.CustomButton.UseSelectable = true;
            this.txtNotes.CustomButton.Visible = false;
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(116, 413);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(244, 76);
            this.txtNotes.TabIndex = 64;
            this.txtNotes.UseCustomBackColor = true;
            this.txtNotes.UseCustomForeColor = true;
            this.txtNotes.UseSelectable = true;
            this.txtNotes.UseStyleColors = true;
            this.txtNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(76, 67);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(38, 16);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "PT ID";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(81, 220);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(33, 16);
            this.bunifuCustomLabel7.TabIndex = 55;
            this.bunifuCustomLabel7.Text = "JOB";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(62, 260);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(52, 16);
            this.bunifuCustomLabel6.TabIndex = 54;
            this.bunifuCustomLabel6.Text = "STATUS";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtName.BorderThickness = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(116, 106);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 33);
            this.txtName.TabIndex = 60;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(49, 295);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(65, 16);
            this.bunifuCustomLabel5.TabIndex = 53;
            this.bunifuCustomLabel5.Text = "ADDRESS";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(54, 192);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(60, 16);
            this.bunifuCustomLabel8.TabIndex = 56;
            this.bunifuCustomLabel8.Text = "GENDER";
            // 
            // txtjob
            // 
            this.txtjob.BackColor = System.Drawing.Color.White;
            this.txtjob.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtjob.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtjob.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtjob.BorderThickness = 1;
            this.txtjob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjob.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtjob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtjob.isPassword = false;
            this.txtjob.Location = new System.Drawing.Point(116, 220);
            this.txtjob.Margin = new System.Windows.Forms.Padding(4);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(244, 33);
            this.txtjob.TabIndex = 61;
            this.txtjob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(58, 336);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(56, 16);
            this.bunifuCustomLabel4.TabIndex = 52;
            this.bunifuCustomLabel4.Text = "MOBILE";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(14, 146);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(100, 16);
            this.bunifuCustomLabel9.TabIndex = 57;
            this.bunifuCustomLabel9.Text = "DATE OF BIRTH";
            // 
            // txtmob
            // 
            this.txtmob.BackColor = System.Drawing.Color.White;
            this.txtmob.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtmob.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtmob.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtmob.BorderThickness = 1;
            this.txtmob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmob.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtmob.isPassword = false;
            this.txtmob.Location = new System.Drawing.Point(116, 336);
            this.txtmob.Margin = new System.Windows.Forms.Padding(4);
            this.txtmob.Name = "txtmob";
            this.txtmob.Size = new System.Drawing.Size(244, 36);
            this.txtmob.TabIndex = 63;
            this.txtmob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 378);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 16);
            this.bunifuCustomLabel3.TabIndex = 51;
            this.bunifuCustomLabel3.Text = "BLOOD TYPE";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtId.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtId.BorderThickness = 1;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtId.isPassword = false;
            this.txtId.Location = new System.Drawing.Point(116, 67);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(108, 33);
            this.txtId.TabIndex = 59;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(13, 106);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(101, 16);
            this.bunifuCustomLabel10.TabIndex = 58;
            this.bunifuCustomLabel10.Text = "PATIENT NAME";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(65, 413);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(49, 16);
            this.bunifuCustomLabel2.TabIndex = 50;
            this.bunifuCustomLabel2.Text = "NOTES";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtaddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtaddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtaddress.BorderThickness = 1;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtaddress.isPassword = false;
            this.txtaddress.Location = new System.Drawing.Point(116, 295);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(244, 33);
            this.txtaddress.TabIndex = 62;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gridPt
            // 
            this.gridPt.AllowUserToAddRows = false;
            this.gridPt.AllowUserToDeleteRows = false;
            this.gridPt.AllowUserToResizeColumns = false;
            this.gridPt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridPt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPt.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridPt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9});
            this.gridPt.DoubleBuffered = true;
            this.gridPt.EnableHeadersVisualStyles = false;
            this.gridPt.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridPt.HeaderForeColor = System.Drawing.Color.White;
            this.gridPt.Location = new System.Drawing.Point(479, 167);
            this.gridPt.Name = "gridPt";
            this.gridPt.ReadOnly = true;
            this.gridPt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPt.Size = new System.Drawing.Size(531, 379);
            this.gridPt.TabIndex = 72;
            this.gridPt.DoubleClick += new System.EventHandler(this.gridPt_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pt_id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "pt_name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dob";
            this.Column3.HeaderText = "Date Of Birth";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "job";
            this.Column5.HeaderText = "Job";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gender";
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "marital_status";
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "address";
            this.Column7.HeaderText = "Address";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "mobile";
            this.Column10.HeaderText = "Mobile";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "blood_type";
            this.Column8.HeaderText = "Blood Type";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "notes";
            this.Column9.HeaderText = "Notes";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 130D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(314, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(121, 51);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 130D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(174, 495);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(121, 51);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(479, 106);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 42);
            this.txtSearch.TabIndex = 88;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // btnStartVist
            // 
            this.btnStartVist.Location = new System.Drawing.Point(893, 60);
            this.btnStartVist.Name = "btnStartVist";
            this.btnStartVist.Size = new System.Drawing.Size(117, 23);
            this.btnStartVist.TabIndex = 89;
            this.btnStartVist.Text = "Start Vist";
            this.btnStartVist.UseCustomBackColor = true;
            this.btnStartVist.UseCustomForeColor = true;
            this.btnStartVist.UseSelectable = true;
            this.btnStartVist.UseStyleColors = true;
            this.btnStartVist.Click += new System.EventHandler(this.btnStartVist_Click);
            // 
            // add_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 558);
            this.Controls.Add(this.btnStartVist);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gridPt);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.comboBlood);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.comboStates);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.txtmob);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_patient";
            this.Load += new System.EventHandler(this.add_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox logo;
        public Bunifu.Framework.UI.BunifuCustomLabel ADDPT;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private MetroFramework.Controls.MetroComboBox comboGender;
        private MetroFramework.Controls.MetroComboBox comboBlood;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtage;
        private MetroFramework.Controls.MetroComboBox comboStates;
        private Bunifu.Framework.UI.BunifuDatepicker dob;
        private MetroFramework.Controls.MetroTextBox txtNotes;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtjob;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmob;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtId;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtaddress;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridPt;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private MetroFramework.Controls.MetroButton btnStartVist;
    }
}