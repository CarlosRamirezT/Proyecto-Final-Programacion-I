using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionI
{
    /* clase que define los metodos y atributos
     * necesarios para hacer conversion de
     * grados y monedas */
    static class Convertidor
    {
        // variables estaticas de la clase
        static double _celcius;
        static double _farenheit;
        static double _dolares;
        static double _pesos;

        /* define el conportamiento para 
         * asignar el valor a la variable _celcius */
        public static double Celcius
        {
            set
            {
                _celcius = value;
            }
        }

        /* define el comportamiento
         * para asignar el valor a la variable _farenheit */
        public static double Farenheit
        {
            set
            {
                _farenheit = value;
            }
        }

        /* define el comportamiento para asignar valor
         * a la variable _dolares y en caso de no cumplir los
         * requerimientos lanza una exception de tipo DatosException */
        public static double Dolares
        {
            set
            {
                if(value >= 0)
                {
                    _dolares = value;
                }else if(value < 0)
                {
                    throw new DatosException("No puede ingresar una moneda negativa");
                }
            }
        }

        /* define el comportamiento para asignar valor
         * a la variable _pesos y en caso de no cumplir los
         * requerimientos lanza una exception de tipo DatosException */
        public static double Pesos
        {
            set
            {
                if (value >= 0)
                {
                    _pesos = value;
                }
                else if (value < 0)
                {
                    throw new DatosException("No puede ingresar una moneda negativa");
                }
            }
        }

        /* convierte de celcius a farenheit
         * no recive valor
         * usa el atributo _celcius
         * devuelve los grados celcius convertidos a farenheit */
        public static double ConvertirCelciusFarenheit()
        {
            return (_celcius * 1.8) + 32;
        }

        /* no recive valor
         * utiliza el atributo _farenheit
         * devuelve los grados farenheit convertidos a celcius */
        public static double ConvertirFarenheitCelcius()
        {
            return (_farenheit - 32) / 1.8;
        }

        /* no recive valor 
         * utiliza el atributo _dolares
         * retorna los dolares convertidos a pesos */
        public static double ConvertirDolaresPesos()
        {
            return _dolares * 51.07;
        }

        /* no recive valor
         * utiliza el atributo _pesos
         * retorna los pesos convertidos a dolares */
        public static double ConvertirPesosDolares()
        {
            return _pesos / 51.07;
        }
    }
}
