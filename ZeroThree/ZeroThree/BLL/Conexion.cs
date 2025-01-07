using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ZeroThree.BLL
{
    public class Conexion
    {
        public static string cadena = "Data Source=LAPTOP-V7AM2CHL\\SQLEXPRESS01;Initial Catalog=Corto1BD23;Integrated Security=True";
        //public static string cadena = "Data Source = GNARO\\SQLEXPRESS;Initial Catalog = Corto1BD23; Persist Security Info=True;User ID = sa; Password=ImpactRail123";
        
        // Método que retorna una conexión SqlConnection
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}