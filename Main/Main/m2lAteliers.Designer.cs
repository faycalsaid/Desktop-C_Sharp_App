namespace Main
{
    partial class m2lAteliers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuSearchEngine1 = new Bunifu.Framework.UI.BunifuSearchEngine();
            this.SuspendLayout();
            // 
            // bunifuSearchEngine1
            // 
            this.bunifuSearchEngine1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuSearchEngine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSearchEngine1.Location = new System.Drawing.Point(217, 55);
            this.bunifuSearchEngine1.Name = "bunifuSearchEngine1";
            this.bunifuSearchEngine1.Size = new System.Drawing.Size(279, 44);
            this.bunifuSearchEngine1.TabIndex = 0;
            // 
            // m2lAteliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSearchEngine1);
            this.Name = "m2lAteliers";
            this.Size = new System.Drawing.Size(679, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSearchEngine bunifuSearchEngine1;
    }
}
