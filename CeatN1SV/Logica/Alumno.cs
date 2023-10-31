using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
namespace Logica
{
    public class Alumno
    {
        Conexion conecta = new Conexion();

        public bool guarda() 
        {
            bool guardado = conecta.ABM("INSERT INTO Alumno (Alumno_Nombres, Alumno_Apellidos, Alumno_Dni, Alumno_Sexo, Alumno_Nacionalidad,)" +
                                                   " VALUES (Pilar, Gutierrez, 11111111, 1, 11,) ");
            return guardado;
        }

    }
}

/*
 * SELECT Alumno_Nombres, Alumno_Apellidos, Alumno_Dni, Alumno_Sexo, Alumno_Nacionalidad, 
 * Alumno_Nacimiento, Alumno_AñoAdmision, Alumno_Seccion, Alumno_Caracterizacion, Alumno_Categoria
 * FROM Alumno;
 * string Nombre, string Apellido, int DNI, int Sexo, int Nacionalidad, DateTime FechaNacimiento, DateTime FechaAdmision
*/