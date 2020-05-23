using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace Nissan
{
    public partial class CargaDatos : Form
    {
        public CargaDatos()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
     

        private void CargaDatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'geishaDataSet.Vin' Puede moverla o quitarla según sea necesario.
            //dataGridView1.DataSource=(this.vinTableAdapter.Fill(this.geishaDataSet.Vin));

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    label4.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                comboBox1.Items.Add(table.TableName);

                        }
                    }
                }
            }
            panel5.Visible = true;
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Nissan.Base_de_datos.Conexion Conect = new Base_de_datos.Conexion();
                //string Conect = "Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True";
                // string connectionString = "Server=.;Database=Geisha;User=sa;Password=1234";
                DapperPlusManager.Entity<Vin>().Table("Vin");
                List<Vin> vins = vinBindingSource.DataSource as List<Vin>;
                if (vins != null)
                {
                    using (IDbConnection db = new SqlConnection(Conect.Conect))
                    {
                        db.BulkInsert(vins);
                    }
                }
                MessageBox.Show("Inserción Correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<Vin> vins = new List<Vin>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Vin vin = new Vin();
                    vin.vin = dt.Rows[i]["vin"].ToString();
                    vin.descripcion = dt.Rows[i]["descripcion"].ToString();
                    vin.cuota = dt.Rows[i]["cuota"].ToString();
                    vin.cabecera = dt.Rows[i]["cabecera"].ToString();
                    vin.motor = dt.Rows[i]["motor"].ToString();
                    vin.colext = dt.Rows[i]["colext"].ToString();
                    vins.Add(vin);
                }
                vinBindingSource.DataSource = vins;
            }
            button2.Visible = true;
        }
    }
}
