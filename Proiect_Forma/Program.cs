using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using LibrarieModele;
using NivelAccesDate;

namespace Proiect_Forma
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista form1 = new Lista();
            form1.Show();
            Application.Run();
        }
    }

    public class Lista : Form
    {
        IStocareData adminMasini = StocareFactory.GetAdministratorStocare();

        private Label lblNumeVanzator;
        private Label lblNumeCumparator;
        private Label lblTip;
        private Label lblAnFabricare;
        private Label lblDataTranzactie;
        private Label lblPret;
        private Label lblOptiune;
        private Label lblCuloare;
        private TextBox txtNumeVanzator;
        private TextBox txtNumeCumparator;
        private TextBox txtTip;
        private TextBox txtAnFabricare;
        private TextBox txtDataTranzactie;
        private TextBox txtPret;
        private TextBox txtOptiune;
        private TextBox txtCuloare;

        private Label lblInfo;
        private Button btnAdaugare;

        private const int LATIME_CONTROL = 150;
        private const int INALTIME_CONTROL = 20;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MAX = 15;

        public Lista()
        {
            this.Size = new System.Drawing.Size(1000, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Administrare Masini";

            lblNumeVanzator = new Label();
            lblNumeVanzator.Width = LATIME_CONTROL;
            lblNumeVanzator.Text = "Nume Vanzator: ";
            lblNumeVanzator.BackColor = Color.Aqua;
            this.Controls.Add(lblNumeVanzator);

            lblNumeCumparator = new Label();
            lblNumeCumparator.Width = LATIME_CONTROL;
            lblNumeCumparator.Text = "Nume Cumparator: ";
            lblNumeCumparator.Top = DIMENSIUNE_PAS_Y;
            lblNumeCumparator.BackColor = Color.Aqua;
            this.Controls.Add(lblNumeCumparator);

            lblTip = new Label();
            lblTip.Width = LATIME_CONTROL;
            lblTip.Text = "Firma + Model: ";
            lblTip.Top = DIMENSIUNE_PAS_Y * 2;
            lblTip.BackColor = Color.Aqua;
            this.Controls.Add(lblTip);

            lblAnFabricare = new Label();
            lblAnFabricare.Width = LATIME_CONTROL;
            lblAnFabricare.Text = "An Fabricare: ";
            lblAnFabricare.Top = DIMENSIUNE_PAS_Y * 3;
            lblAnFabricare.BackColor = Color.Aqua;
            this.Controls.Add(lblAnFabricare);

            lblDataTranzactie = new Label();
            lblDataTranzactie.Width = LATIME_CONTROL;
            lblDataTranzactie.Text = "Data Tranzactie: ";
            lblDataTranzactie.Top = DIMENSIUNE_PAS_Y * 4;
            lblDataTranzactie.BackColor = Color.Aqua;
            this.Controls.Add(lblDataTranzactie);

            lblPret = new Label();
            lblPret.Width = LATIME_CONTROL;
            lblPret.Text = "Pret: ";
            lblPret.Top = DIMENSIUNE_PAS_Y * 5;
            lblPret.BackColor = Color.Aqua;
            this.Controls.Add(lblPret);

            lblOptiune = new Label();
            lblOptiune.Width = LATIME_CONTROL;
            lblOptiune.Text = "Optiuni: ";
            lblOptiune.Top = DIMENSIUNE_PAS_Y * 6;
            lblOptiune.BackColor = Color.Aqua;
            this.Controls.Add(lblOptiune);

            lblCuloare = new Label();
            lblCuloare.Width = LATIME_CONTROL;
            lblCuloare.Text = "Culoare: ";
            lblCuloare.Top = DIMENSIUNE_PAS_Y * 7;
            lblCuloare.BackColor = Color.Aqua;
            this.Controls.Add(lblCuloare);

            lblInfo = new Label();
            lblInfo.Width = LATIME_CONTROL * 3;
            lblInfo.Text = string.Empty;
            lblInfo.Top = DIMENSIUNE_PAS_Y * 9;
            lblInfo.Height = INALTIME_CONTROL * 5;
            lblInfo.BackColor = Color.Aqua;
            this.Controls.Add(lblInfo);

            txtNumeVanzator = new TextBox();
            txtNumeVanzator.Width = LATIME_CONTROL;
            txtNumeVanzator.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 0);
            this.Controls.Add(txtNumeVanzator);

            txtNumeCumparator = new TextBox();
            txtNumeCumparator.Width = LATIME_CONTROL;
            txtNumeCumparator.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtNumeCumparator);

            txtTip = new TextBox();
            txtTip.Width = LATIME_CONTROL;
            txtTip.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 2);
            this.Controls.Add(txtTip);

            txtAnFabricare = new TextBox();
            txtAnFabricare.Width = LATIME_CONTROL;
            txtAnFabricare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 3);
            this.Controls.Add(txtAnFabricare);

            txtDataTranzactie = new TextBox();
            txtDataTranzactie.Width = LATIME_CONTROL;
            txtDataTranzactie.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 4);
            this.Controls.Add(txtDataTranzactie);

            txtPret = new TextBox();
            txtPret.Width = LATIME_CONTROL;
            txtPret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 5);
            this.Controls.Add(txtPret);

            txtOptiune = new TextBox();
            txtOptiune.Width = LATIME_CONTROL;
            txtOptiune.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 6);
            this.Controls.Add(txtOptiune);

            txtCuloare = new TextBox();
            txtCuloare.Width = LATIME_CONTROL;
            txtCuloare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 7);
            this.Controls.Add(txtCuloare);

            btnAdaugare = new Button();
            btnAdaugare.Width = LATIME_CONTROL;
            btnAdaugare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 8 * DIMENSIUNE_PAS_Y);
            btnAdaugare.Text = "Adaugati masina";
            this.Controls.Add(btnAdaugare);

            btnAdaugare.Click += OnButtonAdaugaClicked;
            this.Controls.Add(btnAdaugare);
        }
        private void OnButtonAdaugaClicked(object sender, EventArgs e)
        {
            //string Nume = String.Empty;
            // string Prenume = String.Empty;
            int validare = Validare();

            lblNumeVanzator.ForeColor = Color.LimeGreen;
            lblNumeCumparator.ForeColor = Color.LimeGreen;
            lblTip.ForeColor = Color.LimeGreen;
            lblAnFabricare.ForeColor = Color.LimeGreen;
            lblDataTranzactie.ForeColor = Color.LimeGreen;
            lblPret.ForeColor = Color.LimeGreen;
            lblOptiune.ForeColor = Color.LimeGreen;
            lblCuloare.ForeColor = Color.LimeGreen;

            if (validare == 0)

            {
                Masina s = new Masina(txtNumeVanzator.Text, txtNumeCumparator.Text, txtTip.Text, txtAnFabricare.Text, txtDataTranzactie.Text, txtPret.Text, txtOptiune.Text, txtCuloare.Text);

                lblInfo.Text = s.ConversieLaSir_PentruForma();
                adminMasini.AddMasina(s);

            }
            else
            {

                switch (validare)
                {
                    case 1:
                        lblNumeVanzator.ForeColor = Color.Red;
                        break;
                    case 2:
                        lblNumeVanzator.ForeColor = Color.Red;
                        break;
                    case 3:
                        lblTip.ForeColor = Color.Red;
                        break;
                    case 4:
                        lblAnFabricare.ForeColor = Color.Red;
                        break;
                    case 5:
                        lblDataTranzactie.ForeColor = Color.Red;
                        break;
                    case 6:
                        lblPret.ForeColor = Color.Red;
                        break;
                    case 7:
                        lblOptiune.ForeColor = Color.Red;
                        break;
                    case 8:
                        lblCuloare.ForeColor = Color.Red;
                        break;
                    default:
                        break;
                }

            }
        }
        private int Validare()
        {
            if (txtNumeVanzator.Text == string.Empty || txtNumeVanzator.Text.Length > LUNGIME_MAX)
            {
                return 1;
            }
            else if (txtNumeCumparator.Text == string.Empty || txtNumeCumparator.Text.Length > LUNGIME_MAX)
            {
                return 2;
            }
            else if (txtTip.Text == string.Empty || txtTip.Text.Length > LUNGIME_MAX)
            {
                return 3;
            }
            else if (txtAnFabricare.Text == string.Empty || txtAnFabricare.Text.Length > LUNGIME_MAX)
            {
                return 4;
            }
            else if (txtDataTranzactie.Text == string.Empty || txtDataTranzactie.Text.Length > LUNGIME_MAX)
            {
                return 5;
            }
            else if (txtPret.Text == string.Empty || txtPret.Text.Length > LUNGIME_MAX)
            {
                return 6;
            }
            else if (txtOptiune.Text == string.Empty || txtOptiune.Text.Length > LUNGIME_MAX)
            {
                return 7;
            }
            else if (txtCuloare.Text == string.Empty || txtCuloare.Text.Length > LUNGIME_MAX)
            {
                return 8;
            }


            return 0;
        }
    }
}
