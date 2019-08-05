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
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void buttonContactos_Click(object sender, EventArgs e)
        {
            formContactos contactos = new formContactos();
            contactos.Show();
            this.Visible = false;
        }

        private void buttonEventos_Click(object sender, EventArgs e)
        {
            FormEventos eventos = new FormEventos();
            eventos.Show();
            this.Visible = false;
        }

        private void buttonUtilitarios_Click(object sender, EventArgs e)
        {
            FormUtilitarios utilitarios = new FormUtilitarios();
            utilitarios.Show();
            this.Visible = false;
        }
    }
}
