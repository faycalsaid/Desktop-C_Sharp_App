namespace Main
{
    partial class AtelierUserManaging
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtelierUserManaging));
            this.dataGridViewParticipants = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvAtelierParticipants = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.addParticipantBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.delParticipantBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnReturnAt = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtelierParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addParticipantBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delParticipantBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnAt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToAddRows = false;
            this.dataGridViewParticipants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParticipants.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.dataGridViewParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.DoubleBuffered = true;
            this.dataGridViewParticipants.EnableHeadersVisualStyles = false;
            this.dataGridViewParticipants.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewParticipants.HeaderForeColor = System.Drawing.Color.Thistle;
            this.dataGridViewParticipants.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewParticipants.RowHeadersWidth = 51;
            this.dataGridViewParticipants.RowTemplate.Height = 24;
            this.dataGridViewParticipants.Size = new System.Drawing.Size(875, 231);
            this.dataGridViewParticipants.TabIndex = 0;
            // 
            // dgvAtelierParticipants
            // 
            this.dgvAtelierParticipants.AllowUserToAddRows = false;
            this.dgvAtelierParticipants.AllowUserToDeleteRows = false;
            this.dgvAtelierParticipants.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAtelierParticipants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAtelierParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtelierParticipants.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.dgvAtelierParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAtelierParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAtelierParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAtelierParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtelierParticipants.DoubleBuffered = true;
            this.dgvAtelierParticipants.EnableHeadersVisualStyles = false;
            this.dgvAtelierParticipants.HeaderBgColor = System.Drawing.Color.DeepPink;
            this.dgvAtelierParticipants.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAtelierParticipants.Location = new System.Drawing.Point(0, 295);
            this.dgvAtelierParticipants.Name = "dgvAtelierParticipants";
            this.dgvAtelierParticipants.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAtelierParticipants.RowHeadersWidth = 51;
            this.dgvAtelierParticipants.RowTemplate.Height = 24;
            this.dgvAtelierParticipants.Size = new System.Drawing.Size(875, 241);
            this.dgvAtelierParticipants.TabIndex = 1;
            // 
            // addParticipantBtn
            // 
            this.addParticipantBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addParticipantBtn.Image = ((System.Drawing.Image)(resources.GetObject("addParticipantBtn.Image")));
            this.addParticipantBtn.ImageActive = null;
            this.addParticipantBtn.Location = new System.Drawing.Point(930, 217);
            this.addParticipantBtn.Name = "addParticipantBtn";
            this.addParticipantBtn.Size = new System.Drawing.Size(71, 44);
            this.addParticipantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addParticipantBtn.TabIndex = 2;
            this.addParticipantBtn.TabStop = false;
            this.addParticipantBtn.Zoom = 10;
            this.addParticipantBtn.Click += new System.EventHandler(this.AddParticipantBtn_Click);
            // 
            // delParticipantBtn
            // 
            this.delParticipantBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.delParticipantBtn.Image = ((System.Drawing.Image)(resources.GetObject("delParticipantBtn.Image")));
            this.delParticipantBtn.ImageActive = null;
            this.delParticipantBtn.Location = new System.Drawing.Point(930, 492);
            this.delParticipantBtn.Name = "delParticipantBtn";
            this.delParticipantBtn.Size = new System.Drawing.Size(71, 44);
            this.delParticipantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delParticipantBtn.TabIndex = 3;
            this.delParticipantBtn.TabStop = false;
            this.delParticipantBtn.Zoom = 10;
            this.delParticipantBtn.Click += new System.EventHandler(this.DelParticipantBtn_Click);
            // 
            // btnReturnAt
            // 
            this.btnReturnAt.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnAt.Image = global::Main.Properties.Resources._return;
            this.btnReturnAt.ImageActive = null;
            this.btnReturnAt.Location = new System.Drawing.Point(0, 0);
            this.btnReturnAt.Name = "btnReturnAt";
            this.btnReturnAt.Size = new System.Drawing.Size(66, 30);
            this.btnReturnAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturnAt.TabIndex = 11;
            this.btnReturnAt.TabStop = false;
            this.btnReturnAt.Zoom = 10;
            this.btnReturnAt.Click += new System.EventHandler(this.BtnReturnAt_Click);
            // 
            // AtelierUserManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturnAt);
            this.Controls.Add(this.delParticipantBtn);
            this.Controls.Add(this.addParticipantBtn);
            this.Controls.Add(this.dgvAtelierParticipants);
            this.Controls.Add(this.dataGridViewParticipants);
            this.Name = "AtelierUserManaging";
            this.Size = new System.Drawing.Size(1043, 557);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtelierParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addParticipantBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delParticipantBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnAt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewParticipants;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAtelierParticipants;
        private Bunifu.Framework.UI.BunifuImageButton addParticipantBtn;
        private Bunifu.Framework.UI.BunifuImageButton delParticipantBtn;
        private Bunifu.Framework.UI.BunifuImageButton btnReturnAt;
    }
}
