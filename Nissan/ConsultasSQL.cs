using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nissan
{
    class ConsultasSQL
    {
        SqlConnection conexion = new SqlConnection("Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True");
        public bool Insertar(string idapv, string nombres)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Asesor values ('{0}','{1}','1234','apv')", new string[] { idapv, nombres }), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("insert into sesion values ('{0}','1234','apv')", new string[] {nombres }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            int filasafectadas2 = cmd2.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            if (filasafectadas2 > 0) return true;
            else return false;
        }
    }
}
