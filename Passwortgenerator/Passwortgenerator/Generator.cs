using System;
using System.Windows.Forms;

namespace Passwortgenerator
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            lblPasswort.Text = "";
            pgbStaerke.Value = 0;

            char[] c = new char[26];

            //nichts ausgewählt
            if (!chkZahlen.Checked && !chkSonderzeichen.Checked && !chkGrossKlein.Checked)
            {               
                Kleinbuchstaben instance = new Kleinbuchstaben();

                c = instance.ausgabe(cbLaenge.SelectedIndex + 6);   //+4, da unsere Passwortlänge bei 4 beginnt

                for (int i = 0; i < cbLaenge.SelectedIndex + 6; i++)
                {
                    lblPasswort.Text += (Convert.ToString(c[i]));
                }
            }

            /* ----- eines ausgewählt ----- */

            //Klein und Großbuchstaben
            if (chkGrossKlein.Checked && !chkZahlen.Checked && !chkSonderzeichen.Checked)
            {
                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Grossbuchstaben instancegross = new Grossbuchstaben();

                Random grossoderklein = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = grossoderklein.Next(0, 2);
                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancegross.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }

            //Kleinbuchstaben und Zahlen
            else if (chkZahlen.Checked && !chkSonderzeichen.Checked && !chkGrossKlein.Checked)
            {
                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Zahlen instancezahl = new Zahlen();

                Random zahloderklein = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = zahloderklein.Next(0, 2);

                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancezahl.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }

            //Kleinbuchstaben und Sonderzeichen
            else if (!chkZahlen.Checked && chkSonderzeichen.Checked && !chkGrossKlein.Checked)
            {
                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Sonderzeichen instancesonder = new Sonderzeichen();

                Random zahlodersonder = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = zahlodersonder.Next(0, 2);

                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancesonder.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }

            /* ----- zwei ausgewählt -----*/
            //Kleinbuchstaben, Zahlen und Sonderzeichen
            else if (chkZahlen.Checked && chkSonderzeichen.Checked && !chkGrossKlein.Checked)
            {
                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Sonderzeichen instancesonder = new Sonderzeichen();
                Zahlen instancezahl = new Zahlen();

                Random entscheider = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = entscheider.Next(0, 3);

                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else if (zahl == 2)
                    {
                        c = instancesonder.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancezahl.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }

            //Kleinbuchstaben, Zahlen und Großbuchstaben
            else if (chkZahlen.Checked && !chkSonderzeichen.Checked && chkGrossKlein.Checked)
            {

                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Grossbuchstaben instancegross = new Grossbuchstaben();
                Zahlen instancezahl = new Zahlen();

                Random entscheider = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = entscheider.Next(0, 3);

                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else if (zahl == 2)
                    {
                        c = instancegross.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancezahl.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }

            //Kleinbuchstaben, Grossbuchstaben und Sonderzeichen
            else if (!chkZahlen.Checked && chkSonderzeichen.Checked && chkGrossKlein.Checked)
            {
                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Grossbuchstaben instancegross = new Grossbuchstaben();
                Sonderzeichen instancesonder = new Sonderzeichen();

                Random entscheider = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = entscheider.Next(0, 3);

                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else if (zahl == 2)
                    {
                        c = instancegross.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancesonder.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }
            /* ----- drei ausgewählt -----*/
            else if (chkZahlen.Checked && chkSonderzeichen.Checked && chkGrossKlein.Checked)
            {
                Kleinbuchstaben instanceklein = new Kleinbuchstaben();
                Grossbuchstaben instancegross = new Grossbuchstaben();
                Sonderzeichen instancesonder = new Sonderzeichen();
                Zahlen instancezahl = new Zahlen();

                Random entscheider = new Random();

                for (int i = cbLaenge.SelectedIndex + 6; i > 0; i--)
                {
                    int zähler = 0;
                    int zahl = entscheider.Next(0, 4);

                    if (zahl == 1)
                    {
                        c = instanceklein.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else if (zahl == 2)
                    {
                        c = instancegross.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else if (zahl == 3)
                    {
                        c = instancesonder.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }

                    else
                    {
                        c = instancezahl.ausgabe(1);
                        lblPasswort.Text += (Convert.ToString(c[zähler]));
                        zähler++;
                    }
                }
            }

            Passwortstärke();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblPasswort.Text);
        }

        private void Passwortstärke()
        {
            // ProgressBar-Maximum auf Dateigröße einstellen 
            pgbStaerke.Minimum = 0;
            pgbStaerke.Maximum = 264;       //maximumlänge, jeweils mal 2 für zusätzliche zeichen
            // Schrittweite einstellen 
            pgbStaerke.Step = 1;

            int multiple = 1;

            if (chkZahlen.Checked && chkSonderzeichen.Checked && chkGrossKlein.Checked)
                multiple = 6;

            else if ((chkGrossKlein.Checked && chkSonderzeichen.Checked) || (chkGrossKlein.Checked && chkZahlen.Checked) || (chkSonderzeichen.Checked && chkZahlen.Checked))
                multiple = 4;

            else if (chkGrossKlein.Checked || chkSonderzeichen.Checked || chkZahlen.Checked)
                multiple = 2;

            for (int i = 0; i <= ((cbLaenge.SelectedIndex + 6) * multiple); i++) 
                pgbStaerke.PerformStep();
            }
    }
}
