namespace Main
{
    partial class AjouterAtelier
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterAtelier));
            this.btnAjoutValid = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txbNomAjouter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbCapaciteAjouter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpdebutAjouter = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpFinAjouter = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btnAjoutValid
            // 
            this.btnAjoutValid.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAjoutValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAjoutValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjoutValid.BorderRadius = 0;
            this.btnAjoutValid.ButtonText = "Ajouter l\'atelier";
            this.btnAjoutValid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutValid.DisabledColor = System.Drawing.Color.Gray;
            this.btnAjoutValid.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAjoutValid.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAjoutValid.Iconimage")));
            this.btnAjoutValid.Iconimage_right = null;
            this.btnAjoutValid.Iconimage_right_Selected = null;
            this.btnAjoutValid.Iconimage_Selected = null;
            this.btnAjoutValid.IconMarginLeft = 0;
            this.btnAjoutValid.IconMarginRight = 0;
            this.btnAjoutValid.IconRightVisible = true;
            this.btnAjoutValid.IconRightZoom = 0D;
            this.btnAjoutValid.IconVisible = true;
            this.btnAjoutValid.IconZoom = 90D;
            this.btnAjoutValid.IsTab = false;
            this.btnAjoutValid.Location = new System.Drawing.Point(281, 367);
            this.btnAjoutValid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjoutValid.Name = "btnAjoutValid";
            this.btnAjoutValid.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAjoutValid.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAjoutValid.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAjoutValid.selected = false;
            this.btnAjoutValid.Size = new System.Drawing.Size(321, 59);
            this.btnAjoutValid.TabIndex = 13;
            this.btnAjoutValid.Text = "Ajouter l\'atelier";
            this.btnAjoutValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjoutValid.Textcolor = System.Drawing.Color.White;
            this.btnAjoutValid.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutValid.Click += new System.EventHandler(this.btnAjoutValid_Click_1);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(397, 79);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Capacité";
            // 
            // txbNomAjouter
            // 
            this.txbNomAjouter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNomAjouter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbNomAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNomAjouter.HintForeColor = System.Drawing.Color.Empty;
            this.txbNomAjouter.HintText = "";
            this.txbNomAjouter.isPassword = false;
            this.txbNomAjouter.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbNomAjouter.LineIdleColor = System.Drawing.Color.Gray;
            this.txbNomAjouter.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbNomAjouter.LineThickness = 3;
            this.txbNomAjouter.Location = new System.Drawing.Point(130, 59);
            this.txbNomAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.txbNomAjouter.Name = "txbNomAjouter";
            this.txbNomAjouter.Size = new System.Drawing.Size(229, 37);
            this.txbNomAjouter.TabIndex = 8;
            this.txbNomAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbCapaciteAjouter
            // 
            this.txbCapaciteAjouter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCapaciteAjouter.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbCapaciteAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCapaciteAjouter.HintForeColor = System.Drawing.Color.Empty;
            this.txbCapaciteAjouter.HintText = "";
            this.txbCapaciteAjouter.isPassword = false;
            this.txbCapaciteAjouter.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbCapaciteAjouter.LineIdleColor = System.Drawing.Color.Gray;
            this.txbCapaciteAjouter.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbCapaciteAjouter.LineThickness = 3;
            this.txbCapaciteAjouter.Location = new System.Drawing.Point(511, 59);
            this.txbCapaciteAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.txbCapaciteAjouter.Name = "txbCapaciteAjouter";
            this.txbCapaciteAjouter.Size = new System.Drawing.Size(229, 37);
            this.txbCapaciteAjouter.TabIndex = 9;
            this.txbCapaciteAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpdebutAjouter
            // 
            this.dtpdebutAjouter.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpdebutAjouter.BorderRadius = 0;
            this.dtpdebutAjouter.ForeColor = System.Drawing.Color.White;
            this.dtpdebutAjouter.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpdebutAjouter.FormatCustom = "yyy-MM-dd";
            this.dtpdebutAjouter.Location = new System.Drawing.Point(130, 263);
            this.dtpdebutAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpdebutAjouter.Name = "dtpdebutAjouter";
            this.dtpdebutAjouter.Size = new System.Drawing.Size(249, 53);
            this.dtpdebutAjouter.TabIndex = 10;
            this.dtpdebutAjouter.Value = new System.DateTime(2019, 5, 31, 15, 34, 15, 978);
            // 
            // dtpFinAjouter
            // 
            this.dtpFinAjouter.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFinAjouter.BorderRadius = 0;
            this.dtpFinAjouter.ForeColor = System.Drawing.Color.White;
            this.dtpFinAjouter.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFinAjouter.FormatCustom = "yyyy-MM-dd";
            this.dtpFinAjouter.Location = new System.Drawing.Point(442, 263);
            this.dtpFinAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFinAjouter.Name = "dtpFinAjouter";
            this.dtpFinAjouter.Size = new System.Drawing.Size(249, 53);
            this.dtpFinAjouter.TabIndex = 11;
            this.dtpFinAjouter.Value = new System.DateTime(2019, 5, 31, 15, 34, 15, 978);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 79);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Nom";
            // 
            // AjouterAtelier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnAjoutValid);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txbNomAjouter);
            this.Controls.Add(this.txbCapaciteAjouter);
            this.Controls.Add(this.dtpdebutAjouter);
            this.Controls.Add(this.dtpFinAjouter);
            this.Name = "AjouterAtelier";
            this.Size = new System.Drawing.Size(870, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAjoutValid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbNomAjouter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbCapaciteAjouter;
        private Bunifu.Framework.UI.BunifuDatepicker dtpdebutAjouter;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFinAjouter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}
