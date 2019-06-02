using System.Windows.Forms;

namespace Main
{
    partial class standAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(standAllocation));
            this.attributeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cBoxPartners = new System.Windows.Forms.ComboBox();
            this.mtrlLabelLoc = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelLocalisation = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelAr = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelArea = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelPart = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelCit = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelPartner = new MaterialSkin.Controls.MaterialLabel();
            this.mtrlLabelCity = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // attributeButton
            // 
            this.attributeButton.ActiveBorderThickness = 1;
            this.attributeButton.ActiveCornerRadius = 20;
            this.attributeButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.attributeButton.ActiveForecolor = System.Drawing.Color.White;
            this.attributeButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.attributeButton.BackColor = System.Drawing.Color.GhostWhite;
            this.attributeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attributeButton.BackgroundImage")));
            this.attributeButton.ButtonText = "Attribuer";
            this.attributeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attributeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributeButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.attributeButton.IdleBorderThickness = 1;
            this.attributeButton.IdleCornerRadius = 20;
            this.attributeButton.IdleFillColor = System.Drawing.Color.White;
            this.attributeButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.attributeButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.attributeButton.Location = new System.Drawing.Point(617, 379);
            this.attributeButton.Margin = new System.Windows.Forms.Padding(5);
            this.attributeButton.Name = "attributeButton";
            this.attributeButton.Size = new System.Drawing.Size(181, 41);
            this.attributeButton.TabIndex = 3;
            this.attributeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attributeButton.Click += new System.EventHandler(this.AttributeButton_Click);
            // 
            // cBoxPartners
            // 
            this.cBoxPartners.FormattingEnabled = true;
            this.cBoxPartners.Location = new System.Drawing.Point(617, 109);
            this.cBoxPartners.Name = "cBoxPartners";
            this.cBoxPartners.Size = new System.Drawing.Size(181, 24);
            this.cBoxPartners.TabIndex = 4;
            this.cBoxPartners.SelectedValueChanged += new System.EventHandler(this.CBoxPartners_SelectedValueChanged);
            // 
            // mtrlLabelLoc
            // 
            this.mtrlLabelLoc.AutoSize = true;
            this.mtrlLabelLoc.Depth = 0;
            this.mtrlLabelLoc.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelLoc.Location = new System.Drawing.Point(96, 107);
            this.mtrlLabelLoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelLoc.Name = "mtrlLabelLoc";
            this.mtrlLabelLoc.Size = new System.Drawing.Size(113, 24);
            this.mtrlLabelLoc.TabIndex = 6;
            this.mtrlLabelLoc.Text = "Localisation";
            // 
            // mtrlLabelLocalisation
            // 
            this.mtrlLabelLocalisation.AutoSize = true;
            this.mtrlLabelLocalisation.Depth = 0;
            this.mtrlLabelLocalisation.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelLocalisation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelLocalisation.Location = new System.Drawing.Point(248, 107);
            this.mtrlLabelLocalisation.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelLocalisation.Name = "mtrlLabelLocalisation";
            this.mtrlLabelLocalisation.Size = new System.Drawing.Size(38, 24);
            this.mtrlLabelLocalisation.TabIndex = 7;
            this.mtrlLabelLocalisation.Text = "m2";
            // 
            // mtrlLabelAr
            // 
            this.mtrlLabelAr.AutoSize = true;
            this.mtrlLabelAr.Depth = 0;
            this.mtrlLabelAr.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelAr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelAr.Location = new System.Drawing.Point(96, 161);
            this.mtrlLabelAr.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelAr.Name = "mtrlLabelAr";
            this.mtrlLabelAr.Size = new System.Drawing.Size(74, 24);
            this.mtrlLabelAr.TabIndex = 8;
            this.mtrlLabelAr.Text = "Surface";
            // 
            // mtrlLabelArea
            // 
            this.mtrlLabelArea.AutoSize = true;
            this.mtrlLabelArea.Depth = 0;
            this.mtrlLabelArea.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelArea.Location = new System.Drawing.Point(248, 161);
            this.mtrlLabelArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelArea.Name = "mtrlLabelArea";
            this.mtrlLabelArea.Size = new System.Drawing.Size(38, 24);
            this.mtrlLabelArea.TabIndex = 9;
            this.mtrlLabelArea.Text = "m4";
            // 
            // mtrlLabelPart
            // 
            this.mtrlLabelPart.AutoSize = true;
            this.mtrlLabelPart.Depth = 0;
            this.mtrlLabelPart.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelPart.Location = new System.Drawing.Point(96, 396);
            this.mtrlLabelPart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelPart.Name = "mtrlLabelPart";
            this.mtrlLabelPart.Size = new System.Drawing.Size(95, 24);
            this.mtrlLabelPart.TabIndex = 10;
            this.mtrlLabelPart.Text = "Partenaire";
            // 
            // mtrlLabelCit
            // 
            this.mtrlLabelCit.AutoSize = true;
            this.mtrlLabelCit.Depth = 0;
            this.mtrlLabelCit.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelCit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelCit.Location = new System.Drawing.Point(96, 448);
            this.mtrlLabelCit.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelCit.Name = "mtrlLabelCit";
            this.mtrlLabelCit.Size = new System.Drawing.Size(47, 24);
            this.mtrlLabelCit.TabIndex = 11;
            this.mtrlLabelCit.Text = "Ville";
            // 
            // mtrlLabelPartner
            // 
            this.mtrlLabelPartner.AutoSize = true;
            this.mtrlLabelPartner.Depth = 0;
            this.mtrlLabelPartner.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelPartner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelPartner.Location = new System.Drawing.Point(248, 396);
            this.mtrlLabelPartner.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelPartner.Name = "mtrlLabelPartner";
            this.mtrlLabelPartner.Size = new System.Drawing.Size(0, 24);
            this.mtrlLabelPartner.TabIndex = 12;
            // 
            // mtrlLabelCity
            // 
            this.mtrlLabelCity.AutoSize = true;
            this.mtrlLabelCity.Depth = 0;
            this.mtrlLabelCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtrlLabelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtrlLabelCity.Location = new System.Drawing.Point(248, 448);
            this.mtrlLabelCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtrlLabelCity.Name = "mtrlLabelCity";
            this.mtrlLabelCity.Size = new System.Drawing.Size(0, 24);
            this.mtrlLabelCity.TabIndex = 13;
            // 
            // standAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.mtrlLabelCity);
            this.Controls.Add(this.mtrlLabelPartner);
            this.Controls.Add(this.mtrlLabelCit);
            this.Controls.Add(this.mtrlLabelPart);
            this.Controls.Add(this.mtrlLabelArea);
            this.Controls.Add(this.mtrlLabelAr);
            this.Controls.Add(this.mtrlLabelLocalisation);
            this.Controls.Add(this.mtrlLabelLoc);
            this.Controls.Add(this.cBoxPartners);
            this.Controls.Add(this.attributeButton);
            this.Name = "standAllocation";
            this.Size = new System.Drawing.Size(842, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 attributeButton;
        private ComboBox cBoxPartners;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelLoc;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelLocalisation;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelAr;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelArea;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelPart;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelCit;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelPartner;
        private MaterialSkin.Controls.MaterialLabel mtrlLabelCity;
    }
}
