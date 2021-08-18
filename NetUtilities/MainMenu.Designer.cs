namespace NetUtilities
{
    partial class MainMenu
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
            this.buttonsContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ipScanButton = new System.Windows.Forms.Button();
            this.buttonsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Controls.Add(this.button1);
            this.buttonsContainer.Controls.Add(this.ipScanButton);
            this.buttonsContainer.Location = new System.Drawing.Point(161, 88);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Size = new System.Drawing.Size(500, 300);
            this.buttonsContainer.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::NetUtilities.Properties.Resources.icons8_wall_socket_60;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(169, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ports scan";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ipScanButton
            // 
            this.ipScanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.ipScanButton.FlatAppearance.BorderSize = 0;
            this.ipScanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ipScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipScanButton.ForeColor = System.Drawing.Color.White;
            this.ipScanButton.Image = global::NetUtilities.Properties.Resources.icons8_radar_60;
            this.ipScanButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ipScanButton.Location = new System.Drawing.Point(3, 0);
            this.ipScanButton.Name = "ipScanButton";
            this.ipScanButton.Size = new System.Drawing.Size(160, 99);
            this.ipScanButton.TabIndex = 0;
            this.ipScanButton.Text = "Ip scan";
            this.ipScanButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ipScanButton.UseVisualStyleBackColor = false;
            this.ipScanButton.Click += new System.EventHandler(this.ipScanButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonsContainer);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(834, 461);
            this.buttonsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsContainer;
        private System.Windows.Forms.Button ipScanButton;
        private System.Windows.Forms.Button button1;
    }
}
