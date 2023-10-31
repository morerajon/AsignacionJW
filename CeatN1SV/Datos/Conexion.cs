using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Datos
{
    public class Conexion
    {

            //public int suma(int a, int b){return a + b;}

            //para conectar
            static private OleDbConnection Conecta;
            static private OleDbCommand Orden;
            static string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0; " +
            "Data Source = CeatDB.mdb;";

            //lee
            public OleDbDataReader Leer(string Consulta)
            {
                Conecta = new OleDbConnection(strConexion);
                Orden = new OleDbCommand(Consulta, Conecta);

                try
                {
                    Conecta.Open();
                    return Orden.ExecuteReader();
                }
                catch
                {
                    OleDbDataReader error = null;
                    return error;
                }
            }

            //cierra
            public void Desconectar()
            {
                if (Conecta.State == ConnectionState.Open)
                    Conecta.Close();
            }

            //Agrega Baja Modifica
            public bool ABM(string Consulta)
            {
                bool Resultado = false;
                Conecta = new OleDbConnection(strConexion);
                Orden = new OleDbCommand(Consulta, Conecta);
                try
                {
                    Conecta.Open();
                    Orden.ExecuteNonQuery();
                    Resultado = true;
                }
                catch
                {
                    Resultado = false;
                }

                Desconectar();

                return Resultado;
            }
    }

}
