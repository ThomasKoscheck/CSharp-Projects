using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜZahlenraten
{
    public partial class frmÜZahlenraten : Form
    {
        Random r = new Random ();
        int zahl = -1;
        int count = 0;
        int right;
        
        public frmÜZahlenraten()
        {
            InitializeComponent();
        }

        private void cmdErzeugen_Click(object sender, EventArgs e)
        {
            txtEingabe.Text = "";

            if (cbLevel.SelectedIndex == cbLevel.FindStringExact("Level 1: 1 - 100"))  //vergleicht, welches Level gewählt wurde
            {
                zahl = r.Next(1, 101);
                right = 100;                //definiert rechte Obergrenze zur Begrenzung der Suche
                ausgabe();
            }

            else if (cbLevel.SelectedIndex == cbLevel.FindStringExact("Level 2: 1 - 200"))
            {
                zahl = r.Next(1, 201);
                right = 200;
                ausgabe();
            }

            else if (cbLevel.SelectedIndex == cbLevel.FindStringExact("Level 3: 1 - 300"))
            {
                zahl = r.Next(1, 301);
                right = 300;
                ausgabe();
            }

            else if (cbLevel.SelectedIndex == cbLevel.FindStringExact("Bitte Level wählen"))
            {
                lblVersuche.Text = " Bitte zu erst ein Level wählen";
            }
        }

        private void ausgabe()
        {
            count = 0;
            lblAnzeige.Text = "Zufallszahl wurde erzeugt";
            lblVersuche.Text = "" + count;
        }   

        private void cmdPrüfen_Click(object sender, EventArgs e)
        {
            int eingabe;

            try
            {
                if (zahl == -1)
                {
                    lblAnzeige.Text = "Bitte zuerst eine Zahl erzeugen";  //Fehlermeldung, falls keine Zahl erzeugt wurde
                    lblVersuche.Text = "" + count;
                }

                else
                {
                    eingabe = Convert.ToInt32(txtEingabe.Text);  //Eingabe in Textfeld wird in INT umgewandelt

                    if (eingabe < zahl)
                    {
                        count++;                                 //Versuche werden um 1 erhöht

                        if (eingabe < 1 || eingabe > right)
                            lblAnzeige.Text = "Die gesuchte Zahl liegt zwischen 1 und " + right;

                        else
                        {
                            lblAnzeige.Text = "Die gesuchte Zahl ist größer als " + eingabe + " ." + "\n";
                            lblVersuche.Text = "" + count;
                        }
                    }

                    else if (eingabe > zahl)
                    {
                        count++;

                        if (eingabe < 1 || eingabe > right)
                            lblAnzeige.Text = "Die gesuchte Zahl liegt zwischen 1 und " + right;

                        else
                        {
                            lblAnzeige.Text = "Die gesuchte Zahl ist kleiner als " + eingabe + " ." + "\n";
                            lblVersuche.Text = "" + count;
                        }
                    }

                    else
                    {
                        count++;

                        lblAnzeige.Text = eingabe + " ist die gesuchte Zahl!" + "\n" + "Herzlichen Glückwunsch";
                        lblVersuche.Text = "" + count;
                    }
                }
            }

            catch (FormatException ex) //Reihenfolge der Catchblöcke ist wichtig, der erste zutreffende wird ausgegeben
            {
                lblAnzeige.Text = "Fehler: falsches Eingabeformat";
            }

            catch (Exception ex) // Exception ex ist eine recht ungenau Fehlermeldung
            {
                lblAnzeige.Text = "Fehler: allgemein";
            }
        }


        private void frmÜZahlenraten_Load(object sender, EventArgs e)  //füllt ComboBox
        {
            cbLevel.Items.Add("Level 1: 1 - 100");
            cbLevel.Items.Add("Level 2: 1 - 200");
            cbLevel.Items.Add("Level 3: 1 - 300");
        }

        private void txtEingabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
