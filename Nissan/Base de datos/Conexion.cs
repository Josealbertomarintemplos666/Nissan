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
        string Conect = "Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da;
        public DataSet ds;
        public DataRow dr;
        public SqlDataReader drr;

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
    }
}
