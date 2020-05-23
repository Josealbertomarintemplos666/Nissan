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

namespace Nissan.Administrador
{
    public partial class CargaAPV : Form
    {
        public CargaAPV()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
            
            if (dt !=null)
            if (dt != null)
            {
                List<Asesor> asesores = new List<Asesor>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Asesor asesor = new Asesor();
                    asesor.nombres = dt.Rows[i]["nombres"].ToString();
                    asesor.agente = dt.Rows[i]["agente"].ToString();

                    asesores.Add(asesor);
                }
                    asesorBindingSource.DataSource = asesores;
                
              
            }
        }

        private void CargaAPV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'geishaDataSet.Asesor' Puede moverla o quitarla según sea necesario.
            //this.asesorTableAdapter.Fill(this.geishaDataSet.Asesor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Nissan.Base_de_datos.Conexion Conect = new Base_de_datos.Conexion();
                //string Conect = "Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True";
                // string connectionString = "Server=.;Database=Geisha;User=sa;Password=1234";
                DapperPlusManager.Entity<Asesor>().Table("Asesor");
                List<Asesor> asesores = asesorBindingSource.DataSource as List<Asesor>;
                if (asesores != null)
                {
                    using (IDbConnection db = new SqlConnection(Conect.Conect))
                    {
                        db.BulkInsert(asesores);
                    }
                }
                MessageBox.Show("Inserción Correcta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
