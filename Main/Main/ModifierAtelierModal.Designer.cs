namespace Main
{
    partial class ModifierAtelierModal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierAtelierModal));
            this.txbNomModif = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbModifCapacite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpDebut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelContainerModif = new System.Windows.Forms.Panel();
            this.dtgThemeModif = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnModifValid = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSupprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelContainerModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThemeModif)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNomModif
            // 
            this.txbNomModif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNomModif.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbNomModif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNomModif.HintForeColor = System.Drawing.Color.Empty;
            this.txbNomModif.HintText = "";
            this.txbNomModif.isPassword = false;
            this.txbNomModif.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbNomModif.LineIdleColor = System.Drawing.Color.Gray;
            this.txbNomModif.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbNomModif.LineThickness = 3;
            this.txbNomModif.Location = new System.Drawing.Point(74, 51);
            this.txbNomModif.Margin = new System.Windows.Forms.Padding(4);
            this.txbNomModif.Name = "txbNomModif";
            this.txbNomModif.Size = new System.Drawing.Size(229, 37);
            this.txbNomModif.TabIndex = 0;
            this.txbNomModif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbModifCapacite
            // 
            this.txbModifCapacite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbModifCapacite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbModifCapacite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbModifCapacite.HintForeColor = System.Drawing.Color.Empty;
            this.txbModifCapacite.HintText = "";
            this.txbModifCapacite.isPassword = false;
            this.txbModifCapacite.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbModifCapacite.LineIdleColor = System.Drawing.Color.Gray;
            this.txbModifCapacite.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbModifCapacite.LineThickness = 3;
            this.txbModifCapacite.Location = new System.Drawing.Point(475, 51);
            this.txbModifCapacite.Margin = new System.Windows.Forms.Padding(4);
            this.txbModifCapacite.Name = "txbModifCapacite";
            this.txbModifCapacite.Size = new System.Drawing.Size(229, 37);
            this.txbModifCapacite.TabIndex = 1;
            this.txbModifCapacite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpDebut
            // 
            this.dtpDebut.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpDebut.BorderRadius = 0;
            this.dtpDebut.ForeColor = System.Drawing.Color.White;
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDebut.FormatCustom = null;
            this.dtpDebut.Location = new System.Drawing.Point(74, 276);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(249, 53);
            this.dtpDebut.TabIndex = 2;
            this.dtpDebut.Value = new System.DateTime(2019, 6, 3, 1, 6, 11, 0);
            // 
            // dtpFin
            // 
            this.dtpFin.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFin.BorderRadius = 0;
            this.dtpFin.ForeColor = System.Drawing.Color.White;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.FormatCustom = "";
            this.dtpFin.Location = new System.Drawing.Point(400, 276);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(249, 53);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.Value = new System.DateTime(2019, 6, 3, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(361, 71);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Capacité";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 71);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Nom";
            // 
            // PanelContainerModif
            // 
            this.PanelContainerModif.Controls.Add(this.btnSupprimer);
            this.PanelContainerModif.Controls.Add(this.dtgThemeModif);
            this.PanelContainerModif.Controls.Add(this.btnModifValid);
            this.PanelContainerModif.Controls.Add(this.bunifuCustomLabel1);
            this.PanelContainerModif.Controls.Add(this.txbNomModif);
            this.PanelContainerModif.Controls.Add(this.txbModifCapacite);
            this.PanelContainerModif.Controls.Add(this.bunifuCustomLabel2);
            this.PanelContainerModif.Controls.Add(this.dtpDebut);
            this.PanelContainerModif.Controls.Add(this.dtpFin);
            this.PanelContainerModif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainerModif.Location = new System.Drawing.Point(0, 0);
            this.PanelContainerModif.Name = "PanelContainerModif";
            this.PanelContainerModif.Size = new System.Drawing.Size(1043, 536);
            this.PanelContainerModif.TabIndex = 7;
            // 
            // dtgThemeModif
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgThemeModif.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgThemeModif.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgThemeModif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgThemeModif.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgThemeModif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgThemeModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThemeModif.DoubleBuffered = true;
            this.dtgThemeModif.EnableHeadersVisualStyles = false;
            this.dtgThemeModif.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgThemeModif.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgThemeModif.Location = new System.Drawing.Point(163, 109);
            this.dtgThemeModif.Name = "dtgThemeModif";
            this.dtgThemeModif.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgThemeModif.RowTemplate.Height = 24;
            this.dtgThemeModif.Size = new System.Drawing.Size(426, 139);
            this.dtgThemeModif.TabIndex = 8;
            // 
            // btnModifValid
            // 
            this.btnModifValid.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModifValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModifValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifValid.BorderRadius = 0;
            this.btnModifValid.ButtonText = "Valider modification";
            this.btnModifValid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifValid.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifValid.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifValid.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifValid.Iconimage")));
            this.btnModifValid.Iconimage_right = null;
            this.btnModifValid.Iconimage_right_Selected = null;
            this.btnModifValid.Iconimage_Selected = null;
            this.btnModifValid.IconMarginLeft = 0;
            this.btnModifValid.IconMarginRight = 0;
            this.btnModifValid.IconRightVisible = true;
            this.btnModifValid.IconRightZoom = 0D;
            this.btnModifValid.IconVisible = true;
            this.btnModifValid.IconZoom = 90D;
            this.btnModifValid.IsTab = false;
            this.btnModifValid.Location = new System.Drawing.Point(57, 360);
            this.btnModifValid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifValid.Name = "btnModifValid";
            this.btnModifValid.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModifValid.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnModifValid.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifValid.selected = false;
            this.btnModifValid.Size = new System.Drawing.Size(321, 59);
            this.btnModifValid.TabIndex = 7;
            this.btnModifValid.Text = "Valider modification";
            this.btnModifValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifValid.Textcolor = System.Drawing.Color.White;
            this.btnModifValid.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifValid.Click += new System.EventHandler(this.btnModifValid_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.BorderRadius = 0;
            this.btnSupprimer.ButtonText = "supprimer";
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.DisabledColor = System.Drawing.Color.Gray;
            this.btnSupprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSupprimer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Iconimage")));
            this.btnSupprimer.Iconimage_right = null;
            this.btnSupprimer.Iconimage_right_Selected = null;
            this.btnSupprimer.Iconimage_Selected = null;
            this.btnSupprimer.IconMarginLeft = 0;
            this.btnSupprimer.IconMarginRight = 0;
            this.btnSupprimer.IconRightVisible = true;
            this.btnSupprimer.IconRightZoom = 0D;
            this.btnSupprimer.IconVisible = true;
            this.btnSupprimer.IconZoom = 90D;
            this.btnSupprimer.IsTab = false;
            this.btnSupprimer.Location = new System.Drawing.Point(438, 360);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSupprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSupprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSupprimer.selected = false;
            this.btnSupprimer.Size = new System.Drawing.Size(266, 59);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Textcolor = System.Drawing.Color.White;
            this.btnSupprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // ModifierAtelierModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContainerModif);
            this.Name = "ModifierAtelierModal";
            this.Size = new System.Drawing.Size(1043, 536);
            this.PanelContainerModif.ResumeLayout(false);
            this.PanelContainerModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThemeModif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txbNomModif;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbModifCapacite;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDebut;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel PanelContainerModif;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifValid;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgThemeModif;
        private Bunifu.Framework.UI.BunifuFlatButton btnSupprimer;
    }
}
