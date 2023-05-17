using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleEarthBank
{
    public partial class Loan : Form
    {
        string clientName;
        string[] races = { "Hobbit", "Elfo", "Enano", "Humano", "Mago", "Orco", "Ent", "Eladrin" };
        int[] installmentCounts = { 6, 12, 18, 24, 36 };
        string[] places;
        Dictionary<int, double> intereses;

        public Loan(string name)
        {
            InitializeComponent();
            clientName = name;

            string placesList = Properties.Resources.lugares.ToString();
            places = placesList.Split(new[] {"/r/n"}, StringSplitOptions.RemoveEmptyEntries);

            intereses = new Dictionary<int, double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < installmentCounts.Length; i++, interes += 0.5)
            {
                intereses[installmentCounts[i]] = interes;
            }
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularraces();
            popularCity();
            Welcome.Text += clientName;
        }

        void popularCuotas()
        {
            for (int i = 0; i < installmentCounts.Length; i++)
            {
                comboBox3.Items.Add(installmentCounts[i]);
            }
        }

        void popularraces()
        {
            for (int i = 0; i < races.Length; i++)
            {
                Race.Items.Add(races[i]);
            }
        }

        void popularCity()
        {
            for(int i = 0; i < places.Length; i++)
            {
                Birdthplace.Items.Add(places[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotas_pedidas = (int)comboBox3.SelectedItem;
            string raza_seleccionada = Race.SelectedItem.ToString().ToLower();
            string lugar_seleccionado = Birdthplace.SelectedItem.ToString().ToLower();
            double interes = intereses[cuotas_pedidas];

            if (new[] { "orco", "ent", "eladrin" }.Contains(raza_seleccionada))
            {
                interes += 0.3;
            }

            if (new[] { "rivendell", "tirion", "hobbiton" }.Contains(lugar_seleccionado))
            {
                interes -= 0.3;
            }
            return interes;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=lY1Z0Hgo288&ab_channel=Programaci%C3%B3nDesdeCero
            /*
             Faltan la ultima validacion. Continuar desde el minuto 1.10.00
             */

            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(DatosPersonales, "");
                        errorProvider1.SetError(DatosPrestamo, "");
                        double interes_mensual = calcularInteres();
                        double monto_pedido = double.Parse(monto.Text);
                        int cuotas_pedidas = (int)cuotas.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su préstamo por " + monto_pedido + " en " + cuotas_pedidas + " cuotas se concederá con un interés del " + interes_mensual + "% mensual.\nEl monto final asciende a " + monto_a_pagar;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", botones);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DatosPrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(DatosPrestamo, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(DatosPersonales, "");
                        break;
                    }
            }

            int validaciones()
            {
                if ((razas.SelectedIndex <= -1) || (lugares.SelectedIndex <= -1))
                {
                    return 1;
                }
                else
                {
                    if (!(monto.Text.All(Char.IsDigit)) || (monto.Text == "") || (cuotas.SelectedIndex <= -1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
