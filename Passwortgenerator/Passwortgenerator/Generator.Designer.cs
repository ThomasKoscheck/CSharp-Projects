namespace Passwortgenerator
{
    partial class frmGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            this.chkGrossKlein = new System.Windows.Forms.CheckBox();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.cbLaenge = new System.Windows.Forms.ComboBox();
            this.chkSonderzeichen = new System.Windows.Forms.CheckBox();
            this.chkZahlen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pgbStaerke = new System.Windows.Forms.ProgressBar();
            this.lblPasswort = new System.Windows.Forms.TextBox();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkGrossKlein
            // 
            this.chkGrossKlein.AutoSize = true;
            this.chkGrossKlein.Location = new System.Drawing.Point(36, 106);
            this.chkGrossKlein.Name = "chkGrossKlein";
            this.chkGrossKlein.Size = new System.Drawing.Size(155, 17);
            this.chkGrossKlein.TabIndex = 0;
            this.chkGrossKlein.Text = "Groß- und Kleinbuchstaben";
            this.chkGrossKlein.UseVisualStyleBackColor = true;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(205, 226);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(139, 37);
            this.cmdGenerate.TabIndex = 1;
            this.cmdGenerate.Text = "Passwort generieren";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cbLaenge
            // 
            this.cbLaenge.DropDownHeight = 120;
            this.cbLaenge.FormattingEnabled = true;
            this.cbLaenge.IntegralHeight = false;
            this.cbLaenge.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
            this.cbLaenge.Location = new System.Drawing.Point(82, 41);
            this.cbLaenge.Name = "cbLaenge";
            this.cbLaenge.Size = new System.Drawing.Size(121, 21);
            this.cbLaenge.TabIndex = 3;
            // 
            // chkSonderzeichen
            // 
            this.chkSonderzeichen.AutoSize = true;
            this.chkSonderzeichen.Location = new System.Drawing.Point(36, 160);
            this.chkSonderzeichen.Name = "chkSonderzeichen";
            this.chkSonderzeichen.Size = new System.Drawing.Size(97, 17);
            this.chkSonderzeichen.TabIndex = 4;
            this.chkSonderzeichen.Text = "Sonderzeichen";
            this.chkSonderzeichen.UseVisualStyleBackColor = true;
            // 
            // chkZahlen
            // 
            this.chkZahlen.AutoSize = true;
            this.chkZahlen.Location = new System.Drawing.Point(36, 133);
            this.chkZahlen.Name = "chkZahlen";
            this.chkZahlen.Size = new System.Drawing.Size(107, 17);
            this.chkZahlen.TabIndex = 5;
            this.chkZahlen.Text = "Zahlen (0, 1, 2...)";
            this.chkZahlen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Länge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stärke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Folgendes verwenden";
            // 
            // pgbStaerke
            // 
            this.pgbStaerke.Location = new System.Drawing.Point(303, 70);
            this.pgbStaerke.Name = "pgbStaerke";
            this.pgbStaerke.Size = new System.Drawing.Size(218, 23);
            this.pgbStaerke.TabIndex = 9;
            // 
            // lblPasswort
            // 
            this.lblPasswort.Location = new System.Drawing.Point(18, 322);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(518, 20);
            this.lblPasswort.TabIndex = 12;
            // 
            // cmdCopy
            // 
            this.cmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCopy.Location = new System.Drawing.Point(487, 320);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(49, 23);
            this.cmdCopy.TabIndex = 13;
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(548, 354);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.pgbStaerke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkZahlen);
            this.Controls.Add(this.chkSonderzeichen);
            this.Controls.Add(this.cbLaenge);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.chkGrossKlein);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerator";
            this.Text = "Passwort-Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkGrossKlein;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.ComboBox cbLaenge;
        private System.Windows.Forms.CheckBox chkSonderzeichen;
        private System.Windows.Forms.CheckBox chkZahlen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pgbStaerke;
        private System.Windows.Forms.TextBox lblPasswort;
        private System.Windows.Forms.Button cmdCopy;
    }
}

