using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication26.CapaLogica;

namespace WebApplication26.CapaPresentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }


        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM alumno"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void bAgregar_Click(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.Parse(tfecha.Text);

            if (AlumnosCRUD.Agregar(tnombre.Text, fecha) > 0)
            {
                LlenarGrid();
            }

        }

        protected void bEliminar_Click(object sender, EventArgs e)
        {
            if (AlumnosCRUD.borrar(int.Parse(tcodigo.Text)) > 0)
            {
                LlenarGrid();
            }
        }
    }
}
