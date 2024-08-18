using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using WebApplication26.CapaDatos;

namespace WebApplication26.CapaLogica
{
    public class AlumnosCRUD
    {

        public static int Agregar(string Nombre, DateTime Fecha)
        {
            Cls_Alumno.nombre = Nombre; 
            Cls_Alumno.fecha = Fecha;
            string fecha = Fecha.ToString("yyyy-MM-dd");

            int retorno = 0;
            try
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand(" INSERT INTO alumno VALUES('" + Cls_Alumno.nombre + "', '" + fecha + "')", conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int borrar(int Codigo)
        {
            int retorno = 0;
            try
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand("DELETE alumno WHERE id = " + Codigo + "", conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                retorno = -1;
            }

            return retorno;
        }

    }
}