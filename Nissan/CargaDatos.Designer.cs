namespace Nissan
{
    partial class CargaDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboTabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.geishaDataSet = new Nissan.GeishaDataSet();
            this.vinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinTableAdapter = new Nissan.GeishaDataSetTableAdapters.VinTableAdapter();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geishaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 636);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFilename);
            this.panel2.Controls.Add(this.cboTabla);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 636);
            this.panel2.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(289, 329);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(72, 25);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabla:";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(127, 281);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(393, 20);
            this.txtFilename.TabIndex = 4;
            // 
            // cboTabla
            // 
            this.cboTabla.AccessibleDescription = "";
            this.cboTabla.FormattingEnabled = true;
            this.cboTabla.Location = new System.Drawing.Point(127, 329);
            this.cboTabla.Name = "cboTabla";
            this.cboTabla.Size = new System.Drawing.Size(121, 21);
            this.cboTabla.TabIndex = 3;
            this.cboTabla.SelectedIndexChanged += new System.EventHandler(this.cboTabla_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vinDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cuotaDataGridViewTextBoxColumn,
            this.motorDataGridViewTextBoxColumn,
            this.colextDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 240);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(526, 279);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // geishaDataSet
            // 
            this.geishaDataSet.DataSetName = "GeishaDataSet";
            this.geishaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vinBindingSource
            // 
            this.vinBindingSource.DataMember = "Vin";
            this.vinBindingSource.DataSource = this.geishaDataSet;
            // 
            // vinTableAdapter
            // 
            this.vinTableAdapter.ClearBeforeFill = true;
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // cuotaDataGridViewTextBoxColumn
            // 
            this.cuotaDataGridViewTextBoxColumn.DataPropertyName = "cuota";
            this.cuotaDataGridViewTextBoxColumn.HeaderText = "cuota";
            this.cuotaDataGridViewTextBoxColumn.Name = "cuotaDataGridViewTextBoxColumn";
            // 
            // motorDataGridViewTextBoxColumn
            // 
            this.motorDataGridViewTextBoxColumn.DataPropertyName = "motor";
            this.motorDataGridViewTextBoxColumn.HeaderText = "motor";
            this.motorDataGridViewTextBoxColumn.Name = "motorDataGridViewTextBoxColumn";
            // 
            // colextDataGridViewTextBoxColumn
            // 
            this.colextDataGridViewTextBoxColumn.DataPropertyName = "colext";
            this.colextDataGridViewTextBoxColumn.HeaderText = "colext";
            this.colextDataGridViewTextBoxColumn.Name = "colextDataGridViewTextBoxColumn";
            // 
            // CargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CargaDatos";
            this.Text = "CargaDatos";
            this.Load += new System.EventHandler(this.CargaDatos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geishaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox cboTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
        private GeishaDataSet geishaDataSet;
        private System.Windows.Forms.BindingSource vinBindingSource;
        private GeishaDataSetTableAdapters.VinTableAdapter vinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colextDataGridViewTextBoxColumn;
    }
}