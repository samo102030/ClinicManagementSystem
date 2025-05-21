namespace sliding_menue.user_controls
{
    partial class ROS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboSymp = new System.Windows.Forms.ComboBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRos = new MetroFramework.Controls.MetroTextBox();
            this.comboSys = new System.Windows.Forms.ComboBox();
            this.gridRos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddToGrid = new Bunifu.Framework.UI.BunifuImageButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSymp
            // 
            this.comboSymp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSymp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSymp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSymp.FormattingEnabled = true;
            this.comboSymp.Location = new System.Drawing.Point(300, 61);
            this.comboSymp.Name = "comboSymp";
            this.comboSymp.Size = new System.Drawing.Size(176, 28);
            this.comboSymp.TabIndex = 93;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(938, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 39);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSave.TabIndex = 98;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 20;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(482, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 26);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdd.TabIndex = 97;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 20;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(54, 92);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(89, 19);
            this.bunifuCustomLabel2.TabIndex = 95;
            this.bunifuCustomLabel2.Text = "Symptoms";
            // 
            // txtRos
            // 
            // 
            // 
            // 
            this.txtRos.CustomButton.Image = null;
            this.txtRos.CustomButton.Location = new System.Drawing.Point(692, 2);
            this.txtRos.CustomButton.Name = "";
            this.txtRos.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.txtRos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRos.CustomButton.TabIndex = 1;
            this.txtRos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRos.CustomButton.UseSelectable = true;
            this.txtRos.CustomButton.Visible = false;
            this.txtRos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRos.ForeColor = System.Drawing.Color.Black;
            this.txtRos.Lines = new string[0];
            this.txtRos.Location = new System.Drawing.Point(58, 117);
            this.txtRos.MaxLength = 32767;
            this.txtRos.Multiline = true;
            this.txtRos.Name = "txtRos";
            this.txtRos.PasswordChar = '\0';
            this.txtRos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRos.SelectedText = "";
            this.txtRos.SelectionLength = 0;
            this.txtRos.SelectionStart = 0;
            this.txtRos.ShortcutsEnabled = true;
            this.txtRos.Size = new System.Drawing.Size(818, 128);
            this.txtRos.TabIndex = 94;
            this.txtRos.UseCustomBackColor = true;
            this.txtRos.UseCustomForeColor = true;
            this.txtRos.UseSelectable = true;
            this.txtRos.UseStyleColors = true;
            this.txtRos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboSys
            // 
            this.comboSys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSys.FormattingEnabled = true;
            this.comboSys.Location = new System.Drawing.Point(58, 61);
            this.comboSys.Name = "comboSys";
            this.comboSys.Size = new System.Drawing.Size(176, 28);
            this.comboSys.TabIndex = 100;
            // 
            // gridRos
            // 
            this.gridRos.AllowUserToAddRows = false;
            this.gridRos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridRos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridRos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridRos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridRos.DoubleBuffered = true;
            this.gridRos.EnableHeadersVisualStyles = false;
            this.gridRos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.gridRos.HeaderForeColor = System.Drawing.Color.White;
            this.gridRos.Location = new System.Drawing.Point(58, 292);
            this.gridRos.Name = "gridRos";
            this.gridRos.ReadOnly = true;
            this.gridRos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridRos.Size = new System.Drawing.Size(818, 333);
            this.gridRos.TabIndex = 101;
            this.gridRos.DoubleClick += new System.EventHandler(this.gridRos_DoubleClick);
            // 
            // btnAddToGrid
            // 
            this.btnAddToGrid.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToGrid.Image")));
            this.btnAddToGrid.ImageActive = null;
            this.btnAddToGrid.Location = new System.Drawing.Point(482, 260);
            this.btnAddToGrid.Name = "btnAddToGrid";
            this.btnAddToGrid.Size = new System.Drawing.Size(28, 26);
            this.btnAddToGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddToGrid.TabIndex = 102;
            this.btnAddToGrid.TabStop = false;
            this.btnAddToGrid.Zoom = 20;
            this.btnAddToGrid.Click += new System.EventHandler(this.btnAddToGrid_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "System";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Symptoms";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAddToGrid);
            this.Controls.Add(this.gridRos);
            this.Controls.Add(this.comboSys);
            this.Controls.Add(this.comboSymp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtRos);
            this.Name = "ROS";
            this.Size = new System.Drawing.Size(997, 672);
            this.Load += new System.EventHandler(this.ROS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddToGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboSymp;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        public Bunifu.Framework.UI.BunifuImageButton btnAdd;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public MetroFramework.Controls.MetroTextBox txtRos;
        public System.Windows.Forms.ComboBox comboSys;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridRos;
        public Bunifu.Framework.UI.BunifuImageButton btnAddToGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
