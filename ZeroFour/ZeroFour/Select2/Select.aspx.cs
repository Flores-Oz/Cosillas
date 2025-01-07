using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZeroFour.Data;

namespace ZeroFour.Select2
{
    public partial class Select : System.Web.UI.Page
    {
        Data.DataClassesDataContext dataContext = new Data.DataClassesDataContext(Conexion.cadena);
        private void CargarEstudiante()
        {
            var Est = from est in dataContext.Alumnos
                      select new
                      {
                          Carne = est.Carne,
                          Nombre = est.Nombre1 +" "+ est.Nombre2
                      };
            ddlEstudiante.DataSource = Est;
            ddlEstudiante.DataTextField = "Nombre";
            ddlEstudiante.DataValueField = "Carne";
            ddlEstudiante.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<ListItem> items = new List<ListItem> {
                new ListItem("Opción 1", "1"),
                new ListItem("Opción 2", "2"),
                new ListItem("Opción 3", "3")
            };

                miSelect.DataSource = items;
                miSelect.DataTextField = "Text";
                miSelect.DataValueField = "Value";
                miSelect.DataBind();

                miSelect.Items.Insert(0, new ListItem("--Seleccione--", ""));
                ddlEstudiante.Items.Insert(0, new ListItem("--Seleccione--", ""));
                CargarEstudiante();
            }
        }

        protected void ddlEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int carne = Convert.ToInt16(ddlEstudiante.SelectedValue);

        }
    }
}