namespace sliding_menue
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkShpwd = new System.Windows.Forms.CheckBox();
            this.btnForgetPass = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUserPwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkShpwd);
            this.panel2.Controls.Add(this.btnForgetPass);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.txtUserPwd);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(576, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 501);
            this.panel2.TabIndex = 43;
            // 
            // chkShpwd
            // 
            this.chkShpwd.AutoSize = true;
            this.chkShpwd.Location = new System.Drawing.Point(53, 316);
            this.chkShpwd.Name = "chkShpwd";
            this.chkShpwd.Size = new System.Drawing.Size(101, 17);
            this.chkShpwd.TabIndex = 51;
            this.chkShpwd.Text = "Show password";
            this.chkShpwd.UseVisualStyleBackColor = true;
            this.chkShpwd.CheckedChanged += new System.EventHandler(this.chkShpwd_CheckedChanged);
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.btnForgetPass.Location = new System.Drawing.Point(255, 310);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(109, 23);
            this.btnForgetPass.TabIndex = 50;
            this.btnForgetPass.Text = "Forget Password";
            this.btnForgetPass.UseCustomBackColor = true;
            this.btnForgetPass.UseSelectable = true;
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(355, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 23);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 42;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(84, 409);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(266, 56);
            this.btnLogin.TabIndex = 48;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(47, 247);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(53, 13);
            this.bunifuCustomLabel2.TabIndex = 45;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 174);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 13);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "User Name";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserPwd.HintForeColor = System.Drawing.Color.Gray;
            this.txtUserPwd.HintText = "Password";
            this.txtUserPwd.isPassword = false;
            this.txtUserPwd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.txtUserPwd.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserPwd.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtUserPwd.LineThickness = 3;
            this.txtUserPwd.Location = new System.Drawing.Point(50, 270);
            this.txtUserPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(300, 33);
            this.txtUserPwd.TabIndex = 43;
            this.txtUserPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserPwd.OnValueChanged += new System.EventHandler(this.txtUserPwd_OnValueChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HintForeColor = System.Drawing.Color.Gray;
            this.txtUserName.HintText = "User Name";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.txtUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtUserName.LineThickness = 3;
            this.txtUserName.Location = new System.Drawing.Point(50, 194);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 33);
            this.txtUserName.TabIndex = 42;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 501);
            this.panel1.TabIndex = 44;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 35;
            this.bunifuElipse3.TargetControl = this.panel2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserPwd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroLink btnForgetPass;
        private System.Windows.Forms.CheckBox chkShpwd;
    }
}