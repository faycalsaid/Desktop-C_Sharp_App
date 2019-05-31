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
            this.areaTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.localisationTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // areaTxtBox
            // 
            this.areaTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.areaTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.areaTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.areaTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.areaTxtBox.HintText = "";
            this.areaTxtBox.isPassword = false;
            this.areaTxtBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.areaTxtBox.LineIdleColor = System.Drawing.Color.Gray;
            this.areaTxtBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.areaTxtBox.LineThickness = 3;
            this.areaTxtBox.Location = new System.Drawing.Point(298, 177);
            this.areaTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.areaTxtBox.Name = "areaTxtBox";
            this.areaTxtBox.Size = new System.Drawing.Size(370, 44);
            this.areaTxtBox.TabIndex = 1;
            this.areaTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // localisationTxtBox
            // 
            this.localisationTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.localisationTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.localisationTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.localisationTxtBox.HintForeColor = System.Drawing.Color.Empty;
            this.localisationTxtBox.HintText = "";
            this.localisationTxtBox.isPassword = false;
            this.localisationTxtBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.localisationTxtBox.LineIdleColor = System.Drawing.Color.Gray;
            this.localisationTxtBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.localisationTxtBox.LineThickness = 3;
            this.localisationTxtBox.Location = new System.Drawing.Point(298, 87);
            this.localisationTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.localisationTxtBox.Name = "localisationTxtBox";
            this.localisationTxtBox.Size = new System.Drawing.Size(370, 44);
            this.localisationTxtBox.TabIndex = 0;
            this.localisationTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // confirmStandsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.areaTxtBox);
            this.Controls.Add(this.localisationTxtBox);
            this.Name = "confirmStandsModal";
            this.Size = new System.Drawing.Size(842, 548);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox areaTxtBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox localisationTxtBox;
    }
}
