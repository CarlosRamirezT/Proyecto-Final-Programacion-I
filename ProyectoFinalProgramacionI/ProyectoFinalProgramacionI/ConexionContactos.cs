using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinalProgramacionI
{
    /* define la implementacion de la clase abstracta conexion
     * para la tabla de contactos de la base de datos de este
     * proyecto */
    class ConexionContactos : ConexionAbstract
    {

        private string _nombre; // variable que representa el campo nombre de la tabla de la base de datos
        private string _telefono; // variable que representa el campo telefono de la tabla de la base de datos
        private string _email; // variable que representa el campo email de la tabla de la base de datos
        private string _direccion; // variable que representa el campo direccion de la tabla de la base de datos

        /* propiedad que define el comportamiento
         * para asignar el valor a la variable _nombre 
         maneja la exception que pueda ser arrojada 
         por la capa de formato al momento de la validacion*/
        public string Nombre
        {
            set
            {
                if (Formato.ValidarNombre(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new DatosException("El nombre no puede contener ese formato");
                }
            }
        }

        /* propiedad que define el comportamiento para
         * asignar el valor a la variable _telefono
         * maneja la exception que pueda ser arrojada por
         * la capa de formato al momento de la validacion*/
        public string Telefono
        {
            set
            {
                if (Formato.ValidarTelefono(value))
                {
                    _telefono = value;
                }
                else
                {
                    throw new DatosException("El telefono solo puede contener numeros y '-'\n" +
                        "Utilice: 1-829-879-3273 o 829-879-3273");
                }
            }
        }

        /* propiedad que define el comportamiento para
         * asignar el valor a la variable _email
         * maneja la exception que pueda ser arrojada
         * por la capa de formato al momento de la validacion*/
        public string Email
        {
            set
            {
                if (Formato.ValidarEmail(value))
                {
                    _email = value;
                }
                else
                {
                    throw new DatosException("El email debe contener @");
                }
            }
        }

        /* propiedad que define el comportamiento para
         * asignar el valor a la variable _email
         * maneja la exception que pueda ser arrojada
         * por la capa de formato al momento de la validacion*/
        public string Direccion
        {
            set
            {
                if (Formato.ValidarDireccion(value))
                {
                    _direccion = value;
                }
                else
                {
                    throw new DatosException("La direccion no puede contener esos caracteres especiales");
                }
            }
        }

        /* metodo constructor llamado
         * al crear una instancia de esta clase
         * inicializa la coneccion nuevamente
         * utilizando la cadena de conexion 
         * no recive parametros */
        public ConexionContactos()
        {
            _connection = new MySqlConnection(CONNECTION_STRING);
        }
        
        /* implementa la actualizacion de registros 
         * para la table de contactos valiendose del
         * estado de los atributos de esta clase 
         * no recibe parametros 
         */
       public override void Actualizar()
        {
            _connection.Open();
            _query = $"update proyecto_final_p1.contactos set telefono = '{_telefono}', email = '{_email}', direccion = '{_direccion}' where nombre = '{_nombre}';";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        /* implementa el borrado de registros
         * para la tabla de contactos
         * utilizando el email 
         * no recive parametros
         */
        public override void Borrar()
        {
            _connection.Open();
            _query = $"delete from proyecto_final_p1.contactos where email = '{_email}';";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        public override DataTable Buscar(string nombreOrEmail)
        {
            _connection.Open();
            _query = $"SELECT * FROM proyecto_final_p1.contactos where nombre = '{nombreOrEmail}' or email = '{nombreOrEmail}';";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            MySqlDataAdapter data = new MySqlDataAdapter(_command);
            DataTable table = new DataTable();
            data.Fill(table);
            _connection.Close();
            return table;
        }

        /* implementa el comportamiento 
         * para la insercion de registros
         * en la tabla contactos de la 
         * base de datos valiendose del
         * estado de los atributos de 
         * esta clase, no recive parametros */
        public override void Insertar()
        {
            _connection.Open();
            _query = $"INSERT INTO proyecto_final_p1.contactos (nombre, telefono, email, direccion) VALUES ('{_nombre}', '{_telefono}', '{_email}', '{_direccion}');";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        /* implementa el comportamiento para obtener todos
         * los campos y registros de la tabla de contactos
         * no recive parametros y retorna un DataGrid con
         * todos los campos y registros */
        public override DataTable LlenarGrid()
        {
            _connection.Open();
            _query = "select * from proyecto_final_p1.contactos;";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            MySqlDataAdapter data = new MySqlDataAdapter(_command);
            DataTable table = new DataTable();
            data.Fill(table);
            _connection.Close();
            return table;
        }
    }
}
