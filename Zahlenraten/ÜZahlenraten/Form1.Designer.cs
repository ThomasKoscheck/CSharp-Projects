namespace ÜZahlenraten
{
    partial class frmÜZahlenraten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜZahlenraten));
            this.cmdPrüfen = new System.Windows.Forms.Button();
            this.cmdErzeugen = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.lblEingabe = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblVersuche = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdPrüfen
            // 
            this.cmdPrüfen.Location = new System.Drawing.Point(279, 79);
            this.cmdPrüfen.Name = "cmdPrüfen";
            this.cmdPrüfen.Size = new System.Drawing.Size(95, 23);
            this.cmdPrüfen.TabIndex = 0;
            this.cmdPrüfen.Text = "Prüfen";
            this.cmdPrüfen.UseVisualStyleBackColor = true;
            this.cmdPrüfen.Click += new System.EventHandler(this.cmdPrüfen_Click);
            // 
            // cmdErzeugen
            // 
            this.cmdErzeugen.Location = new System.Drawing.Point(279, 21);
            this.cmdErzeugen.Name = "cmdErzeugen";
            this.cmdErzeugen.Size = new System.Drawing.Size(95, 23);
            this.cmdErzeugen.TabIndex = 1;
            this.cmdErzeugen.Text = "Erzeugen";
            this.cmdErzeugen.UseVisualStyleBackColor = true;
            this.cmdErzeugen.Click += new System.EventHandler(this.cmdErzeugen_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(139, 131);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.lblAnzeige.TabIndex = 2;
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(142, 81);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe.TabIndex = 3;
            this.txtEingabe.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // lblEingabe
            // 
            this.lblEingabe.AutoSize = true;
            this.lblEingabe.Location = new System.Drawing.Point(63, 84);
            this.lblEingabe.Name = "lblEingabe";
            this.lblEingabe.Size = new System.Drawing.Size(70, 13);
            this.lblEingabe.TabIndex = 4;
            this.lblEingabe.Text = "Ihre Eingabe:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(78, 162);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(55, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Versuche:";
            // 
            // lblVersuche
            // 
            this.lblVersuche.AutoSize = true;
            this.lblVersuche.Location = new System.Drawing.Point(139, 162);
            this.lblVersuche.Name = "lblVersuche";
            this.lblVersuche.Size = new System.Drawing.Size(0, 13);
            this.lblVersuche.TabIndex = 6;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Location = new System.Drawing.Point(66, 23);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(176, 21);
            this.cbLevel.TabIndex = 8;
            this.cbLevel.Text = "Bitte Level wählen";
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // frmÜZahlenraten
            // 
            this.AcceptButton = this.cmdPrüfen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 223);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.lblVersuche);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblEingabe);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdErzeugen);
            this.Controls.Add(this.cmdPrüfen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmÜZahlenraten";
            this.Text = "Zahlen raten";
            this.Load += new System.EventHandler(this.frmÜZahlenraten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPrüfen;
        private System.Windows.Forms.Button cmdErzeugen;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Label lblEingabe;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblVersuche;
        private System.Windows.Forms.ComboBox cbLevel;
    }
}

