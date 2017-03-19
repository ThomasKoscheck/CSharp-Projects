namespace Shutdown
{
    partial class frmShutdown
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShutdown));
            this.cmdHerunterfahren = new System.Windows.Forms.Button();
            this.txtZeitH = new System.Windows.Forms.TextBox();
            this.lblMin1 = new System.Windows.Forms.Label();
            this.cmdAbbrechenN = new System.Windows.Forms.Button();
            this.cmdAbbrechenH = new System.Windows.Forms.Button();
            this.txtZeitN = new System.Windows.Forms.TextBox();
            this.cmdNeustart = new System.Windows.Forms.Button();
            this.lblMin2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblAktion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdHerunterfahren
            // 
            this.cmdHerunterfahren.Location = new System.Drawing.Point(264, 26);
            this.cmdHerunterfahren.Name = "cmdHerunterfahren";
            this.cmdHerunterfahren.Size = new System.Drawing.Size(98, 34);
            this.cmdHerunterfahren.TabIndex = 0;
            this.cmdHerunterfahren.Text = "Herunterfahren";
            this.cmdHerunterfahren.UseVisualStyleBackColor = true;
            this.cmdHerunterfahren.Click += new System.EventHandler(this.cmdHerunterfahren_Click);
            // 
            // txtZeitH
            // 
            this.txtZeitH.Location = new System.Drawing.Point(105, 34);
            this.txtZeitH.Name = "txtZeitH";
            this.txtZeitH.Size = new System.Drawing.Size(100, 20);
            this.txtZeitH.TabIndex = 1;
            // 
            // lblMin1
            // 
            this.lblMin1.AutoSize = true;
            this.lblMin1.Location = new System.Drawing.Point(211, 37);
            this.lblMin1.Name = "lblMin1";
            this.lblMin1.Size = new System.Drawing.Size(23, 13);
            this.lblMin1.TabIndex = 2;
            this.lblMin1.Text = "min";
            // 
            // cmdAbbrechenN
            // 
            this.cmdAbbrechenN.Location = new System.Drawing.Point(381, 84);
            this.cmdAbbrechenN.Name = "cmdAbbrechenN";
            this.cmdAbbrechenN.Size = new System.Drawing.Size(98, 34);
            this.cmdAbbrechenN.TabIndex = 4;
            this.cmdAbbrechenN.Text = "Abbrechen";
            this.cmdAbbrechenN.UseVisualStyleBackColor = true;
            this.cmdAbbrechenN.Click += new System.EventHandler(this.cmdAbbrechen_Click);
            // 
            // cmdAbbrechenH
            // 
            this.cmdAbbrechenH.Location = new System.Drawing.Point(381, 26);
            this.cmdAbbrechenH.Name = "cmdAbbrechenH";
            this.cmdAbbrechenH.Size = new System.Drawing.Size(98, 34);
            this.cmdAbbrechenH.TabIndex = 7;
            this.cmdAbbrechenH.Text = "Abbrechen";
            this.cmdAbbrechenH.UseVisualStyleBackColor = true;
            this.cmdAbbrechenH.Click += new System.EventHandler(this.cmdAbbrechen_Click);
            // 
            // txtZeitN
            // 
            this.txtZeitN.Location = new System.Drawing.Point(105, 92);
            this.txtZeitN.Name = "txtZeitN";
            this.txtZeitN.Size = new System.Drawing.Size(100, 20);
            this.txtZeitN.TabIndex = 6;
            // 
            // cmdNeustart
            // 
            this.cmdNeustart.Location = new System.Drawing.Point(264, 84);
            this.cmdNeustart.Name = "cmdNeustart";
            this.cmdNeustart.Size = new System.Drawing.Size(98, 34);
            this.cmdNeustart.TabIndex = 5;
            this.cmdNeustart.Text = "Neustart";
            this.cmdNeustart.UseVisualStyleBackColor = true;
            this.cmdNeustart.Click += new System.EventHandler(this.cmdNeustart_Click);
            // 
            // lblMin2
            // 
            this.lblMin2.AutoSize = true;
            this.lblMin2.Location = new System.Drawing.Point(211, 95);
            this.lblMin2.Name = "lblMin2";
            this.lblMin2.Size = new System.Drawing.Size(23, 13);
            this.lblMin2.TabIndex = 8;
            this.lblMin2.Text = "min";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.Image = ((System.Drawing.Image)(resources.GetObject("Restart.Image")));
            this.Restart.Location = new System.Drawing.Point(12, 84);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(87, 35);
            this.Restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restart.TabIndex = 10;
            this.Restart.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(12, 201);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 11;
            // 
            // lblAktion
            // 
            this.lblAktion.AutoSize = true;
            this.lblAktion.Location = new System.Drawing.Point(12, 216);
            this.lblAktion.Name = "lblAktion";
            this.lblAktion.Size = new System.Drawing.Size(0, 13);
            this.lblAktion.TabIndex = 12;
            // 
            // frmShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 241);
            this.Controls.Add(this.lblAktion);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMin2);
            this.Controls.Add(this.cmdAbbrechenH);
            this.Controls.Add(this.txtZeitN);
            this.Controls.Add(this.cmdNeustart);
            this.Controls.Add(this.cmdAbbrechenN);
            this.Controls.Add(this.lblMin1);
            this.Controls.Add(this.txtZeitH);
            this.Controls.Add(this.cmdHerunterfahren);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShutdown";
            this.Text = "Shutdowntool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdHerunterfahren;
        private System.Windows.Forms.TextBox txtZeitH;
        private System.Windows.Forms.Label lblMin1;
        private System.Windows.Forms.Button cmdAbbrechenN;
        private System.Windows.Forms.Button cmdAbbrechenH;
        private System.Windows.Forms.TextBox txtZeitN;
        private System.Windows.Forms.Button cmdNeustart;
        private System.Windows.Forms.Label lblMin2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Restart;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAktion;
    }
}

