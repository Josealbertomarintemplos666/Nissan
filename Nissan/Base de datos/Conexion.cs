using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Nissan.Base_de_datos
{
    

    class Conexion
    {
        public string Conect = "Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da;
        public DataSet ds;
        public DataRow dr;
        public SqlDataReader drr;
        public DataTable dt;

        public Conexion()
        {
            conectarbd.ConnectionString = Conect;
        }


        public void abrir()
        {
            try {
                conectarbd.Open();
            }catch(Exception e)
            {
                MessageBox.Show("Error al conectar con el servidor de la base de datos \n" + e.Message);

            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }

        public String Login(String usuario, String contra)
        {
            cmd = new SqlCommand("select usuario, roles from sesion where usuario=@us and contraseña=@pas",conectarbd);
            cmd.Parameters.AddWithValue("us",usuario);
            cmd.Parameters.AddWithValue("pas", contra);
            SqlDataAdapter ss = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ss.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0][1].ToString();
            }
            else
            {
                return "falso";
            }
        }

        public void ListaVin(DataSet dataSet)
        {
            cmd = new SqlCommand("select vin from Vin", conectarbd);
            da = new SqlDataAdapter(cmd);
            da.Fill(dataSet, "Vin");
            da.Dispose();
        }
    }
}
