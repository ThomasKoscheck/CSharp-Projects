using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shutdown
{
    public partial class frmShutdown : Form
    {
        public frmShutdown()
        {
            InitializeComponent();
        }    

        //Bricht das Herunterfahren/Neustarten ab
        private void cmdAbbrechen_Click(object sender, EventArgs e)
        {
            Process pro = Process.Start("shutdown", " -a ");
            lblAktion.Text = "";
            lblError.Text = "";
            lblError.Text = "Aktion abgebrochen";
        }

        private void cmdHerunterfahren_Click(object sender, EventArgs e)
        {
            try
            {
                //Falls keine Zeit eingegeben wurde
                if (txtZeitH.Text == "")
                {
                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblError.Text = "Bitte Zeit eingeben";
                }

                else
                {
                    //Umrechnung der Zeiteingabe in Sekunden
                    int teingabe = Convert.ToInt32(txtZeitH.Text);
                    teingabe = teingabe * 60;

                    //Starten des Herunterfahrens über CMD-Befehl
                    Process pro = Process.Start("shutdown", " -s -f -t " + teingabe);

                    //Berechnung der Zeit, zu der der PC heruntergefahren wird
                    System.DateTime today = System.DateTime.Now;
                    System.TimeSpan duration = new System.TimeSpan(0, 0, 0, teingabe);
                    System.DateTime answer = today.Add(duration);

                    //Ausgabe aller Daten + Warnung
                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblAktion.Text = "Computer wird um " + answer + " heruntergefahren.";
                    lblError.Text = "Bitte alle Daten speichern!";

                }
            }

            catch (FormatException)  //Exception für falsche Eingabeformate
            {
                lblAktion.Text = "";
                lblError.Text = "";
                lblError.Text = "Fehler: falsches Eingabeformat";            
            }

            catch (Exception ex) //Exception ex ist eine recht ungenaue Fehlermeldung
            {   
                lblAktion.Text = "";        //leeren des Textfelds, falls vorher bereits benutzt
                lblError.Text = "";
                lblError.Text = "Fehler: allgemein";
                lblError.Text += "\nMehr Details: " + ex;
            }
        }

        private void cmdNeustart_Click(object sender, EventArgs e)
        {
            try {

                //Falls keine Zeit eingegeben wurde
                if (txtZeitN.Text == "")
                {
                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblError.Text = "Bitte Zeit eingeben";
                }

                else
                {
                    //Umrechnung der Zeiteingabe in Sekunden
                    int teingabe = Convert.ToInt32(txtZeitN.Text);
                    teingabe = teingabe * 60;

                    //Starten des Neustarts über CMD-Befehl
                    Process pro = Process.Start("shutdown",  " -r -f -t " + teingabe);

                    //Berechnung der Zeit, zu der der PC neugestartet wird
                    System.DateTime today = System.DateTime.Now;
                    System.TimeSpan duration = new System.TimeSpan(0, 0, 0, teingabe);
                    System.DateTime answer = today.Add(duration);

                    //Ausgabe aller Daten + Warnung
                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblAktion.Text = "Computer wird um " + answer + " neugestartet.";
                    lblError.Text = "Bitte alle Daten speichern!";
                }
            }


            catch (FormatException)   //Exception für falsche Eingabeformate
            {
                lblError.Text = "Fehler: falsches Eingabeformat";
            }

            catch (Exception ex)    // Exception ex ist eine recht ungenau Fehlermeldung
            {
                lblError.Text = "Fehler: allgemein";
                lblError.Text += "\nMehr Details: " + ex;
            }
        }
    }
}
