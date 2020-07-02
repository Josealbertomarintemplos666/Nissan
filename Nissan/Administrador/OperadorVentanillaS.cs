﻿using System;
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
    public partial class OperadorVentanillaS : Form
    {
        public OperadorVentanillaS()
        {
            InitializeComponent();
        }
        ConsultasSQL sql = new ConsultasSQL();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sql.InsertarOperadorVentanilla(textBox1.Text))
            {
                MessageBox.Show("Datos insertados");
            }
            else MessageBox.Show("No se han podido insertar los datos");
            textBox1.Text = "Nombre";
            textBox1.ForeColor = Color.Gray;
        }
    }
}
