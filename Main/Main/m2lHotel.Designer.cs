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
            this.txtBoxNameHotel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBoxAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddHotel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeleteHotel = new Bunifu.Framework.UI.BunifuImageButton();
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHotel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHotel.DoubleBuffered = true;
            this.dgvHotel.EnableHeadersVisualStyles = false;
            this.dgvHotel.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvHotel.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvHotel.Location = new System.Drawing.Point(0, 134);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHotel.Size = new System.Drawing.Size(677, 286);
            this.dgvHotel.TabIndex = 0;
            this.dgvHotel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellEndEdit);
            // 
            // txtBoxNameHotel
            // 
            this.txtBoxNameHotel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxNameHotel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxNameHotel.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxNameHotel.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxNameHotel.HintText = "";
            this.txtBoxNameHotel.isPassword = false;
            this.txtBoxNameHotel.LineFocusedColor = System.Drawing.Color.Black;
            this.txtBoxNameHotel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxNameHotel.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtBoxNameHotel.LineThickness = 3;
            this.txtBoxNameHotel.Location = new System.Drawing.Point(53, 33);
            this.txtBoxNameHotel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNameHotel.Name = "txtBoxNameHotel";
            this.txtBoxNameHotel.Size = new System.Drawing.Size(200, 27);
            this.txtBoxNameHotel.TabIndex = 1;
            this.txtBoxNameHotel.Text = "Nom Hotel";
            this.txtBoxNameHotel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxNameHotel.Enter += new System.EventHandler(this.txtBoxNameHotel_Enter);
            this.txtBoxNameHotel.Leave += new System.EventHandler(this.txtBoxNameHotel_Leave);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxAddress.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxAddress.HintText = "";
            this.txtBoxAddress.isPassword = false;
            this.txtBoxAddress.LineFocusedColor = System.Drawing.Color.Black;
            this.txtBoxAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxAddress.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtBoxAddress.LineThickness = 3;
            this.txtBoxAddress.Location = new System.Drawing.Point(277, 33);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(206, 27);
            this.txtBoxAddress.TabIndex = 2;
            this.txtBoxAddress.Text = "Adresse Hotel";
            this.txtBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxAddress.Enter += new System.EventHandler(this.txtBoxAddress_Enter);
            this.txtBoxAddress.Leave += new System.EventHandler(this.txtBoxAddress_Leave);
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddHotel.Image = global::Main.Properties.Resources.baseline_add_white_48dp;
            this.btnAddHotel.ImageActive = null;
            this.btnAddHotel.Location = new System.Drawing.Point(553, 84);
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
            this.btnDeleteHotel.Location = new System.Drawing.Point(622, 84);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(43, 44);
            this.btnDeleteHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteHotel.TabIndex = 5;
            this.btnDeleteHotel.TabStop = false;
            this.btnDeleteHotel.Zoom = 10;
            this.btnDeleteHotel.Click += new System.EventHandler(this.btnDeleteHotel_Click);
            // 
            // m2lHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.btnAddHotel);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxNameHotel);
            this.Controls.Add(this.dgvHotel);
            this.Name = "m2lHotel";
            this.Size = new System.Drawing.Size(677, 420);
            this.Load += new System.EventHandler(this.m2lHotelcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvHotel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxNameHotel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxAddress;
        private Bunifu.Framework.UI.BunifuImageButton btnAddHotel;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteHotel;
    }
}
