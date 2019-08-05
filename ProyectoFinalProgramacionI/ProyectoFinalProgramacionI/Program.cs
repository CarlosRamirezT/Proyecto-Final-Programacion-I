using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgramacionI
{ 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Clase principal de todo el proyecto
        /// ejectuta el metodo Main()
        /// inicializando los estilos visuales y corriendo
        /// el winform inicial de la navegacion
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formInicio());
        }
    }
}
