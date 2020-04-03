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
    public partial class Login : Form
    {
        Nissan.Base_de_datos.Conexion conexion = new Base_de_datos.Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.Black;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Usuario";
                Usuario.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (PASS.Text == "Contraseña")
            {
                PASS.Text = "";
                PASS.ForeColor = Color.Black;
                PASS.UseSystemPasswordChar = true;
            }
        }

        private void PASS_Leave(object sender, EventArgs e)
        {
            if (PASS.Text == "")
            {
                PASS.Text = "Contraseña";
                PASS.ForeColor = Color.Black;
                PASS.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)

        {
            if (PASS.Text != "Contraseña") { 
            if (checkBox1.Checked == false)

                PASS.UseSystemPasswordChar = true;

            else
                PASS.UseSystemPasswordChar = false;
        }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Usuario.Text != "Usuario" || PASS.Text != "Contraseña")
            {
                conexion.abrir();
                if (conexion.Login(Usuario.Text,PASS.Text)!= "falso")
                {
                    
                    if(conexion.Login(Usuario.Text, PASS.Text) == "Administrador")
                    {
                        
                        this.Hide();
                        Nissan.Administrador.Administrador admin = new Administrador.Administrador(Usuario.Text);
                        admin.Show();
                    }
                    if (conexion.Login(Usuario.Text, PASS.Text) == "Ventanilla unica")
                    {
                        this.Hide();
                        Nissan.Ventanilla_unica.Ventanilla_unica vent = new Ventanilla_unica.Ventanilla_unica(Usuario.Text);
                        vent.Show();
                    }
                    if (conexion.Login(Usuario.Text, PASS.Text) == "apv")
                    {
                        this.Hide();
                        Nissan.APV.APV aPV = new APV.APV(Usuario.Text);
                        aPV.Show();
                    }
                    if (conexion.Login(Usuario.Text, PASS.Text) == "gerente de ventas")
                    {
                        this.Hide();
                        Nissan.Gerente_de_ventas.Gerente_de_ventas gerente_ = new Gerente_de_ventas.Gerente_de_ventas(Usuario.Text);
                        gerente_.Show();
                    }
                    

                }
                else
                {
                    MessageBox.Show("Usuario y Contraseña incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Usuario.Text = "Usuario";
                    PASS.Text = "Contraseña";
                    conexion.cerrar();
                }
            }
            else
            {
                MessageBox.Show("Coloca el nombre de usuario y la contraseña para poder entrar", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            } 
        }
    }

   
}
