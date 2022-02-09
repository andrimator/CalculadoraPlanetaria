using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPlanetaria
{
    public partial class FormCalcPlanet : Form
    {
        public FormCalcPlanet()
        {
            InitializeComponent();
            cbxPlaneta.SelectedIndex = 2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(tbxTuPeso.TextLength != 0)
            {
                try
                {
                    double PesoPlaneta = Math.Round(CalcularPesoPlaneta(Convert.ToDouble(tbxTuPeso.Text), cbxPlaneta), 2);
                    string InfoPesoPlaneta = "En " + cbxPlaneta.SelectedItem.ToString() + ", pesarías: " + PesoPlaneta + "kg.";
                    MessageBox.Show(InfoPesoPlaneta, cbxPlaneta.SelectedItem.ToString(), MessageBoxButtons.OK);
                }
                catch (SystemException exception)
                {
                    MessageBox.Show(exception.ToString(), "La calculadora solo funciona con numeros!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("No has ingresado tu peso!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private double CalcularPesoPlaneta(double peso, ComboBox selection)
        {
            peso = peso / 9.81f;
            switch (selection.SelectedItem)
            {
                case "Mercurio":
                    return peso * 3.7f;
                case "Venus":
                    return peso * 8.87f;
                case "Tierra":
                    return peso * 9.81f;
                case "Luna":
                    return peso * 1.62f;
                case "Marte":
                    return peso * 3.721f;
                case "Jupiter":
                    return peso * 24.79f;
                case "Saturno":
                    return peso * 10.44f;
                case "Urano":
                    return peso * 8.87f;
                case "Neptuno":
                    return peso * 11.15f;
                default:
                    break;
            }
            return 0;
        }

        private void tbxTuPeso_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
