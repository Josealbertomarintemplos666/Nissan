using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nissan.Ventanilla_unica
{
    public partial class Asignar : Form
    {
        public Asignar()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            accesorios BV = new accesorios();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            tramites BV = new tramites();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            preparacion BV = new preparacion();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
