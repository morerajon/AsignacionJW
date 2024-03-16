using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
namespace Logica
{
    public class Estadistica
    {
        public DataTable AlumnosMatriculados()
        {
            DataTable tabla = new DataTable();
            Conexion conexion = new Conexion();
            tabla.Load(conexion.Leer("SELECT * FROM Caracterizacion"));
            return tabla;
        }
    }
}
