using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Anualidades : Form
    {
        public Anualidades()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Seleccionar":
                    MessageWarning("Seleccionar una de las opciones que quiera calcular...");
                    break;
                case "Anualidad vencida":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularAnualidadvencida();

                    }
                    break;
                case "Anualidad anticipada":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularAnualidadanticipada();

                    }
                    break;
                case "Anualidad diferida":
                    if (txtPrimeraCuota.Text == "0" || txtTipoInteres.Text == "0" || txtIngresos.Text == "0")
                    {
                        MessageWarning("Un campo se encuentra vacío");
                    }
                    else
                    {
                        CalcularAnualidaddiferida();
                    }
                    break;
                default:
                    MessageWarning("Seleccionar una opcion valida...!");
                    cmbCalcular.Text = "Seleccionar";
                    break;
            }
        }

        private void MessageWarning(string str)
        {
            MessageBox.Show(str, "Anualidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnReset_Click1(object sender, EventArgs e)
        {
            txtIngresos.Text = "0";
            txtPrimeraCuota.Text = "0";
            txtResultado.Text = "0";
            txtTipoInteres.Text = "0";
            cmbCalcular.Text = "Seleccionar";
            cmbTiempo.Text = "Seleccionar";
            lblResultFormula.Text = "";
            lineCF.Visible = false;
        }

        private void cmbCalcular_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCalcular.Text)
            {
                case "Anualidad vencida":
                    lineCF.Visible = false;
                    lblResultadoFormula.Text = "";
                    break;
                case "Anualidad anticipada":
                    lineCF.Visible = false;
                    lblResultadoFormula.Text = "";
                    break;
                case "Anualidad diferida":
                    lineCF.Visible = false;
                    lblResultadoFormula.Text = "";
                    break;
            }
        }

        private void Anualidades_Load(object sender, EventArgs e)
        {

        }

        public void CalcularAnualidadvencida()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);

            double P = a * ((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n)));
            txtResultado.Text = P.ToString("N2");
        }

        public void CalcularAnualidadanticipada()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);

            double VP = a * (((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n))) * (1 + i));
            txtResultado.Text = VP.ToString("N2");
        }

        public void CalcularAnualidaddiferida()
        {
            double a = double.Parse(txtPrimeraCuota.Text);
            double i = double.Parse(txtTipoInteres.Text) / 100;
            double n = double.Parse(txtIngresos.Text);

            // Cálculo del Valor Presente (VP)
            double VP = a * (((Math.Pow(1 + i, n) - 1) / (i * Math.Pow(1 + i, n))));

            // Cálculo del Valor Presente de la Anualidad Diferida (VPN)
            double VPN = VP / Math.Pow(1 + i, n);
            txtResultado.Text = VPN.ToString("N2");
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void panelFormula_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
