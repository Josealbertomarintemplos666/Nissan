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
    public partial class Ventanilla_unica : Form
    {
        public Ventanilla_unica(String x)
        {
            InitializeComponent();
            Nombre.Text = "VENTANILLA UNICA: " + x;
            dis();
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

        private void Ventanilla_unica_Load(object sender, EventArgs e)
        {

        }

        private void CargarVin_Click(object sender, EventArgs e)
        {

        }
        private void dis()
        {
            
            SubmenuU.Visible = false;

        }
        private void ocultasub()
        {
        
            if (SubmenuU.Visible == true)
                SubmenuU.Visible = false;
        }

        private void muestrasub(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultasub();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }


        private void CargarDatos_Click(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Asignar BV = new Asignar();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }

        private void MostrarInformacion_Click(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            BuscarVin BV = new BuscarVin();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }


    }
}
