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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierAtelierModal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbNomModif = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbModifCapacite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpDebut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpFin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelContainerModif = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.deleteAtelierBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewParticipants = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddParticipants = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReturnAt = new Bunifu.Framework.UI.BunifuImageButton();
            this.dtgThemeModif = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.validateModificationBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelContainerModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAtelierBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThemeModif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateModificationBtn)).BeginInit();
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
            this.txbNomModif.Location = new System.Drawing.Point(142, 17);
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
            this.txbModifCapacite.Location = new System.Drawing.Point(543, 17);
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
            this.dtpDebut.Location = new System.Drawing.Point(523, 92);
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
            this.dtpFin.Location = new System.Drawing.Point(523, 178);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(249, 53);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.Value = new System.DateTime(2019, 6, 3, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(429, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Capacité";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(89, 37);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Nom";
            // 
            // PanelContainerModif
            // 
            this.PanelContainerModif.Controls.Add(this.validateModificationBtn);
            this.PanelContainerModif.Controls.Add(this.bunifuCustomLabel3);
            this.PanelContainerModif.Controls.Add(this.deleteAtelierBtn);
            this.PanelContainerModif.Controls.Add(this.dataGridViewParticipants);
            this.PanelContainerModif.Controls.Add(this.btnAddParticipants);
            this.PanelContainerModif.Controls.Add(this.btnReturnAt);
            this.PanelContainerModif.Controls.Add(this.dtgThemeModif);
            this.PanelContainerModif.Controls.Add(this.bunifuCustomLabel1);
            this.PanelContainerModif.Controls.Add(this.txbNomModif);
            this.PanelContainerModif.Controls.Add(this.txbModifCapacite);
            this.PanelContainerModif.Controls.Add(this.bunifuCustomLabel2);
            this.PanelContainerModif.Controls.Add(this.dtpDebut);
            this.PanelContainerModif.Controls.Add(this.dtpFin);
            this.PanelContainerModif.Location = new System.Drawing.Point(0, 0);
            this.PanelContainerModif.Name = "PanelContainerModif";
            this.PanelContainerModif.Size = new System.Drawing.Size(1197, 660);
            this.PanelContainerModif.TabIndex = 7;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 92);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(59, 17);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Themes";
            // 
            // deleteAtelierBtn
            // 
            this.deleteAtelierBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteAtelierBtn.Image = global::Main.Properties.Resources.delete;
            this.deleteAtelierBtn.ImageActive = null;
            this.deleteAtelierBtn.Location = new System.Drawing.Point(925, 540);
            this.deleteAtelierBtn.Name = "deleteAtelierBtn";
            this.deleteAtelierBtn.Size = new System.Drawing.Size(71, 59);
            this.deleteAtelierBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteAtelierBtn.TabIndex = 13;
            this.deleteAtelierBtn.TabStop = false;
            this.deleteAtelierBtn.Zoom = 10;
            this.deleteAtelierBtn.Click += new System.EventHandler(this.DeleteAtelierBtn_Click);
            // 
            // dataGridViewParticipants
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.dataGridViewParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.DoubleBuffered = true;
            this.dataGridViewParticipants.EnableHeadersVisualStyles = false;
            this.dataGridViewParticipants.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewParticipants.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(0, 247);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(1142, 286);
            this.dataGridViewParticipants.TabIndex = 12;
            // 
            // btnAddParticipants
            // 
            this.btnAddParticipants.ActiveBorderThickness = 1;
            this.btnAddParticipants.ActiveCornerRadius = 20;
            this.btnAddParticipants.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddParticipants.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddParticipants.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddParticipants.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddParticipants.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddParticipants.BackgroundImage")));
            this.btnAddParticipants.ButtonText = "Ajouter un participant";
            this.btnAddParticipants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddParticipants.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParticipants.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddParticipants.IdleBorderThickness = 1;
            this.btnAddParticipants.IdleCornerRadius = 20;
            this.btnAddParticipants.IdleFillColor = System.Drawing.Color.White;
            this.btnAddParticipants.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddParticipants.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddParticipants.Location = new System.Drawing.Point(837, 92);
            this.btnAddParticipants.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddParticipants.Name = "btnAddParticipants";
            this.btnAddParticipants.Size = new System.Drawing.Size(181, 96);
            this.btnAddParticipants.TabIndex = 11;
            this.btnAddParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddParticipants.Click += new System.EventHandler(this.BtnAddParticipants_Click);
            // 
            // btnReturnAt
            // 
            this.btnReturnAt.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnAt.Image = global::Main.Properties.Resources._return;
            this.btnReturnAt.ImageActive = null;
            this.btnReturnAt.Location = new System.Drawing.Point(0, 0);
            this.btnReturnAt.Name = "btnReturnAt";
            this.btnReturnAt.Size = new System.Drawing.Size(66, 42);
            this.btnReturnAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturnAt.TabIndex = 10;
            this.btnReturnAt.TabStop = false;
            this.btnReturnAt.Zoom = 10;
            this.btnReturnAt.Click += new System.EventHandler(this.BtnReturnAt_Click);
            // 
            // dtgThemeModif
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgThemeModif.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgThemeModif.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgThemeModif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgThemeModif.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgThemeModif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgThemeModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThemeModif.DoubleBuffered = true;
            this.dtgThemeModif.EnableHeadersVisualStyles = false;
            this.dtgThemeModif.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgThemeModif.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgThemeModif.Location = new System.Drawing.Point(126, 92);
            this.dtgThemeModif.Name = "dtgThemeModif";
            this.dtgThemeModif.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgThemeModif.RowHeadersWidth = 51;
            this.dtgThemeModif.RowTemplate.Height = 24;
            this.dtgThemeModif.Size = new System.Drawing.Size(330, 139);
            this.dtgThemeModif.TabIndex = 8;
            // 
            // validateModificationBtn
            // 
            this.validateModificationBtn.BackColor = System.Drawing.Color.Transparent;
            this.validateModificationBtn.Image = global::Main.Properties.Resources.availableBooking;
            this.validateModificationBtn.ImageActive = null;
            this.validateModificationBtn.Location = new System.Drawing.Point(853, 540);
            this.validateModificationBtn.Name = "validateModificationBtn";
            this.validateModificationBtn.Size = new System.Drawing.Size(66, 59);
            this.validateModificationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.validateModificationBtn.TabIndex = 15;
            this.validateModificationBtn.TabStop = false;
            this.validateModificationBtn.Zoom = 10;
            this.validateModificationBtn.Click += new System.EventHandler(this.ValidateModificationBtn_Click);
            // 
            // ModifierAtelierModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContainerModif);
            this.Name = "ModifierAtelierModal";
            this.Size = new System.Drawing.Size(1142, 603);
            this.PanelContainerModif.ResumeLayout(false);
            this.PanelContainerModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAtelierBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThemeModif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validateModificationBtn)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgThemeModif;
        private Bunifu.Framework.UI.BunifuImageButton btnReturnAt;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddParticipants;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewParticipants;
        private Bunifu.Framework.UI.BunifuImageButton deleteAtelierBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton validateModificationBtn;
    }
}
