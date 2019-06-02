namespace Main
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.loginTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pwdTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitAuthBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // loginBtn
            // 
            this.loginBtn.ActiveBorderThickness = 1;
            this.loginBtn.ActiveCornerRadius = 20;
            this.loginBtn.ActiveFillColor = System.Drawing.Color.Purple;
            this.loginBtn.ActiveForecolor = System.Drawing.Color.DeepPink;
            this.loginBtn.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.ButtonText = "Se Connecter";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleCornerRadius = 20;
            this.loginBtn.IdleFillColor = System.Drawing.Color.DarkViolet;
            this.loginBtn.IdleForecolor = System.Drawing.Color.White;
            this.loginBtn.IdleLineColor = System.Drawing.Color.DarkViolet;
            this.loginBtn.Location = new System.Drawing.Point(74, 446);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(167, 41);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // loginTxtBox
            // 
            this.loginTxtBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.loginTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTxtBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.loginTxtBox.BorderThickness = 3;
            this.loginTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.loginTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTxtBox.isPassword = false;
            this.loginTxtBox.Location = new System.Drawing.Point(62, 164);
            this.loginTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTxtBox.Name = "loginTxtBox";
            this.loginTxtBox.Size = new System.Drawing.Size(370, 44);
            this.loginTxtBox.TabIndex = 1;
            this.loginTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pwdTxtBox
            // 
            this.pwdTxtBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.pwdTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwdTxtBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.pwdTxtBox.BorderThickness = 3;
            this.pwdTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwdTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwdTxtBox.isPassword = true;
            this.pwdTxtBox.Location = new System.Drawing.Point(62, 278);
            this.pwdTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwdTxtBox.Name = "pwdTxtBox";
            this.pwdTxtBox.Size = new System.Drawing.Size(370, 44);
            this.pwdTxtBox.TabIndex = 2;
            this.pwdTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 115);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 45);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(66, 229);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(274, 45);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Mot de passe";
            // 
            // exitAuthBtn
            // 
            this.exitAuthBtn.ActiveBorderThickness = 1;
            this.exitAuthBtn.ActiveCornerRadius = 20;
            this.exitAuthBtn.ActiveFillColor = System.Drawing.Color.Purple;
            this.exitAuthBtn.ActiveForecolor = System.Drawing.Color.DeepPink;
            this.exitAuthBtn.ActiveLineColor = System.Drawing.Color.DarkMagenta;
            this.exitAuthBtn.BackColor = System.Drawing.Color.White;
            this.exitAuthBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitAuthBtn.BackgroundImage")));
            this.exitAuthBtn.ButtonText = "Quitter";
            this.exitAuthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitAuthBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAuthBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.exitAuthBtn.IdleBorderThickness = 1;
            this.exitAuthBtn.IdleCornerRadius = 20;
            this.exitAuthBtn.IdleFillColor = System.Drawing.Color.DarkViolet;
            this.exitAuthBtn.IdleForecolor = System.Drawing.Color.White;
            this.exitAuthBtn.IdleLineColor = System.Drawing.Color.DarkViolet;
            this.exitAuthBtn.Location = new System.Drawing.Point(251, 446);
            this.exitAuthBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitAuthBtn.Name = "exitAuthBtn";
            this.exitAuthBtn.Size = new System.Drawing.Size(167, 41);
            this.exitAuthBtn.TabIndex = 5;
            this.exitAuthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitAuthBtn.Click += new System.EventHandler(this.ExitAuthBtn_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 550);
            this.Controls.Add(this.exitAuthBtn);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pwdTxtBox);
            this.Controls.Add(this.loginTxtBox);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox pwdTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox loginTxtBox;
        private Bunifu.Framework.UI.BunifuThinButton2 exitAuthBtn;
    }
}