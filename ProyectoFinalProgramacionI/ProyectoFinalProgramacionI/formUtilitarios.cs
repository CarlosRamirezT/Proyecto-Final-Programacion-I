using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacionI
{
    public partial class FormUtilitarios : Form
    {
        public FormUtilitarios()
        {
            InitializeComponent();
        }

        private void ConvertirGrados()
        {
            try
            {
                if (comboBoxGrados.SelectedIndex == 0)
                {
                    Convertidor.Celcius = double.Parse(txtGrado1.Text);
                    txtResultado1.Text = Convertidor.ConvertirCelciusFarenheit().ToString();
                }
                else if (comboBoxGrados.SelectedIndex == 1)
                {
                    Convertidor.Farenheit = double.Parse(txtGrado1.Text);
                    txtResultado1.Text = Convertidor.ConvertirFarenheitCelcius().ToString();
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la conversion");
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                txtGrado1.Focus();
            }
        }

        private void ConvertirMoneda()
        {
            try
            {
                if (comboBoxMoneda.SelectedIndex == 0)
                {
                    Convertidor.Dolares = double.Parse(txtMoneda1.Text);
                    txtResultado2.Text = Convertidor.ConvertirDolaresPesos().ToString();
                }
                else if (comboBoxMoneda.SelectedIndex == 1)
                {
                    Convertidor.Pesos = double.Parse(txtMoneda1.Text);
                    txtResultado2.Text = Convertidor.ConvertirPesosDolares().ToString();
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la conversion");
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                txtMoneda1.Focus();
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            formInicio inicio = new formInicio();
            inicio.Show();
            this.Visible = false;
        }

        private void comboBoxGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertirGrados();
        }

        private void comboBoxMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertirMoneda();
        }

        private void buttonConvertir1_Click(object sender, EventArgs e)
        {
            ConvertirGrados();
        }

        private void buttonConvertir2_Click(object sender, EventArgs e)
        {
            ConvertirMoneda();
        }

        private void buttonLimpiar1_Click(object sender, EventArgs e)
        {
            txtGrado1.Clear();
            txtResultado1.Clear();
        }

        private void buttonLimpiar2_Click(object sender, EventArgs e)
        {
            txtMoneda1.Clear();
            txtResultado2.Clear();
        }

        private void buttonLimpiar3_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
