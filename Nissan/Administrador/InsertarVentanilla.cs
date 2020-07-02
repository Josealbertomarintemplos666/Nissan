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
    }
}
