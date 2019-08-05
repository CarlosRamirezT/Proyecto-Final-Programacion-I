using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionI
{
    class DatosException : Exception
    {
        public DatosException()
        {
        }

        public DatosException(string message) : base(message)
        {
        }

        public DatosException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
