namespace sliding_menue
{
    partial class add_classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_classes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.signhheader = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ADDPT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gridSys = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.sysid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signhheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSys)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.signhheader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // signhheader
            // 
            this.signhheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.signhheader.Controls.Add(this.logo);
            this.signhheader.Controls.Add(this.ADDPT);
            this.signhheader.Controls.Add(this.btnMini);
            this.signhheader.Controls.Add(this.btnClose);
            this.signhheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.signhheader.Location = new System.Drawing.Point(0, 0);
            this.signhheader.Name = "signhheader";
            this.signhheader.Size = new System.Drawing.Size(699, 50);
            this.signhheader.TabIndex = 78;
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
            this.ADDPT.Location = new System.Drawing.Point(279, 14);
            this.ADDPT.Name = "ADDPT";
            this.ADDPT.Size = new System.Drawing.Size(94, 19);
            this.ADDPT.TabIndex = 8;
            this.ADDPT.Text = "ADD CLASS";
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(621, 8);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 33);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 10;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 20;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(656, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 33);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnDelete.Enabled = false;
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
            this.btnDelete.Location = new System.Drawing.Point(131, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(121, 51);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(121, 51);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(395, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 42);
            this.txtSearch.TabIndex = 87;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
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
            this.btnSave.Location = new System.Drawing.Point(4, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(204)))), ((int)(((byte)(235)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(121, 51);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "  SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(62)))), ((int)(((byte)(89)))));
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridSys
            // 
            this.gridSys.AllowUserToAddRows = false;
            this.gridSys.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridSys.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridSys.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSys.BackgroundColor = System.Drawing.Color.White;
            this.gridSys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sysid,
            this.sysname});
            this.gridSys.DoubleBuffered = true;
            this.gridSys.EnableHeadersVisualStyles = false;
            this.gridSys.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gridSys.HeaderForeColor = System.Drawing.Color.White;
            this.gridSys.Location = new System.Drawing.Point(395, 116);
            this.gridSys.Name = "gridSys";
            this.gridSys.ReadOnly = true;
            this.gridSys.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSys.Size = new System.Drawing.Size(294, 297);
            this.gridSys.TabIndex = 79;
            this.gridSys.DoubleClick += new System.EventHandler(this.gridSys_DoubleClick);
            // 
            // sysid
            // 
            this.sysid.DataPropertyName = "id";
            this.sysid.HeaderText = "ID";
            this.sysid.Name = "sysid";
            this.sysid.ReadOnly = true;
            this.sysid.Width = 43;
            // 
            // sysname
            // 
            this.sysname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sysname.DataPropertyName = "name";
            this.sysname.HeaderText = "NAME";
            this.sysname.Name = "sysname";
            this.sysname.ReadOnly = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(111)))), ((int)(((byte)(34)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 118);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(21, 16);
            this.bunifuCustomLabel1.TabIndex = 80;
            this.bunifuCustomLabel1.Text = "ID";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.signhheader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
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
            this.txtName.Location = new System.Drawing.Point(30, 203);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 43);
            this.txtName.TabIndex = 83;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtId.Location = new System.Drawing.Point(30, 138);
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
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(34, 185);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(91, 16);
            this.bunifuCustomLabel10.TabIndex = 81;
            this.bunifuCustomLabel10.Text = "CLASS NAME";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(23, 185);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel9.TabIndex = 181;
            this.bunifuCustomLabel9.Text = "*";
            // 
            // add_classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 425);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridSys);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.signhheader);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_classes";
            this.Text = "add_classes";
            this.Load += new System.EventHandler(this.add_classes_Load);
            this.signhheader.ResumeLayout(false);
            this.signhheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel signhheader;
        private System.Windows.Forms.PictureBox logo;
        public Bunifu.Framework.UI.BunifuCustomLabel ADDPT;
        private Bunifu.Framework.UI.BunifuImageButton btnMini;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridSys;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtId;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
    }
}