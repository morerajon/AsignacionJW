using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data.OleDb;
using System.Data;


namespace Logica
{
    public class Usuario
    {
        Conexion conecta = new Conexion();
        

        public bool TraeDatos(string usu, string pass)
        {
            bool trae = false;

            //OleDbDataReader reader1 = conecta.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Permisos.Permiso_Categoria " +
            //    "(FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id) where u.Usuario_Alias = '" + usu + "' and u.Usuario_Password = '" + pass + "'");
            
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    UsuarioCache.IdUsuario = reader1.GetInt32(4);
                    UsuarioCache.Nombre = reader1.GetString(1);
                    UsuarioCache.Apellido = reader1.GetString(2);
                    UsuarioCache.Permisos = reader1.GetString(2);
                
                }
                trae = true;
            }
            else
            {
                trae = false;
            }

            return trae;
        }


    }
}

