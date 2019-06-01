namespace Main
{
    partial class m2lHotel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHotel = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddHotel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteHotel = new Bunifu.Framework.UI.BunifuImageButton();
            this.cBoxHotel = new System.Windows.Forms.ComboBox();
            this.txtBoxNbJour = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cBoxParticipant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHotel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHotel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHotel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHotel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHotel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHotel.DoubleBuffered = true;
            this.dgvHotel.EnableHeadersVisualStyles = false;
            this.dgvHotel.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvHotel.HeaderForeColor = System.Drawing.Color.White;
            this.dgvHotel.Location = new System.Drawing.Point(0, 134);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHotel.Size = new System.Drawing.Size(677, 286);
            this.dgvHotel.TabIndex = 0;
            this.dgvHotel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellEndEdit);
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddHotel.Image = global::Main.Properties.Resources.baseline_add_white_48dp;
            this.btnAddHotel.ImageActive = null;
            this.btnAddHotel.Location = new System.Drawing.Point(507, 23);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(44, 44);
            this.btnAddHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddHotel.TabIndex = 4;
            this.btnAddHotel.TabStop = false;
            this.btnAddHotel.Zoom = 10;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteHotel.Image = global::Main.Properties.Resources.baseline_delete_white_48dp;
            this.btnDeleteHotel.ImageActive = null;
            this.btnDeleteHotel.Location = new System.Drawing.Point(576, 23);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(43, 44);
            this.btnDeleteHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteHotel.TabIndex = 5;
            this.btnDeleteHotel.TabStop = false;
            this.btnDeleteHotel.Zoom = 10;
            this.btnDeleteHotel.Click += new System.EventHandler(this.btnDeleteHotel_Click);
            // 
            // cBoxHotel
            // 
            this.cBoxHotel.FormattingEnabled = true;
            this.cBoxHotel.Location = new System.Drawing.Point(337, 39);
            this.cBoxHotel.Name = "cBoxHotel";
            this.cBoxHotel.Size = new System.Drawing.Size(134, 21);
            this.cBoxHotel.TabIndex = 8;
            // 
            // txtBoxNbJour
            // 
            this.txtBoxNbJour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNbJour.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxNbJour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxNbJour.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxNbJour.HintText = "";
            this.txtBoxNbJour.isPassword = false;
            this.txtBoxNbJour.LineFocusedColor = System.Drawing.Color.Black;
            this.txtBoxNbJour.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxNbJour.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtBoxNbJour.LineThickness = 3;
            this.txtBoxNbJour.Location = new System.Drawing.Point(61, 84);
            this.txtBoxNbJour.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNbJour.Name = "txtBoxNbJour";
            this.txtBoxNbJour.Size = new System.Drawing.Size(215, 24);
            this.txtBoxNbJour.TabIndex = 9;
            this.txtBoxNbJour.Text = "Nombre de jours réservation";
            this.txtBoxNbJour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxNbJour.Enter += new System.EventHandler(this.TxtBoxNbJour_Enter);
            this.txtBoxNbJour.Leave += new System.EventHandler(this.TxtBoxNbJour_Leave);
            // 
            // cBoxParticipant
            // 
            this.cBoxParticipant.FormattingEnabled = true;
            this.cBoxParticipant.Location = new System.Drawing.Point(61, 39);
            this.cBoxParticipant.Name = "cBoxParticipant";
            this.cBoxParticipant.Size = new System.Drawing.Size(215, 21);
            this.cBoxParticipant.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Participant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hotel";
            // 
            // m2lHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxParticipant);
            this.Controls.Add(this.txtBoxNbJour);
            this.Controls.Add(this.cBoxHotel);
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.btnAddHotel);
            this.Controls.Add(this.dgvHotel);
            this.Name = "m2lHotel";
            this.Size = new System.Drawing.Size(677, 420);
            this.Load += new System.EventHandler(this.m2lHotelcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvHotel;
        private Bunifu.Framework.UI.BunifuImageButton btnAddHotel;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteHotel;
        private System.Windows.Forms.ComboBox cBoxHotel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxNbJour;
        private System.Windows.Forms.ComboBox cBoxParticipant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
