namespace sliding_menue
{
    partial class add_score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_score));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ADDPT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.signhheader = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gridscr = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.signhheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridscr)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(396, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 42);
            this.txtSearch.TabIndex = 87;
            this.txtSearch.text = " SEARCH";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(681, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 111);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 16);
            this.bunifuCustomLabel1.TabIndex = 80;
            this.bunifuCustomLabel1.Text = "SCORE ID";
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
            this.ADDPT.Location = new System.Drawing.Point(309, 14);
            this.ADDPT.Name = "ADDPT";
            this.ADDPT.Size = new System.Drawing.Size(97, 19);
            this.ADDPT.TabIndex = 8;
            this.ADDPT.Text = "ADD SCORE";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(39, 193);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 43);
            this.txtName.TabIndex = 83;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(165)))), ((int)(((byte)(124)))));
            this.txtId.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtId.BorderThickness = 2;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.txtId.isPassword = false;
            this.txtId.Location = new System.Drawing.Point(39, 131);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 39);
            this.txtId.TabIndex = 82;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(43, 175);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(94, 16);
            this.bunifuCustomLabel10.TabIndex = 81;
            this.bunifuCustomLabel10.Text = "SCORE NAME";
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(716, 8);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(28, 33);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.signhheader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // signhheader
            // 
            this.signhheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.signhheader.Controls.Add(this.logo);
            this.signhheader.Controls.Add(this.ADDPT);
            this.signhheader.Controls.Add(this.bunifuImageButton1);
            this.signhheader.Controls.Add(this.bunifuImageButton3);
            this.signhheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.signhheader.Location = new System.Drawing.Point(0, 0);
            this.signhheader.Name = "signhheader";
            this.signhheader.Size = new System.Drawing.Size(759, 50);
            this.signhheader.TabIndex = 78;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.signhheader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "CANCEL";
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
            this.btnCancel.Location = new System.Drawing.Point(263, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(121, 51);
            this.btnCancel.TabIndex = 126;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(9, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(121, 51);
            this.btnSave.TabIndex = 128;
            this.btnSave.Text = "  SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(136, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(121, 51);
            this.btnDelete.TabIndex = 127;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridscr
            // 
            this.gridscr.AllowUserToAddRows = false;
            this.gridscr.AllowUserToDeleteRows = false;
            this.gridscr.AllowUserToResizeColumns = false;
            this.gridscr.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridscr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridscr.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridscr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridscr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridscr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridscr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridscr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridscr.DoubleBuffered = true;
            this.gridscr.EnableHeadersVisualStyles = false;
            this.gridscr.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridscr.HeaderForeColor = System.Drawing.Color.White;
            this.gridscr.Location = new System.Drawing.Point(396, 131);
            this.gridscr.Name = "gridscr";
            this.gridscr.ReadOnly = true;
            this.gridscr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridscr.Size = new System.Drawing.Size(355, 257);
            this.gridscr.TabIndex = 129;
            this.gridscr.DoubleClick += new System.EventHandler(this.gridscr_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "score_id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "score_name";
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // add_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 400);
            this.Controls.Add(this.gridscr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.signhheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_score";
            this.Load += new System.EventHandler(this.add_score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.signhheader.ResumeLayout(false);
            this.signhheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridscr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtId;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Panel signhheader;
        private System.Windows.Forms.PictureBox logo;
        public Bunifu.Framework.UI.BunifuCustomLabel ADDPT;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridscr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}