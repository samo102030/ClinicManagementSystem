namespace sliding_menue.user_controls
{
    partial class labtest
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labtest));
            this.GridPtLab = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLabTest = new MetroFramework.Controls.MetroDateTime();
            this.comboLabTest = new System.Windows.Forms.ComboBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtResault = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridPtLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPtLab
            // 
            this.GridPtLab.AllowUserToAddRows = false;
            this.GridPtLab.AllowUserToDeleteRows = false;
            this.GridPtLab.AllowUserToResizeColumns = false;
            this.GridPtLab.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridPtLab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPtLab.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridPtLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPtLab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPtLab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridPtLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPtLab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.GridPtLab.DoubleBuffered = true;
            this.GridPtLab.EnableHeadersVisualStyles = false;
            this.GridPtLab.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.GridPtLab.HeaderForeColor = System.Drawing.Color.White;
            this.GridPtLab.Location = new System.Drawing.Point(43, 112);
            this.GridPtLab.Name = "GridPtLab";
            this.GridPtLab.ReadOnly = true;
            this.GridPtLab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridPtLab.Size = new System.Drawing.Size(424, 348);
            this.GridPtLab.TabIndex = 1;
            this.GridPtLab.DoubleClick += new System.EventHandler(this.GridPtLab_DoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Test Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Test Resault";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // DateLabTest
            // 
            this.DateLabTest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateLabTest.Location = new System.Drawing.Point(521, 61);
            this.DateLabTest.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateLabTest.Name = "DateLabTest";
            this.DateLabTest.Size = new System.Drawing.Size(147, 29);
            this.DateLabTest.TabIndex = 5;
            // 
            // comboLabTest
            // 
            this.comboLabTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboLabTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboLabTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLabTest.FormattingEnabled = true;
            this.comboLabTest.Location = new System.Drawing.Point(43, 69);
            this.comboLabTest.Name = "comboLabTest";
            this.comboLabTest.Size = new System.Drawing.Size(180, 28);
            this.comboLabTest.TabIndex = 6;
            this.comboLabTest.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(937, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 39);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 92;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(445, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 26);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 91;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 20;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtResault
            // 
            // 
            // 
            // 
            this.txtResault.CustomButton.Image = null;
            this.txtResault.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtResault.CustomButton.Name = "";
            this.txtResault.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtResault.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResault.CustomButton.TabIndex = 1;
            this.txtResault.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResault.CustomButton.UseSelectable = true;
            this.txtResault.CustomButton.Visible = false;
            this.txtResault.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtResault.Lines = new string[0];
            this.txtResault.Location = new System.Drawing.Point(299, 69);
            this.txtResault.MaxLength = 32767;
            this.txtResault.Name = "txtResault";
            this.txtResault.PasswordChar = '\0';
            this.txtResault.PromptText = "insert testResault";
            this.txtResault.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResault.SelectedText = "";
            this.txtResault.SelectionLength = 0;
            this.txtResault.SelectionStart = 0;
            this.txtResault.ShortcutsEnabled = true;
            this.txtResault.Size = new System.Drawing.Size(140, 23);
            this.txtResault.TabIndex = 93;
            this.txtResault.UseSelectable = true;
            this.txtResault.WaterMark = "insert testResault";
            this.txtResault.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResault.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtResault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboLabTest);
            this.Controls.Add(this.DateLabTest);
            this.Controls.Add(this.GridPtLab);
            this.Name = "labtest";
            this.Size = new System.Drawing.Size(997, 672);
            this.Load += new System.EventHandler(this.labtest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPtLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomDataGrid GridPtLab;
        private MetroFramework.Controls.MetroDateTime DateLabTest;
        private System.Windows.Forms.ComboBox comboLabTest;
        public Bunifu.Framework.UI.BunifuImageButton btnSave;
        public Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtResault;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
