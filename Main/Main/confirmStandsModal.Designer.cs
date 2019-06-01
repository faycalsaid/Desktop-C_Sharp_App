using System.Windows.Forms;

namespace Main
{
    partial class confirmStandsModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmStandsModal));
            this.areaTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.localisationTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cBoxPartners = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // areaTxtBox
            // 
            this.areaTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.areaTxtBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.areaTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.areaTxtBox.HintText = "";
            this.areaTxtBox.isPassword = false;
            this.areaTxtBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.areaTxtBox.LineIdleColor = System.Drawing.Color.Gray;
            this.areaTxtBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.areaTxtBox.LineThickness = 6;
            this.areaTxtBox.Location = new System.Drawing.Point(298, 177);
            this.areaTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.areaTxtBox.Name = "areaTxtBox";
            this.areaTxtBox.Size = new System.Drawing.Size(106, 46);
            this.areaTxtBox.TabIndex = 1;
            this.areaTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // localisationTxtBox
            // 
            this.localisationTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.localisationTxtBox.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localisationTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.localisationTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.localisationTxtBox.HintText = "";
            this.localisationTxtBox.isPassword = false;
            this.localisationTxtBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.localisationTxtBox.LineIdleColor = System.Drawing.Color.Gray;
            this.localisationTxtBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.localisationTxtBox.LineThickness = 6;
            this.localisationTxtBox.Location = new System.Drawing.Point(298, 87);
            this.localisationTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.localisationTxtBox.Name = "localisationTxtBox";
            this.localisationTxtBox.Size = new System.Drawing.Size(106, 46);
            this.localisationTxtBox.TabIndex = 0;
            this.localisationTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.GhostWhite;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ThinButton";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(617, 379);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // cBoxPartners
            // 
            this.cBoxPartners.FormattingEnabled = true;
            this.cBoxPartners.Location = new System.Drawing.Point(617, 109);
            this.cBoxPartners.Name = "cBoxPartners";
            this.cBoxPartners.Size = new System.Drawing.Size(181, 24);
            this.cBoxPartners.TabIndex = 4;
            // 
            // confirmStandsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.cBoxPartners);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.areaTxtBox);
            this.Controls.Add(this.localisationTxtBox);
            this.Name = "confirmStandsModal";
            this.Size = new System.Drawing.Size(842, 548);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox areaTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox localisationTxtBox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private ComboBox cBoxPartners;
    }
}
