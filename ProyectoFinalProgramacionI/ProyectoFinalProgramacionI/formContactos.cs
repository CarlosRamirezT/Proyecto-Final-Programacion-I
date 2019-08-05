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
    public partial class formContactos : Form
    {
        ConexionContactos conexionContactos = new ConexionContactos();

        public formContactos()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            try
            {
                dataGridView1.DataSource = conexionContactos.LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void Limpiar()
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
                conexionContactos.Nombre = txtNombre.Text;
                conexionContactos.Telefono = txtTelefono.Text;
                conexionContactos.Email = txtEmail.Text;
                conexionContactos.Direccion = txtDireccion.Text;
                conexionContactos.Insertar();
                MessageBox.Show("Contacto Insertado Exitosamente a la base de datos");
                Limpiar();
                LlenarGrid();
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionContactos.Nombre = txtNombre.Text;
                conexionContactos.Telefono = txtTelefono.Text;
                conexionContactos.Email = txtEmail.Text;
                conexionContactos.Direccion = txtDireccion.Text;
                conexionContactos.Actualizar();
                MessageBox.Show("Contacto Actualizado Exitosamente en la base de datos");
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
                conexionContactos.Email = txtEmail.Text;
                conexionContactos.Borrar();
                MessageBox.Show("Se ha ejecutado el comando borrar Exitosamente en la base de datos");
                Limpiar();
                LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        { 
            try
            {
                dataGridView1.DataSource = conexionContactos.Buscar(txtEmailName.Text);
                MessageBox.Show("Se ha ejecutado el comando buscar Exitosamente en la base de datos");
                Limpiar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                LlenarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
