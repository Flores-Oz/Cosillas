using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ZeroThree.DAL.DataSetGeneralTableAdapters;

namespace ZeroThree.BLL
{
    public class ClassAlumno
    {
        private AlumnoTableAdapter alumno;
        private SqlConnection _connection;

        // Constructor que recibe la conexión
        public ClassAlumno(SqlConnection connection)
        {
            _connection = connection;
            alumno = new AlumnoTableAdapter();
            alumno.Connection = _connection;  // Establecemos la conexión en el TableAdapter
        }

        // Método para llenar los alumnos
        public DataTable LlenarAlumnos()
        {
            return alumno.GetData();  // Llamamos al método GetData() del TableAdapter
        }

        // Método para insertar un nuevo alumno
        public int InsertarAlumno(string Carne, string Name1, string Name2, string Apellido1, string Apellido2, DateTime Nac, string cel, string email, bool est)
        {
            try
            {
                // Llamamos al procedimiento almacenado para insertar un nuevo alumno
                alumno.InsertarAlumno(Carne, Name1, Name2, Apellido1, Apellido2, Nac, cel, email, est);
                return 1;  // Retornamos 1 si la inserción fue exitosa
            }
            catch (Exception ex)
            {
                // Si ocurre un error, logueamos el error o manejamos la excepción
                Console.WriteLine("Error al insertar alumno: " + ex.Message);
                return 0;  // Retornamos 0 si hubo un error
            }
        }

        // Método para actualizar los datos de un alumno
        public int ActualizarAlumno(string Carne, string Name1, string Name2, string Apellido1, string Apellido2, DateTime Nac, string cel, string email, bool est)
        {
            try
            {
                // Llamamos al procedimiento almacenado para actualizar los datos de un alumno
                alumno.ActualizarAlumno(Name1, Name2, Apellido1, Apellido2, Nac, cel, email, est, Carne);
                return 1;  // Retornamos 1 si la actualización fue exitosa
            }
            catch (Exception ex)
            {
                // Si ocurre un error, logueamos el error o manejamos la excepción
                Console.WriteLine("Error al actualizar alumno: " + ex.Message);
                return 0;  // Retornamos 0 si hubo un error
            }
        }

        // Método para cambiar el estado de un alumno (activo/inactivo)
        public int ActualizarEstado(string Carne, bool est)
        {
            try
            {
                // Llamamos al procedimiento almacenado para cambiar el estado de un alumno
                alumno.CambiarEstadoAlumno(est, Carne);
                return 1;  // Retornamos 1 si la actualización fue exitosa
            }
            catch (Exception ex)
            {
                // Si ocurre un error, logueamos el error o manejamos la excepción
                Console.WriteLine("Error al actualizar el estado del alumno: " + ex.Message);
                return 0;  // Retornamos 0 si hubo un error
            }
        }
    }
}