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
    public partial class InsertarVentanilla : Form
    {
        public InsertarVentanilla()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nombre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nombre";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void InsertarVentanilla_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (sql.InsertarVentanilla(textBox2.Text))
            {
                MessageBox.Show("Datos insertados");
            }
            else MessageBox.Show("No se han podido insertar los datos");
            textBox2.Text = "Nombre";
            textBox2.ForeColor = Color.Gray;
=======
>>>>>>> b9efc5b37fbb7f14ed42b43a1c1f590d99d82bda

        }
    }
}
