using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionI
{
    class Formato
    {
        /* evalua si una cadena tiene caracteres especiales
         * recive una cadena de tipo String
         * devuelve true si tiene caracteres especiales
         * devuelve false si no tiene caracteres especiales */
        public static bool TieneCaracterEspecial(string entrada)
        {
            string specialChar = "@\\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (entrada.Contains(item)) return true;
            }

            return false;
        }

        /* valida una cadena de tipo String que representa una actividad
         * devuelve true si cumple:
         *      no tener caracteres especiales
         *      no ser nula
         *      no ser una cadena vacia
         * devuelve false si no cumple los requerimientos */
        public static bool ValidarActividad(string entrada)
        {
            // si la actividad contiene alguno de estos caracteres especiales no es valida
            string caracterEspecial = "#%&/()-";
            foreach (var item in caracterEspecial)
            {
                if (entrada.Contains(item))
                {
                    Console.WriteLine("Error: La actividad contiene una caracter especial no valido = " + item);
                    return false;
                }
            }
            // si la actividad es nula o una cadena vacia no es valida
            if (entrada == null || entrada.Trim() == "")
            {
                Console.WriteLine("Error: La actividad es nula o una cadena vacia");
                return false;
            }
            return true;
        }

        /* valida una cadena de tipo string que representa un nombre
         * recibe el nombre
         * retorna true si cumple con los requisitos:
         *      no tener caracteres numericos
         *      no ser nula
         *      no ser una cadena vacia
         *      no tener caracteres especiales 
         * retorna false si no se cumplen los requisitos */
        public static bool ValidarNombre(string entrada)
        {
            if (entrada.Any(char.IsDigit))
            {
                Console.WriteLine("Error: El nombre es un numero");
                return false;
            }
            if (entrada == null)
            {
                Console.WriteLine("Error: El nombre es nula");
                return false;
            }
            if (entrada.Trim() == "")
            {
                Console.WriteLine("Error: El nombre es una cadena vacia");
                return false;
            }
            if (Formato.TieneCaracterEspecial(entrada))
            {
                Console.WriteLine("Error: El nombre tiene un caracter no valido ");
                return false;
            }
            Console.WriteLine("Nombre validado exitosamente: " + entrada);
            return true;
        }

        /* valida una cadena que representa una fecha
         * recive la fecha
         * retorna true si cumple los requisitos:
         *      no tener caracteres especiales que no sean /
         *      no tener letras
         *      debe tener /
         *      no ser nula
         *      no ser una cadena vacia
         *      la primera subcadena debe ser el año
         *      la segunda subcadena debe ser el mes
         *      la tercera cadena debe ser el dia
         *      el año debe estar entre 2019 y 99999 inclusive
         *      el mes debe estar entre 1 y 12 inclusive
         *      el dia debe estar entre 1 y 31 inclusive 
         * retorna falso si no se cumplen los requisitos */
        public static bool ValidarFecha(string entrada)
        {
            string caracterEspecial = "@\\|!#$%&()=?»«@£§€{}.;'<>_,-abcdefghijklmnñopqrstuvwxyz";
            foreach (var item in caracterEspecial)
            {
                if (entrada.Contains(item))
                {
                    Console.WriteLine("Error: La fecha contiene una caracter especial no valido = " + item);
                    return false;
                }
            }
            // si no contiene / entonces no es una fecha valida
            if (!entrada.Contains("/"))
            {
                Console.WriteLine("Error: La fecha no contiene /");
                return false;
            }
            // si el valor es nulo o una cadena vacia no es una fecha valida
            if (entrada == null || entrada.Trim() == "")
            {
                Console.WriteLine("Error: la fecha es nula o una cadena vacia");
                return false;
            }
            // validando los tokens
            string[] tokens = entrada.Split('/');
            int year = int.Parse(tokens[0]);
            int month = int.Parse(tokens[1]);
            int day = int.Parse(tokens[2]);
            // si el año no esta entre 2019 y 9999 invalidar
            if (!(year >= 2019 && year <= 9999))
            {
                Console.WriteLine("Error: el año no esta entre 2019 y 1999 inclusive");
                return false;
            }
            // si el mes no esta entre 1 y 12 invalidar
            if (!(month >= 1 && month <= 12))
            {
                Console.WriteLine("Error: el mes no esta entre 1 y 12 inclusive ");
                return false;
            }
            // si el dia no esta entre 1 y 31 invalidar
            if (!(day >= 1 && day <= 31))
            {
                Console.WriteLine("Error: el dia no esta entre 1 y 31 inclusive");
                return false;
            }
            // validacion correta
            Console.WriteLine("Fecha validada exitosamente " + entrada);
            return true;
        }

        /* valida una cadena que representa un telefono
         * recive el telefono
         * retorna true si cumple los requisitos:
         *      no tener caracteres especiales
         *      debe tener -
         *      no tener letras
         *      no ser nula
         *      no ser una cadena vacia
         *      debe contener numeros 
         *      la longitud debe ser de 12 o 14
         *      entonces cumplir con el formato 1-829-879-3273 o 829-879-3273
         * retorna falso si no se cumplen los requisitos */
        public static bool ValidarTelefono(string entrada)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.;'<>_,abcdefghijklmnñopqrstuvwxyz";
            foreach (var item in specialChar)
            {
                if (entrada.Contains(item))
                {
                    Console.WriteLine("Error: El telefono contiene un caracter no valido: " + item);
                    return false;
                }
            }
            if (entrada == null)
            {
                Console.WriteLine("Error: El telefono es nulo");
                return false;
            }
            if (entrada.Trim() == "")
            {
                Console.WriteLine("Error: El telefono es una cadena vacia");
                return false;
            }
            if (!entrada.Contains("-"))
            {
                Console.WriteLine("Error: el telefono no contiene -");
                return false;
            }
            if (!entrada.Any(char.IsDigit))
            {
                Console.WriteLine("Error: el telefono no contiene ningun numero");
                return false;
            }
            if(!(entrada.Length == 12 || entrada.Length == 14))
            {
                Console.WriteLine("El numero no tiene la longitud adecuada");
                return false;
            }
            Console.WriteLine("Telefono validado exitosamente: " + entrada);
            return true;
        }

        /* valida una cadena que representa un lugar
         * recive el lugar
         * retorna true si cumple los requisitos:
         *      no tener los caracteres especiales indicados
         *      no ser nula
         *      no ser una cadena vacia
         * retorna falso si no se cumplen los requisitos */
        public static bool ValidarLugar(string entrada)
        {
            string caracterEspecial = "\\%=?»«.'";
            foreach (var item in caracterEspecial)
            {
                if (entrada.Contains(item))
                {
                    Console.WriteLine("Error: El lugar contiene un caracter no valido: " + item);
                    return false;
                }
            }
            if (entrada == null)
            {
                Console.WriteLine("Error: El lugar es nulo");
                return false;
            }
            if (entrada.Trim() == "")
            {
                Console.WriteLine("Error: El lugar es una cadena vacia");
                return false;
            }
            return true;
        }

        /* valida una cadena que representa una hora
         * recive la hora
         * retorna true si cumple los requisitos:
         *      no tener caracteres especiales
         *      tener :
         *      no ser nula
         *      no ser una cadena vacia
         *      la primera subcadena debe ser la hora
         *      la segunda subcadena deben ser los minutos
         *      la tercera subcadena deben ser los segundos
         *      la hora debe estar entre 1 y 24 inclusive
         *      los minutos deben estar entre 0 y 60 inclusive
         *      los segundos deben estar entre 0 y 60 inclusive
         *      cumpliendo con el formato HH:mm:ss o HH:mm
         * retorna falso si no se cumplen los requisitos */
        public static bool ValidarHora(string entrada)
        {
            string caracterEspecial = "@\\/|!#$%&()=?»«@£§€{}.;'<>_,abcdefghijklmnñopqrstuvwxyz";
            foreach (var item in caracterEspecial)
            {
                if (entrada.Contains(item))
                {
                    Console.WriteLine("Error: La hora contiene un caracter no valido: " + item);
                    return false;
                }
            }
            // si no contiene : entonces no es una hora valida
            if (!entrada.Contains(":"))
            {
                Console.WriteLine("Error: La hora no contiene :");
                return false;
            }
            if (entrada == null)
            {
                Console.WriteLine("Error: La hora es nula");
                return false;
            }
            if (entrada.Trim() == "")
            {
                Console.WriteLine("Error: La hora es una cadena vacia");
                return false;
            }
            // validando los tokens
            string[] tokens = entrada.Split(':');
            int hora = 0;
            int minutos = 0;
            int segundos = 0;
            try
            {
                hora = int.Parse(tokens[0]);
                minutos = int.Parse(tokens[1]);
                segundos = int.Parse(tokens[2]);
            }
            catch (Exception exception)
            {
                Console.WriteLine("No se pudieron obtener alguno de los datos de la hora");
                Console.WriteLine(exception.Message);
            }
            // si la hora no esta entre 1 y 24 invalidar
            if (!(hora >= 1 && hora <= 24))
            {
                Console.WriteLine("Error: la hora no esta entre 1 y 24 inclusive");
                return false;
            }
            // si los minutos no estan entre 0 y 60 invalidar
            if (!(minutos >= 0 && minutos <= 60))
            {
                Console.WriteLine("Error: los minutos no estan entre 0 y 60 inclusive");
                return false;
            }
            // si los segundos no estan entre 1 y 60 invalidar
            if (!(segundos >= 0 && segundos <= 60))
            {
                Console.WriteLine("Error: los segundos no estan entre 0 y 60 inclusive");
                return false;
            }
            Console.WriteLine("Hora validada exitosamente");
            return true;
        }

        /* valida una cadena que representa un email
         * recive el email
         * retorna true si cumple los requisitos:
         *      debe tener arroba
         *      no puede ser nulo
         *      no puede ser una cadena vacia
         * retorna falso si no se cumplen los requisitos */
        public static bool ValidarEmail(string entrada)
        {
            if (entrada == null)
            {
                Console.WriteLine("Error: El email es nulo");
                return false;
            }
            if (entrada.Trim() == "")
            {
                Console.WriteLine("Error: El email esta vacio");
                return false;
            }
            string specialChar = "@";
            if (!entrada.Contains(specialChar))
            {
                Console.WriteLine("Error: El email no contiene @");
                return false;
            }
            Console.WriteLine("Email validado exitosamente: " + entrada);
            return true;
        }

        /* valida una cadena que representa una direccion
         * recive la direccion
         * retorna true si cumple los requisitos:
         *      no tener los caracteres especiales declarados
         *      no ser nula
         *      no ser una cadena vacia
         * retorna falso si no se cumplen los requisitos */
        public static bool ValidarDireccion(string entrada)
        {
            if (entrada == null)
            {
                Console.WriteLine("Error: La direccion es nula");
                return false;
            }
            if (entrada.Trim() == "")
            {
                Console.WriteLine("Error: La direccion es una cadena vacia");
                return false;
            }
            string caracterEspecial = "@\\|!#$%&/()=?»«@£§€{}.;'<>_";
            foreach (var item in caracterEspecial)
            {
                if (entrada.Contains(item))
                {
                    Console.WriteLine("Error: La direccion contiene una caracter especial no valido = " + item);
                    return false;
                }
            }
            return true;
        }
    }
}
