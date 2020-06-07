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
    public partial class VentanaVin : Form
    {
        
        public VentanaVin( String nombre)
        {
            InitializeComponent();

            this.Text = "Vin: " + nombre;
        }


        private void VentanaVin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Nissan.Ventanilla_unica.Asignar vent = new Ventanilla_unica.Asignar();
            vent.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      
    }
}
