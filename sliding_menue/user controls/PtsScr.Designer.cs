namespace sliding_menue.user_controls
{
    partial class PtsScr
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
       [System.Obsolete] /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PtsScr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtResault = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboScores = new System.Windows.Forms.ComboBox();
            this.GridPtScore = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPtScore)).BeginInit();
            this.SuspendLayout();
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
            this.txtResault.Location = new System.Drawing.Point(306, 59);
            this.txtResault.MaxLength = 32767;
            this.txtResault.Name = "txtResault";
            this.txtResault.PasswordChar = '\0';
            this.txtResault.PromptText = "insert ScoreResault";
            this.txtResault.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResault.SelectedText = "";
            this.txtResault.SelectionLength = 0;
            this.txtResault.SelectionStart = 0;
            this.txtResault.ShortcutsEnabled = true;
            this.txtResault.Size = new System.Drawing.Size(140, 23);
            this.txtResault.TabIndex = 98;
            this.txtResault.UseSelectable = true;
            this.txtResault.WaterMark = "insert ScoreResault";
            this.txtResault.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResault.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(944, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 39);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 97;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(452, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 26);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 96;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 20;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboScores
            // 
            this.comboScores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboScores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboScores.FormattingEnabled = true;
            this.comboScores.Location = new System.Drawing.Point(50, 59);
            this.comboScores.Name = "comboScores";
            this.comboScores.Size = new System.Drawing.Size(180, 28);
            this.comboScores.TabIndex = 95;
            // 
            // GridPtScore
            // 
            this.GridPtScore.AllowUserToAddRows = false;
            this.GridPtScore.AllowUserToDeleteRows = false;
            this.GridPtScore.AllowUserToResizeColumns = false;
            this.GridPtScore.AllowUserToResizeRows = false;
            this.GridPtScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(218)))), ((int)(((byte)(225)))));
            this.GridPtScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridPtScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPtScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPtScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPtScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPtScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPtScore.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPtScore.EnableHeadersVisualStyles = false;
            this.GridPtScore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPtScore.GridColor = System.Drawing.Color.White;
            this.GridPtScore.Location = new System.Drawing.Point(50, 94);
            this.GridPtScore.MultiSelect = false;
            this.GridPtScore.Name = "GridPtScore";
            this.GridPtScore.ReadOnly = true;
            this.GridPtScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPtScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridPtScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GridPtScore.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridPtScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPtScore.Size = new System.Drawing.Size(396, 296);
            this.GridPtScore.TabIndex = 99;
            this.GridPtScore.UseCustomBackColor = true;
            this.GridPtScore.UseCustomForeColor = true;
            this.GridPtScore.UseStyleColors = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Score Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Resault";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // PtsScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GridPtScore);
            this.Controls.Add(this.txtResault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboScores);
            this.Name = "PtsScr";
            this.Size = new System.Drawing.Size(997, 672);
            this.Load += new System.EventHandler(this.PtsScr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPtScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtResault;
        public Bunifu.Framework.UI.BunifuImageButton btnSave;
        public Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.ComboBox comboScores;
        private MetroFramework.Controls.MetroGrid GridPtScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
