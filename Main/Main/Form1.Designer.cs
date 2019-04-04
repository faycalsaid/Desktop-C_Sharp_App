namespace Main
{
    partial class mainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnHotels = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStands = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnParticipants = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAteliers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizeApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.m2lParticipants1 = new Main.m2lParticipants();
            this.m2lAteliers1 = new Main.m2lAteliers();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnHotels);
            this.bunifuGradientPanel1.Controls.Add(this.btnStands);
            this.bunifuGradientPanel1.Controls.Add(this.btnParticipants);
            this.bunifuGradientPanel1.Controls.Add(this.btnAteliers);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Azure;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 20);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(235, 433);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnHotels
            // 
            this.btnHotels.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHotels.BackColor = System.Drawing.Color.Transparent;
            this.btnHotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotels.BorderRadius = 0;
            this.btnHotels.ButtonText = " Hotels";
            this.btnHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotels.DisabledColor = System.Drawing.Color.Gray;
            this.btnHotels.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHotels.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHotels.Iconimage")));
            this.btnHotels.Iconimage_right = null;
            this.btnHotels.Iconimage_right_Selected = null;
            this.btnHotels.Iconimage_Selected = null;
            this.btnHotels.IconMarginLeft = 0;
            this.btnHotels.IconMarginRight = 0;
            this.btnHotels.IconRightVisible = true;
            this.btnHotels.IconRightZoom = 0D;
            this.btnHotels.IconVisible = true;
            this.btnHotels.IconZoom = 90D;
            this.btnHotels.IsTab = false;
            this.btnHotels.Location = new System.Drawing.Point(0, 226);
            this.btnHotels.Name = "btnHotels";
            this.btnHotels.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHotels.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHotels.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHotels.selected = false;
            this.btnHotels.Size = new System.Drawing.Size(235, 48);
            this.btnHotels.TabIndex = 3;
            this.btnHotels.Text = " Hotels";
            this.btnHotels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotels.Textcolor = System.Drawing.Color.White;
            this.btnHotels.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnStands
            // 
            this.btnStands.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStands.BackColor = System.Drawing.Color.Transparent;
            this.btnStands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStands.BorderRadius = 0;
            this.btnStands.ButtonText = "Stands";
            this.btnStands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStands.DisabledColor = System.Drawing.Color.Gray;
            this.btnStands.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStands.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStands.Iconimage")));
            this.btnStands.Iconimage_right = null;
            this.btnStands.Iconimage_right_Selected = null;
            this.btnStands.Iconimage_Selected = null;
            this.btnStands.IconMarginLeft = 0;
            this.btnStands.IconMarginRight = 0;
            this.btnStands.IconRightVisible = true;
            this.btnStands.IconRightZoom = 0D;
            this.btnStands.IconVisible = true;
            this.btnStands.IconZoom = 90D;
            this.btnStands.IsTab = false;
            this.btnStands.Location = new System.Drawing.Point(0, 172);
            this.btnStands.Name = "btnStands";
            this.btnStands.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStands.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStands.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStands.selected = false;
            this.btnStands.Size = new System.Drawing.Size(235, 48);
            this.btnStands.TabIndex = 2;
            this.btnStands.Text = "Stands";
            this.btnStands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStands.Textcolor = System.Drawing.Color.White;
            this.btnStands.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnParticipants
            // 
            this.btnParticipants.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnParticipants.BackColor = System.Drawing.Color.Transparent;
            this.btnParticipants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParticipants.BorderRadius = 0;
            this.btnParticipants.ButtonText = "Participants";
            this.btnParticipants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParticipants.DisabledColor = System.Drawing.Color.Gray;
            this.btnParticipants.Iconcolor = System.Drawing.Color.Transparent;
            this.btnParticipants.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnParticipants.Iconimage")));
            this.btnParticipants.Iconimage_right = null;
            this.btnParticipants.Iconimage_right_Selected = null;
            this.btnParticipants.Iconimage_Selected = null;
            this.btnParticipants.IconMarginLeft = 0;
            this.btnParticipants.IconMarginRight = 0;
            this.btnParticipants.IconRightVisible = true;
            this.btnParticipants.IconRightZoom = 0D;
            this.btnParticipants.IconVisible = true;
            this.btnParticipants.IconZoom = 90D;
            this.btnParticipants.IsTab = false;
            this.btnParticipants.Location = new System.Drawing.Point(0, 118);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Normalcolor = System.Drawing.Color.Transparent;
            this.btnParticipants.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnParticipants.OnHoverTextColor = System.Drawing.Color.White;
            this.btnParticipants.selected = false;
            this.btnParticipants.Size = new System.Drawing.Size(235, 48);
            this.btnParticipants.TabIndex = 1;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipants.Textcolor = System.Drawing.Color.White;
            this.btnParticipants.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnAteliers
            // 
            this.btnAteliers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAteliers.BackColor = System.Drawing.Color.Transparent;
            this.btnAteliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAteliers.BorderRadius = 0;
            this.btnAteliers.ButtonText = "Ateliers";
            this.btnAteliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAteliers.DisabledColor = System.Drawing.Color.Gray;
            this.btnAteliers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAteliers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAteliers.Iconimage")));
            this.btnAteliers.Iconimage_right = null;
            this.btnAteliers.Iconimage_right_Selected = null;
            this.btnAteliers.Iconimage_Selected = null;
            this.btnAteliers.IconMarginLeft = 0;
            this.btnAteliers.IconMarginRight = 0;
            this.btnAteliers.IconRightVisible = true;
            this.btnAteliers.IconRightZoom = 0D;
            this.btnAteliers.IconVisible = true;
            this.btnAteliers.IconZoom = 90D;
            this.btnAteliers.IsTab = false;
            this.btnAteliers.Location = new System.Drawing.Point(0, 64);
            this.btnAteliers.Name = "btnAteliers";
            this.btnAteliers.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAteliers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAteliers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAteliers.selected = false;
            this.btnAteliers.Size = new System.Drawing.Size(235, 48);
            this.btnAteliers.TabIndex = 0;
            this.btnAteliers.Text = "Ateliers";
            this.btnAteliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAteliers.Textcolor = System.Drawing.Color.White;
            this.btnAteliers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAteliers.Click += new System.EventHandler(this.btnAteliers_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimizeApp);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 20);
            this.panel1.TabIndex = 1;
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeApp.Image")));
            this.btnMinimizeApp.ImageActive = null;
            this.btnMinimizeApp.Location = new System.Drawing.Point(851, 0);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(24, 20);
            this.btnMinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeApp.TabIndex = 3;
            this.btnMinimizeApp.TabStop = false;
            this.btnMinimizeApp.Zoom = 10;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(881, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // m2lParticipants1
            // 
            this.m2lParticipants1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m2lParticipants1.Location = new System.Drawing.Point(235, 20);
            this.m2lParticipants1.Name = "m2lParticipants1";
            this.m2lParticipants1.Size = new System.Drawing.Size(673, 433);
            this.m2lParticipants1.TabIndex = 2;
            // 
            // m2lAteliers1
            // 
            this.m2lAteliers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m2lAteliers1.Location = new System.Drawing.Point(235, 20);
            this.m2lAteliers1.Name = "m2lAteliers1";
            this.m2lAteliers1.Size = new System.Drawing.Size(673, 433);
            this.m2lAteliers1.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 453);
            this.Controls.Add(this.m2lAteliers1);
            this.Controls.Add(this.m2lParticipants1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAteliers;
        private Bunifu.Framework.UI.BunifuFlatButton btnParticipants;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizeApp;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHotels;
        private Bunifu.Framework.UI.BunifuFlatButton btnStands;
        private m2lParticipants m2lParticipants1;
        private m2lAteliers m2lAteliers1;
    }
}

