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

<<<<<<< HEAD
        public bool InsertarVentanilla(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Ventanilla values ('{0}','1234','Ventanilla Unica')", new string[] {nombre}), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("insert into sesion values ('{0}','1234','Ventanilla Unica')", new string[] { nombre }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            int filasafectadas2 = cmd2.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            if (filasafectadas2 > 0) return true;
            else return false;
        }

        public bool InsertarOperadorVentanilla(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into OperadorVentanilla values ('{0}','1234','Operador Ventanilla Unica')", new string[] {nombre }), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("insert into sesion values ('{0}','1234','Operador Ventanilla Unica')", new string[] { nombre }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            int filasafectadas2 = cmd2.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            if (filasafectadas2 > 0) return true;
            else return false;
        }

        public bool InsertarOperario(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Operarios values ('{0}','1234','Operario')", new string[] {nombre}), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("insert into sesion values ('{0}','1234','Operario')", new string[] { nombre }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            int filasafectadas2 = cmd2.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            if (filasafectadas2 > 0) return true;
=======
        public bool InsertarVin(string vin, string descripcion, string cuota, string cabecera, string motor, string colext)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Vin values ('{0}','{1}','{2}','{3}','{4}','{5}','No iniciado')", new string[] { vin, descripcion, cuota, cabecera, motor, colext }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
>>>>>>> b9efc5b37fbb7f14ed42b43a1c1f590d99d82bda
            else return false;
        }
    }
}
