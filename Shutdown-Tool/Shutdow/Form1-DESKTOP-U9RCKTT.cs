using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Shutdow
{
    public partial class frmShutdown : Form
    {
        public frmShutdown()
        {
            InitializeComponent();
        }    

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
              if (txtZeitH.Text == "")
                {
                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblError.Text = "Bitte Zeit eingeben";
                }

                else
                {
                    int teingabe = Convert.ToInt32(txtZeitH.Text);
                    teingabe = teingabe * 60;

                    Process pro = Process.Start("shutdown", " -s -f -t " + teingabe);

                    System.DateTime today = System.DateTime.Now;
                    System.TimeSpan duration = new System.TimeSpan(0, 0, 0, teingabe);
                    System.DateTime answer = today.Add(duration);

                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblAktion.Text = "Computer wird um " + answer + " heruntergefahren.";
                    lblError.Text = "Bitte alle Daten speichern!";

                }
            }

            catch (FormatException ex)  //Exception für falsche Eingabeformate
            {
                lblAktion.Text = "";
                lblError.Text = "";
                lblError.Text = "Fehler: falsches Eingabeformat";            
            }

            catch (Exception ex) //Exception ex ist eine recht ungenau Fehlermeldung
            {
                lblAktion.Text = "";
                lblError.Text = "";
                lblError.Text = "Fehler: allgemein";
                lblError.Text += "\nMehr Details: " + ex;
            }
        }

        private void cmdNeustart_Click(object sender, EventArgs e)
        {
            try {

                if (txtZeitN.Text == "")
                {
                    lblAktion.Text = "";
                    lblError.Text = "";
                    lblError.Text = "Bitte Zeit eingeben";
                }

                else
                {
                    int teingabe = Convert.ToInt32(txtZeitN.Text);
                    teingabe = teingabe * 60;

                    Process pro = Process.Start("shutdown",  " -r -f -t " + teingabe);

                    System.DateTime today = System.DateTime.Now;
                    System.TimeSpan duration = new System.TimeSpan(0, 0, 0, teingabe);
                    System.DateTime answer = today.Add(duration);
                    lblError.Text = "";
                    lblAktion.Text = "";
                    lblAktion.Text = "Computer wird um " + answer + " neugestartet.";
                }
            }


            catch (FormatException ex)   //Exception für falsche Eingabeformate
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
