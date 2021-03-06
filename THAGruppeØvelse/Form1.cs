using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.IO;

namespace THAGruppeØvelse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string MedlemsNr = mTxtBMedlemNr.Text;
            string Navn = mTxtBNavn.Text;
            string Adresse = mTxtBAdresse.Text;

            string errorMessage = "";

            // assumption:
            bool MedlemsNr_ok = true, Navn_ok = true, Adresse_ok = true;

            // length check:
            if (MedlemsNr.Length != 3) 
            {
                MedlemsNr_ok = false;
                errorMessage += "\nDer må kun indtastes tal i Medlems nr. feltet, samt maks 3 cifre.";
            }

            if (Navn.Length > 20 || Navn.Length < 2)
            {
                Navn_ok = false;
                errorMessage += "\nDer skal minimum være 2 tegn og maks 20 tegn i Navn feltet.";
            }

            if (Adresse.Length > 50 || Adresse.Length < 2)
            {
                Adresse_ok = false;
                errorMessage += "\nDer skal minimum være 2 tegn og maks 50 tegn i Adresse feltet.";
            }

            // "<" check for JS tags ... NO cross site scripting here.:
            if (MedlemsNr.Contains("'"))
            {
                MedlemsNr_ok = false;
                errorMessage += "\nMedlems feltet må ikke indeholde ' .";
            }

            if (Navn.Contains("'"))
            {
                Navn_ok = false;
                errorMessage += "\nNavn feltet må ikke indeholde ' .";
            }

            if (Adresse.Contains("'"))
            {
                Adresse_ok = false;
                errorMessage += "\nAdresse feltet må ikke indeholde ' .";
            }

            if (MedlemsNr.Contains("<"))
            {
                MedlemsNr_ok = false;
                errorMessage += "\nMedlems feltet må ikke indeholde < .";
            }

            if (Navn.Contains("<"))
            {
                Navn_ok = false;
                errorMessage += "\nNavn feltet må ikke indeholde < .";
            }

            if (Adresse.Contains("<"))
            {
                Adresse_ok = false;
                errorMessage += "\nAdresse feltet må ikke indeholde < .";
            }

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(MedlemsNr))
            {
                MedlemsNr_ok = false;
                errorMessage += "\nMedlems nr feltet må indeholde tal.";
            }

            // action
            if (MedlemsNr_ok && Navn_ok && Adresse_ok)
            {
                try
                {
                    MessageBox.Show($"Medlem er oprettet med følgende oplysninger: \nMedlems Nr: {MedlemsNr}" +
                        $"\nNavn: {Navn}" +
                        $"\nAdresse: {Adresse}");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mTxtBMedlemNr.Text = "";
                    mTxtBNavn.Text = "";
                    mTxtBAdresse.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string MedlemsNr = mTxtBMedlemNr.Text;
            string Navn = mTxtBNavn.Text;
            string Adresse = mTxtBAdresse.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MedlemsNr = mTxtBMedlemNr.Text;
            string Navn = mTxtBNavn.Text;
            string Adresse = mTxtBAdresse.Text;

            // assumption:
            bool MedlemsNr_ok = true, Navn_ok = true, Adresse_ok = true;

            // length check:
            if (MedlemsNr.Length != 3) MedlemsNr_ok = false;
            if (Navn.Length > 20 || Navn.Length < 2) Navn_ok = false;
            if (Adresse.Length > 50 || Adresse.Length < 2) Adresse_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (MedlemsNr.Contains("'")) MedlemsNr_ok = false;
            if (Navn.Contains("'")) Navn_ok = false;
            if (Adresse.Contains("'")) Adresse_ok = false;
            if (MedlemsNr.Contains("<")) MedlemsNr_ok = false;
            if (Navn.Contains("<")) Navn_ok = false;
            if (Adresse.Contains("<")) Adresse_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(MedlemsNr)) MedlemsNr_ok = false;

            // action
            if (MedlemsNr_ok && Navn_ok && Adresse_ok)
            {
                try
                {
                    MessageBox.Show($"Medlem er opdateret til følgende oplysninger: \nMedlems Nr: {MedlemsNr}" +
                        $"\nNavn: {Navn}" +
                        $"\nAdresse: {Adresse}");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mTxtBMedlemNr.Text = "";
                    mTxtBNavn.Text = "";
                    mTxtBAdresse.Text = "";
                }
            }
            else if (!MedlemsNr_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Medlems nr. feltet, samt maks 3 tegn.");
                mTxtBMedlemNr.Text = "";
                mTxtBNavn.Text = "";
                mTxtBAdresse.Text = "";
            }

            else if (!Navn_ok)
            {
                MessageBox.Show("Der skal minimum være 2 tegn og maks 20 tegn i Navn feltet.");
                mTxtBMedlemNr.Text = "";
                mTxtBNavn.Text = "";
                mTxtBAdresse.Text = "";
            }

            else if (!Adresse_ok)
            {
                MessageBox.Show("Der skal minimum være 2 tegn og maks 50 tegn i Adresse feltet.");
                mTxtBMedlemNr.Text = "";
                mTxtBNavn.Text = "";
                mTxtBAdresse.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MedlemsNr = mTxtBMedlemNr.Text;

            // assumption:
            bool MedlemsNr_ok = true, Navn_ok = true, Adresse_ok = true;

            // length check:
            if (MedlemsNr.Length != 3) MedlemsNr_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (MedlemsNr.Contains("'")) MedlemsNr_ok = false;
            if (MedlemsNr.Contains("<")) MedlemsNr_ok = false;


            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(MedlemsNr)) MedlemsNr_ok = false;

            // action
            if (MedlemsNr_ok && Navn_ok && Adresse_ok)
            {
                try
                {
                    MessageBox.Show($"Medlem er slettet til følgende oplysninger: \nMedlems Nr: {MedlemsNr}");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    mTxtBMedlemNr.Text = "";
                    mTxtBNavn.Text = "";
                    mTxtBAdresse.Text = "";
                }
            }
            else if (!MedlemsNr_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Medlems nr. feltet, samt maks 3 tegn.");
                mTxtBMedlemNr.Text = "";
                mTxtBNavn.Text = "";
                mTxtBAdresse.Text = "";
            }
        }
    }
}
