using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinalProgramacionI
{
    /* Define el los atributos y metodos que deben tener todas las clases
     * que hagan una conexion a la base de datos de este proyecto */
    abstract class ConexionAbstract
    {
        // cadena con el datasource, puerto, usuario, password, base de datos y tabla para conectarse a la base de datos
        protected readonly string CONNECTION_STRING = "datasource=127.0.0.1;port=3306;username=root;password=34-19-21/cdrt/mysqlroot;database=proyecto_final_p1;";
        // query a ejecutar en la base de datos, cada metodo debera modificarlo
        protected string _query;
        // variable para almacenar la referencia en memoria a la conexion establecido con la base de datos
        // se debe reiniciar en el constructor de cada clase que implemente esta clase abstracta
        protected MySqlConnection _connection;
        // variable que representa el comando a ejecutar variendose de la coneccion y el query
        protected MySqlCommand _command;

        // metodos que se deben implementar en cada clase de tipo dao que implemente esta

        // este metodo inserta registros a la base de datos
        public abstract void Insertar();
        // este metodo actualizar registros a la base de datos
        public abstract void Actualizar();
        // este metodo borrar registros de la base de datos
        public abstract void Borrar();
        // este metodo recupera registros especificos de la base de datos
        // y devuelve un DataGrid conteniendo todos los campos y registros
        public abstract DataTable Buscar(string var1);
        // este metodo recupera todos los registros de la tabla de la base de datos
        // y devuelve un DataGrid conteniendo todos los campos y registros
        public abstract DataTable LlenarGrid();
    }
}
