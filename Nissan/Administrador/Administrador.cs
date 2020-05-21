using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nissan.Administrador
{
    public partial class Administrador : Form
    {
        public Administrador(string x)
        {
            InitializeComponent();
            this.Text = "ADMINISTRADOR USUARIO: "+x;


        }

        

        private void Maxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            BuscarVin BV = new BuscarVin();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            CargaDatos BV = new CargaDatos();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }
    }
}
