namespace NetUtilities
{
    partial class IpScan
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.netAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subnetMask = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bottomLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 25);
            this.panel1.TabIndex = 1;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(834, 347);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonDataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 347);
            this.panel2.TabIndex = 2;
            // 
            // bottomLabel
            // 
            this.bottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.Location = new System.Drawing.Point(3, 3);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(0, 16);
            this.bottomLabel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.homeButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.subnetMask);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.netAddress);
            this.panel3.Controls.Add(this.scanButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 83);
            this.panel3.TabIndex = 3;
            // 
            // netAddress
            // 
            this.netAddress.Location = new System.Drawing.Point(83, 53);
            this.netAddress.Name = "netAddress";
            this.netAddress.Size = new System.Drawing.Size(128, 20);
            this.netAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subnet mask:";
            // 
            // subnetMask
            // 
            this.subnetMask.Location = new System.Drawing.Point(227, 53);
            this.subnetMask.Name = "subnetMask";
            this.subnetMask.Size = new System.Drawing.Size(128, 20);
            this.subnetMask.TabIndex = 3;
            this.subnetMask.Text = "255.255.255.0";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = global::NetUtilities.Properties.Resources.icons8_back_to_32;
            this.homeButton.Location = new System.Drawing.Point(765, 13);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(60, 60);
            this.homeButton.TabIndex = 5;
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // scanButton
            // 
            this.scanButton.Image = global::NetUtilities.Properties.Resources.icons8_search_property_48;
            this.scanButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scanButton.Location = new System.Drawing.Point(8, 13);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(60, 60);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan";
            this.scanButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // IpScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IpScan";
            this.Size = new System.Drawing.Size(834, 461);
            this.Load += new System.EventHandler(this.IpScan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label bottomLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox netAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subnetMask;
        private System.Windows.Forms.Button homeButton;
    }
}
