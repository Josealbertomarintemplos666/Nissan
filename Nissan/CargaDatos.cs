using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nissan
{
    public partial class CargaDatos : Form
    {
        public CargaDatos()
        {
            InitializeComponent();
        }

        private void cboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboTabla.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;

        }
        DataTableCollection tableCollection;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() {Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"})
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=> new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow=true
                                }
                            });
                            tableCollection = result.Tables;
                            cboTabla.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboTabla.Items.Add(table.TableName);

                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
