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
    public partial class FormEventos : Form
    {
        ConexionEventos conexionEventos = new ConexionEventos();

        public FormEventos()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            try
            {
                dataGridView1.DataSource = conexionEventos.LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        public void Limpiar()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    ((TextBox)tool).Clear();
                }
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            formInicio inicio = new formInicio();
            inicio.Show();
            this.Visible = false;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionEventos.Actividad = txtActividad.Text;
                conexionEventos.Fecha = txtFecha.Text;
                conexionEventos.Hora = txtHora.Text;
                conexionEventos.Lugar = txtLugar.Text;
                conexionEventos.Insertar();
                MessageBox.Show("Evento insertado correctamente");
                Limpiar();
                LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionEventos.Actividad = txtActividad.Text;
                conexionEventos.Fecha = txtFecha.Text;
                conexionEventos.Hora = txtHora.Text;
                conexionEventos.Lugar = txtLugar.Text;
                conexionEventos.Actualizar();
                MessageBox.Show("Comando actualizar ejecutado correctamente");
                Limpiar();
                LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionEventos.Actividad = txtActividad.Text;
                conexionEventos.Borrar();
                MessageBox.Show("Comando borrar ejecutado correctamente");
                Limpiar();
                LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LlenarGrid();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = conexionEventos.Buscar(txtFecha2.Text);
                MessageBox.Show("Comando buscar ejecutado correctamente");
                Limpiar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
