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
            Nombre.Text = "ADMINISTRADOR: " + x;
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

            muestrasub(SubmenuCD);
          

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void dis()
        {
            SubmenuCD.Visible = false;
            SubmenuU.Visible = false;

        }
        private void ocultasub()
        {
            if (SubmenuCD.Visible == true)
                SubmenuCD.Visible = false;
            if (SubmenuU.Visible == true)
                SubmenuU.Visible = false;
        }

        private void muestrasub(Panel submenu)
        {
            if(submenu.Visible== false)
            {
                ocultasub();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            muestrasub(SubmenuU);
        }

        private void CargarVin_Click(object sender, EventArgs e)
        {
            ocultasub();
            
            if (this.Contenedor.Controls.Count > 0)
                  this.Contenedor.Controls.RemoveAt(0);
              CargaDatos BV = new CargaDatos();
              BV.TopLevel = false;
              BV.StartPosition = FormStartPosition.CenterScreen;
              this.Contenedor.Controls.Add(BV);
              this.Contenedor.Tag = BV;
              BV.Show();


            
        }

        private void CargarApv_Click(object sender, EventArgs e)
        {
            ocultasub();
           
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Nissan.Administrador.CargaAPV BV = new Nissan.Administrador.CargaAPV();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();

            
        }

        private void NuevoUser_Click(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            InsertarUsuario BV = new InsertarUsuario();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            InsertarVentanilla BV = new InsertarVentanilla();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            OperadorVentanillaS BV = new OperadorVentanillaS();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            VinS BV = new VinS();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ocultasub();
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            OperariosS BV = new OperariosS();
            BV.TopLevel = false;
            BV.StartPosition = FormStartPosition.CenterScreen;
            this.Contenedor.Controls.Add(BV);
            this.Contenedor.Tag = BV;
            BV.Show();

        }
    }
}
