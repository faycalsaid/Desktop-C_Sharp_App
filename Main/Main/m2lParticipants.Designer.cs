namespace Main
{
    partial class m2lParticipants
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgvParticipants = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddParticipants = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteParticipants = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtBoxNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBoxPrenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxHotel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataMember = "Participant";

            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgvParticipants
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.DoubleBuffered = true;
            this.dgvParticipants.EnableHeadersVisualStyles = false;
            this.dgvParticipants.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvParticipants.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvParticipants.HeaderForeColor = System.Drawing.Color.MintCream;
            this.dgvParticipants.Location = new System.Drawing.Point(-1, 141);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvParticipants.Size = new System.Drawing.Size(675, 279);
            this.dgvParticipants.TabIndex = 0;
            this.dgvParticipants.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_CellEndEdit);
            // 
            // btnAddParticipants
            // 
            this.btnAddParticipants.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddParticipants.Image = global::Main.Properties.Resources.baseline_add_white_48dp;
            this.btnAddParticipants.ImageActive = null;
            this.btnAddParticipants.Location = new System.Drawing.Point(541, 91);
            this.btnAddParticipants.Name = "btnAddParticipants";
            this.btnAddParticipants.Size = new System.Drawing.Size(44, 44);
            this.btnAddParticipants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddParticipants.TabIndex = 3;
            this.btnAddParticipants.TabStop = false;
            this.btnAddParticipants.Zoom = 10;
            this.btnAddParticipants.Click += new System.EventHandler(this.btnAddParticipants_Click_1);
            // 
            // btnDeleteParticipants
            // 
            this.btnDeleteParticipants.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteParticipants.Image = global::Main.Properties.Resources.baseline_delete_white_48dp;
            this.btnDeleteParticipants.ImageActive = null;
            this.btnDeleteParticipants.Location = new System.Drawing.Point(611, 91);
            this.btnDeleteParticipants.Name = "btnDeleteParticipants";
            this.btnDeleteParticipants.Size = new System.Drawing.Size(43, 44);
            this.btnDeleteParticipants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteParticipants.TabIndex = 1;
            this.btnDeleteParticipants.TabStop = false;
            this.btnDeleteParticipants.Zoom = 10;
            this.btnDeleteParticipants.Click += new System.EventHandler(this.btnDeleteParticipants_Click);
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxNom.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxNom.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxNom.HintText = "";
            this.txtBoxNom.isPassword = false;
            this.txtBoxNom.LineFocusedColor = System.Drawing.Color.Black;
            this.txtBoxNom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxNom.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtBoxNom.LineThickness = 3;
            this.txtBoxNom.Location = new System.Drawing.Point(68, 30);
            this.txtBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(160, 28);
            this.txtBoxNom.TabIndex = 4;
            this.txtBoxNom.Text = "Nom Participant";
            this.txtBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxNom.Enter += new System.EventHandler(this.txtBoxNom_Enter);
            this.txtBoxNom.Leave += new System.EventHandler(this.txtBoxNom_Leave);
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxPrenom.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPrenom.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxPrenom.HintText = "";
            this.txtBoxPrenom.isPassword = false;
            this.txtBoxPrenom.LineFocusedColor = System.Drawing.Color.Black;
            this.txtBoxPrenom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxPrenom.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtBoxPrenom.LineThickness = 3;
            this.txtBoxPrenom.Location = new System.Drawing.Point(68, 91);
            this.txtBoxPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(160, 28);
            this.txtBoxPrenom.TabIndex = 6;
            this.txtBoxPrenom.Text = "Prénom Participant";
            this.txtBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPrenom.Enter += new System.EventHandler(this.txtBoxPrenom_Enter);
            this.txtBoxPrenom.Leave += new System.EventHandler(this.txtBoxPrenom_Leave);
            // 
            // cBoxHotel
            // 
            this.cBoxHotel.FormattingEnabled = true;
            this.cBoxHotel.Location = new System.Drawing.Point(284, 37);
            this.cBoxHotel.Name = "cBoxHotel";
            this.cBoxHotel.Size = new System.Drawing.Size(134, 21);
            this.cBoxHotel.TabIndex = 7;
            this.cBoxHotel.Enter += new System.EventHandler(this.cBoxHotel_Enter);
            // 
            // m2lParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBoxHotel);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.btnAddParticipants);
            this.Controls.Add(this.btnDeleteParticipants);
            this.Controls.Add(this.dgvParticipants);
            this.Name = "m2lParticipants";
            this.Size = new System.Drawing.Size(677, 420);
            this.Load += new System.EventHandler(this.m2lParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource participantBindingSource;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnAddParticipants;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteParticipants;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvParticipants;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxPrenom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxNom;
        private System.Windows.Forms.ComboBox cBoxHotel;
    }
}
