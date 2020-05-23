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
            


        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String dato = "";

            String datoAPV = "";
            string[] posibles_palabras = textBox1.Text.Split(' ');
            string[] posibles_palabrasa = textBox1.Text.Split(' ');

            if (Rvin.Checked == true) { 
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
            if (RAPV.Checked == true)
            {
                foreach (String palabras in posibles_palabrasa)
                {
                    if (datoAPV.Length == 0)
                    {
                        datoAPV = "(Nombre Like '%" + palabras + "%')";
                    }
                    else
                    {
                        datoAPV += " AND (Nombre Like '%" + palabras + "%')";
                    }
                }
                filtro.RowFilter = datoAPV;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rvin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RAPV_CheckedChanged(object sender, EventArgs e)
        {
           
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conec = new Base_de_datos.Conexion();
            conec.abrir();

             if (Rvin.Checked == true) {
                Vins.Columns.Clear();
                textBox1.Text = "";
                 conec.ListaVin(result);
                 filtro = ((DataTable)result.Tables["Vin"]).DefaultView;
                 Vins.DataSource = filtro;
                 }

             if (RAPV.Checked == true) {
                Vins.Columns.Clear();
                textBox1.Text = "";
                conec.ListaAPV(result);
                filtro = ((DataTable)result.Tables["Asesor"]).DefaultView;
                Vins.DataSource = filtro;
             }
        }
    }
}
