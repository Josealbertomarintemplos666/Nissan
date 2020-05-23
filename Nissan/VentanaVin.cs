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

            this.Text = nombre;
        }

        private void VentanaVin_Load(object sender, EventArgs e)
        {

        }
    }
}
