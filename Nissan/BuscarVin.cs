using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nissan
{
    public partial class BuscarVin : Form
    {

        DataSet result = new DataSet();
        DataView filtro;
        Nissan.Base_de_datos.Conexion conec;
        public BuscarVin()
        {
            InitializeComponent();
        }


        private void BuscarVin_Load(object sender, EventArgs e)
        {
            conec = new Base_de_datos.Conexion();
            conec.abrir();
            conec.ListaVin(result);

            filtro = ((DataTable)result.Tables["Vin"]).DefaultView;

            Vins.DataSource = filtro;


        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String dato = "";
            string[] posibles_palabras = textBox1.Text.Split(' ');


            foreach(String palabra in posibles_palabras)
            {
                if (dato.Length == 0) {
                    dato = "(vin Like '%"+ palabra+"%')";
                }
                else
                {
                    dato += " AND (vin Like '%" + palabra + "%')";
                }
            }

            filtro.RowFilter = dato;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
