using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nissan.Gerente_de_ventas
{
    public partial class Gerente_de_ventas : Form
    {
        public Gerente_de_ventas(String x)
        {
            InitializeComponent();
        }

        private void Gerente_de_ventas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nissan.Login login = new Login();
            login.Show();
        }
    }
}
