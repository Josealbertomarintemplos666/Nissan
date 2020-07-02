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
                    label1.Text = openFileDialog.FileName;
                    //textBox1.Text = openFileDialog.FileName;

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
            label1.Visible = true;



        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;

            if (dt != null)
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

            button2.Visible = true;
        }

        private void CargaAPV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'geishaDataSet.Asesor' Puede moverla o quitarla según sea necesario.
            //this.asesorTableAdapter.Fill(this.geishaDataSet.Asesor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nissan.Base_de_datos.Conexion conexion = new Base_de_datos.Conexion();

            SqlConnection Conect = new SqlConnection("Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True");

            SqlCommand agregar = new SqlCommand("insert into Asesor values(@idapv,@nombres,@contraseña,@roles)",Conect);
            SqlCommand agregar2 = new SqlCommand("insert into sesion values(@usuario,@contraseña,@roles)", Conect);
            Conect.Open();

            try
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar2.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@nombres", Convert.ToString(row.Cells["nombres"].Value));
                    agregar.Parameters.AddWithValue("@idapv", Convert.ToString(row.Cells["agente"].Value));
                    agregar.Parameters.AddWithValue("@contraseña", Convert.ToString("1234"));
                    agregar.Parameters.AddWithValue("@roles", Convert.ToString("apv"));
                    

                    
                    agregar2.Parameters.AddWithValue("@usuario", Convert.ToString(row.Cells["nombres"].Value));
                    agregar2.Parameters.AddWithValue("@contraseña", Convert.ToString("1234"));
                    agregar2.Parameters.AddWithValue("@roles", Convert.ToString("apv"));

                    agregar.ExecuteNonQuery();
                    agregar2.ExecuteNonQuery();

                }
                MessageBox.Show("Datos Agregados");
            }catch(Exception ex)
            {
                MessageBox.Show("Error al agregar");
            }
            finally
            {
                Conect.Close();
            }


          /*  DataSet ds = new DataSet();
            dataGridView1.DataSource = geishaDataSet.Tables[0];
            
            //string Conect = "Data Source=Localhost; Initial Catalog=Geisha; Integrated Security=True";
            // string connectionString = "Server=.;Database=Geisha;User=sa;Password=1234";
            SqlConnection conexion_destino = new SqlConnection();

            conexion_destino.ConnectionString = "Data Source=.;Initial Catalog=Geisha; Integrated Security =true";
            conexion_destino.Open();
            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(conexion_destino);
            importar.DestinationTableName = "Asesor";
            importar.WriteToServer(geishaDataSet.Tables[0]);
            conexion_destino.Close();*/



            /*
             * try
        {
        .Entity<Asesor>().Table("Asesor");
            List<Asesor> asesores = asesorBindingSource.DataSource as List<Asesor>;
            if (asesores != null)
            {
                using (IDbConnection db = new SqlConnection(Conect.Conect))
                {
                    db.BulkInsert(asesores);
                }
            }
            MessageBox.Show("Inserción Correcta");
            panel5.Visible = false;
            label1.Text = "";
            label1.Visible = false;
            button2.Visible = false;
            dataGridView1.Columns.Clear();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }*/



        }
    }
}

