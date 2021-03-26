using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Escolar.Clases
{
    class globales
    {
        public static string query;
        public static string usuario;
        public static byte nivel;
        public static string us_nivel;
        public static string us_nombre;

        public static void auditoria(string au_actividad, string us_nombre)
        {
            conexion objconexion = new conexion();
            SqlConnection conn = new SqlConnection(objconexion.conn());
            conn.Open();
            string query = "insert into auditoria values (@au_login,@au_fecha, @au_actividad)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@au_login", us_nombre);
            cmd.Parameters.AddWithValue("@au_fecha", DateTime.Now);
            cmd.Parameters.AddWithValue("@au_actividad", au_actividad);
            cmd.ExecuteNonQuery();
            //conn.Close();
        }
    }
}
