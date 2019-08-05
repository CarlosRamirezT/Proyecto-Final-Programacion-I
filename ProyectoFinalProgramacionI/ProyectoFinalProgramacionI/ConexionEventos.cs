using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgramacionI
{
    class ConexionEventos : ConexionAbstract
    {
        
        private string _actividad; // representa el campo actividad de la tabla eventos
        private string _fecha; // representa el campo fecha de la tabla de eventos
        private string _hora; // representa el campo de hora de la tabla de eventos
        private string _lugar; // representa el campo de lugar de la table de eventos

        /* propiedad que define el comportamiento
         * para poder asignar el valor a la variable
         * _actividad, maneja las exceptions que
         * pueda arrojar la capa de formato al
         * momento de la validacion */
        public string Actividad
        {
            set
            {
                if (Formato.ValidarActividad(value))
                {
                    _actividad = value;
                }
                else
                {
                    throw new DatosException("La actividad no puede tener este formato");
                }
            }
        }

        /* propiedad que define el comportamiento
         * para poder asignar el valor a la variable
         * _fecha, maneja las exceptions que
         * pueda arrojar la capa de formato al
         * momento de la validacion */
        public string Fecha
        {
            set
            {
                if (Formato.ValidarFecha(value))
                {
                    _fecha = value;
                }
                else
                {
                    throw new DatosException("La fecha no puede tener ese formato,\n" +
                        "Utilize: yyyy/mm/dd => año/mes/dia\n" +
                        "--> A partir del 2019 hasta el 9999 <--");
                }
            }
        }

        /* propiedad que define el comportamiento
         * para poder asignar el valor a la variable
         * _hora, maneja las exceptions que
         * pueda arrojar la capa de formato al
         * momento de la validacion */
        public string Hora
        {
            set
            {
                if (Formato.ValidarHora(value))
                {
                    _hora = value;
                }
                else
                {
                    throw new DatosException("La hora no puede tener ese formato,\n" +
                        "Utilize: hh:mm:ss => hora:minutos:segundos\n" +
                        "O Tambien: hh:mm => hora:minutos\n" +
                        "--> hora desde 1 hasta 24 <--");
                }
            }
        }

        /* propiedad que define el comportamiento
         * para poder asignar el valor a la variable
         * _actividad, maneja las exceptions que
         * pueda arrojar la capa de formato al
         * momento de la validacion */
        public string Lugar
        {
            set
            {
                if (Formato.ValidarLugar(value))
                {
                    _lugar = value;
                }
                else
                {
                    throw new DatosException("El lugar no puede tener ese formato");
                }
            }
        }

        /* constructor llamado al crear una instancia de la clase
         * no recive parametros
         * inicializa la conection a la base de datos */
        public ConexionEventos()
        {
            _connection = new MySqlConnection(CONNECTION_STRING);
        }

        /* implementa el comportamiento para actualizar
         * registros de la tabla eventos de la base de
         * datos */
        public override void Actualizar()
        {
            _connection.Open();
            _query = $"UPDATE proyecto_final_p1.eventos SET fecha = '{_fecha}', hora = '{_hora}', lugar = '{_lugar}' WHERE actividad = '{_actividad}';";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        /* implementa el comportamiento para borrar 
         * registros de la table eventos de la base
         * de datos valiendose del estado de la variable
         * _actividad */
        public override void Borrar()
        {
            _connection.Open();
            _query = $"DELETE FROM proyecto_final_p1.eventos WHERE actividad = '{_actividad}';";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        /* implementa el comportamiento para
         * recuperar registros especificos de 
         * la tabla eventos de la base de datos
         * recive la fecha
         * y devuelve un DataTable con todos los
         * campos y registros que coincidan */
        public override DataTable Buscar(string fecha)
        {
            _connection.Open();
            _query = $"SELECT * FROM proyecto_final_p1.eventos WHERE fecha = '{fecha}';";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            MySqlDataAdapter data = new MySqlDataAdapter(_command);
            DataTable table = new DataTable();
            data.Fill(table);
            _connection.Close();
            return table;
        }

        /* implementa el comportamiento para insertar
         * registros a la tabla de eventos de la base de datos
         * valiendose del estado de los atributos de la clase
         * no recive valores
         * no devuelve valores */
        public override void Insertar()
        {
            _connection.Open();
            _query = $"INSERT INTO proyecto_final_p1.eventos (actividad, fecha, hora, lugar) VALUES ('{_actividad}', '{_fecha}', '{_hora}', '{_lugar}');";
            _command = new MySqlCommand(_query, _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        /* implementa el comportamiento para
         * recuperar todos los registros de la
         * tabla de eventos de la base de datos
         * no recive valores
         * devuelve un DataTable con todos
         * los campos y registros */
        public override DataTable LlenarGrid()
        {
            _connection.Open();
            _query = "select * from proyecto_final_p1.eventos;";
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
