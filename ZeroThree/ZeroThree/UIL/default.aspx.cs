using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZeroThree.BLL;

namespace ZeroThree.UIL
{
    public partial class _default : System.Web.UI.Page
    {
        private ClassAlumno alumn;
        //Cargas
        private void CargarAlumnos()
        {
            gvAlumno.DataSource = alumn.LlenarAlumnos();
            gvAlumno.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion conexion = new Conexion();

                // Asegúrate de crear la instancia de ClassAlumno correctamente
                alumn = new ClassAlumno(new SqlConnection(conexion.cadena));

                CargarAlumnos();
            }
        }

        protected void ButtonGuardarAlumno_Click(object sender, EventArgs e)
        {

        }

        protected void gvAlumno_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAlumno.EditIndex = e.NewEditIndex;
            CargarAlumnos();
        }

        protected void gvAlumno_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAlumno.EditIndex = -1;
            CargarAlumnos();
        }

        protected void gvAlumno_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Obtener los valores editados
            GridViewRow row = gvAlumno.Rows[e.RowIndex];
            string carne = (row.FindControl("lblCarne") as Label).Text;
            string name1 = (row.FindControl("txtName1") as TextBox).Text;
            string name2 = (row.FindControl("txtName2") as TextBox).Text;
            string apellido1 = (row.FindControl("txtApellido1") as TextBox).Text;
            string apellido2 = (row.FindControl("txtApellido2") as TextBox).Text;

            // Actualizar el alumno con los nuevos valores
            // (Recuerda que también deberías manejar el email, teléfono, etc., dependiendo de tu modelo)
            bool estado = true; // Ejemplo de estado, deberías definir la lógica aquí.

            int result = alumn.ActualizarAlumno(carne, name1, name2, apellido1, apellido2, DateTime.Now, "0000000000", "email@example.com", estado);

            if (result == 1)
            {
                // Éxito
                gvAlumno.EditIndex = -1;
                CargarAlumnos();
            }
            else
            {
                // Error
            }
        }
    }
}