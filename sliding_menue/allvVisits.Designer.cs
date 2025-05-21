namespace sliding_menue
{
    partial class allvVisits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allvVisits));
            this.gridVisits = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.RadBtnPtId = new MetroFramework.Controls.MetroRadioButton();
            this.RadBtnVisId = new MetroFramework.Controls.MetroRadioButton();
            this.RadBtnPtName = new MetroFramework.Controls.MetroRadioButton();
            this.RadBtnDate = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVisits
            // 
            this.gridVisits.AllowUserToAddRows = false;
            this.gridVisits.AllowUserToDeleteRows = false;
            this.gridVisits.AllowUserToResizeColumns = false;
            this.gridVisits.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridVisits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVisits.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridVisits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVisits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVisits.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridVisits.DoubleBuffered = true;
            this.gridVisits.EnableHeadersVisualStyles = false;
            this.gridVisits.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.gridVisits.HeaderForeColor = System.Drawing.Color.White;
            this.gridVisits.Location = new System.Drawing.Point(1, 93);
            this.gridVisits.Name = "gridVisits";
            this.gridVisits.ReadOnly = true;
            this.gridVisits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridVisits.Size = new System.Drawing.Size(564, 357);
            this.gridVisits.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "vDate";
            this.Column4.HeaderText = "visit date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "vId";
            this.Column3.HeaderText = "visit id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Pt ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Pt Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(295, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 42);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(21, 32);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 31);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "View Visit";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // RadBtnPtId
            // 
            this.RadBtnPtId.AutoSize = true;
            this.RadBtnPtId.Location = new System.Drawing.Point(295, 11);
            this.RadBtnPtId.Name = "RadBtnPtId";
            this.RadBtnPtId.Size = new System.Drawing.Size(50, 15);
            this.RadBtnPtId.TabIndex = 5;
            this.RadBtnPtId.Text = "PT ID";
            this.RadBtnPtId.UseSelectable = true;
            // 
            // RadBtnVisId
            // 
            this.RadBtnVisId.AutoSize = true;
            this.RadBtnVisId.Location = new System.Drawing.Point(352, 11);
            this.RadBtnVisId.Name = "RadBtnVisId";
            this.RadBtnVisId.Size = new System.Drawing.Size(59, 15);
            this.RadBtnVisId.TabIndex = 6;
            this.RadBtnVisId.Text = "Visit ID";
            this.RadBtnVisId.UseSelectable = true;
            // 
            // RadBtnPtName
            // 
            this.RadBtnPtName.AutoSize = true;
            this.RadBtnPtName.Location = new System.Drawing.Point(420, 12);
            this.RadBtnPtName.Name = "RadBtnPtName";
            this.RadBtnPtName.Size = new System.Drawing.Size(71, 15);
            this.RadBtnPtName.TabIndex = 7;
            this.RadBtnPtName.Text = "PT Name";
            this.RadBtnPtName.UseSelectable = true;
            // 
            // RadBtnDate
            // 
            this.RadBtnDate.AutoSize = true;
            this.RadBtnDate.Location = new System.Drawing.Point(494, 11);
            this.RadBtnDate.Name = "RadBtnDate";
            this.RadBtnDate.Size = new System.Drawing.Size(47, 15);
            this.RadBtnDate.TabIndex = 8;
            this.RadBtnDate.Text = "Date";
            this.RadBtnDate.UseSelectable = true;
            // 
            // allvVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 452);
            this.Controls.Add(this.RadBtnDate);
            this.Controls.Add(this.RadBtnPtName);
            this.Controls.Add(this.RadBtnVisId);
            this.Controls.Add(this.RadBtnPtId);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridVisits);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "allvVisits";
            this.Text = "allvVisits";
            this.Load += new System.EventHandler(this.allvVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid gridVisits;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MetroFramework.Controls.MetroRadioButton RadBtnPtId;
        private MetroFramework.Controls.MetroRadioButton RadBtnVisId;
        private MetroFramework.Controls.MetroRadioButton RadBtnPtName;
        private MetroFramework.Controls.MetroRadioButton RadBtnDate;
    }
}