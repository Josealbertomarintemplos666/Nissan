namespace Nissan.Ventanilla_unica
{
    partial class Ventanilla_unica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventanilla_unica));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Head = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.SubmenuU = new System.Windows.Forms.Panel();
            this.ConfigurarUsuario = new System.Windows.Forms.Button();
            this.NuevoUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Usuarios = new System.Windows.Forms.Button();
            this.MostrarInformacion = new System.Windows.Forms.Button();
            this.CargarDatos = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Panel();
            this.Mini = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Maxi = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Head.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SubmenuU.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 713);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Contenedor);
            this.panel1.Controls.Add(this.Head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 692);
            this.panel1.TabIndex = 10;
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSize = true;
            this.Contenedor.BackColor = System.Drawing.Color.LightGray;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 141);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1370, 551);
            this.Contenedor.TabIndex = 6;
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Head.Controls.Add(this.Menu);
            this.Head.Controls.Add(this.Info);
            this.Head.Controls.Add(this.Logo);
            this.Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.Head.Location = new System.Drawing.Point(0, 0);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(1370, 141);
            this.Head.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Controls.Add(this.SubmenuU);
            this.Menu.Controls.Add(this.panel4);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(208, 30);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1162, 111);
            this.Menu.TabIndex = 2;
            // 
            // SubmenuU
            // 
            this.SubmenuU.Controls.Add(this.ConfigurarUsuario);
            this.SubmenuU.Controls.Add(this.NuevoUser);
            this.SubmenuU.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuU.Location = new System.Drawing.Point(0, 56);
            this.SubmenuU.Name = "SubmenuU";
            this.SubmenuU.Size = new System.Drawing.Size(1162, 55);
            this.SubmenuU.TabIndex = 2;
            this.SubmenuU.Visible = false;
            // 
            // ConfigurarUsuario
            // 
            this.ConfigurarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.ConfigurarUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConfigurarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConfigurarUsuario.FlatAppearance.BorderSize = 2;
            this.ConfigurarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigurarUsuario.ForeColor = System.Drawing.Color.Black;
            this.ConfigurarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("ConfigurarUsuario.Image")));
            this.ConfigurarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfigurarUsuario.Location = new System.Drawing.Point(171, 0);
            this.ConfigurarUsuario.Name = "ConfigurarUsuario";
            this.ConfigurarUsuario.Size = new System.Drawing.Size(190, 55);
            this.ConfigurarUsuario.TabIndex = 5;
            this.ConfigurarUsuario.Text = "Nuevo Ventanilla";
            this.ConfigurarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigurarUsuario.UseVisualStyleBackColor = false;
            // 
            // NuevoUser
            // 
            this.NuevoUser.BackColor = System.Drawing.Color.Transparent;
            this.NuevoUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.NuevoUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NuevoUser.FlatAppearance.BorderSize = 2;
            this.NuevoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoUser.ForeColor = System.Drawing.Color.Black;
            this.NuevoUser.Image = ((System.Drawing.Image)(resources.GetObject("NuevoUser.Image")));
            this.NuevoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoUser.Location = new System.Drawing.Point(0, 0);
            this.NuevoUser.Name = "NuevoUser";
            this.NuevoUser.Size = new System.Drawing.Size(171, 55);
            this.NuevoUser.TabIndex = 4;
            this.NuevoUser.Text = "Nuevo APV";
            this.NuevoUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoUser.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Usuarios);
            this.panel4.Controls.Add(this.MostrarInformacion);
            this.panel4.Controls.Add(this.CargarDatos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1162, 56);
            this.panel4.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.Usuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Usuarios.FlatAppearance.BorderSize = 2;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.ForeColor = System.Drawing.Color.Black;
            this.Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Usuarios.Image")));
            this.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Usuarios.Location = new System.Drawing.Point(456, 0);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(141, 56);
            this.Usuarios.TabIndex = 4;
            this.Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.UseVisualStyleBackColor = false;
            // 
            // MostrarInformacion
            // 
            this.MostrarInformacion.BackColor = System.Drawing.Color.Transparent;
            this.MostrarInformacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.MostrarInformacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MostrarInformacion.FlatAppearance.BorderSize = 2;
            this.MostrarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarInformacion.ForeColor = System.Drawing.Color.Black;
            this.MostrarInformacion.Image = ((System.Drawing.Image)(resources.GetObject("MostrarInformacion.Image")));
            this.MostrarInformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MostrarInformacion.Location = new System.Drawing.Point(192, 0);
            this.MostrarInformacion.Name = "MostrarInformacion";
            this.MostrarInformacion.Size = new System.Drawing.Size(264, 56);
            this.MostrarInformacion.TabIndex = 3;
            this.MostrarInformacion.Text = "MOSTRAR INFORMACIÓN";
            this.MostrarInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MostrarInformacion.UseVisualStyleBackColor = false;
            this.MostrarInformacion.Click += new System.EventHandler(this.MostrarInformacion_Click);
            // 
            // CargarDatos
            // 
            this.CargarDatos.BackColor = System.Drawing.Color.Transparent;
            this.CargarDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.CargarDatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CargarDatos.FlatAppearance.BorderSize = 2;
            this.CargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarDatos.ForeColor = System.Drawing.Color.Black;
            this.CargarDatos.Image = ((System.Drawing.Image)(resources.GetObject("CargarDatos.Image")));
            this.CargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CargarDatos.Location = new System.Drawing.Point(0, 0);
            this.CargarDatos.Name = "CargarDatos";
            this.CargarDatos.Size = new System.Drawing.Size(192, 56);
            this.CargarDatos.TabIndex = 2;
            this.CargarDatos.Text = "ASIGNACIONES";
            this.CargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CargarDatos.UseVisualStyleBackColor = false;
            this.CargarDatos.Click += new System.EventHandler(this.CargarDatos_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Black;
            this.Info.Controls.Add(this.Mini);
            this.Info.Controls.Add(this.Nombre);
            this.Info.Controls.Add(this.Maxi);
            this.Info.Controls.Add(this.Cerrar);
            this.Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.Info.Location = new System.Drawing.Point(208, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(1162, 30);
            this.Info.TabIndex = 1;
            // 
            // Mini
            // 
            this.Mini.BackColor = System.Drawing.Color.Transparent;
            this.Mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mini.BackgroundImage")));
            this.Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.Mini.FlatAppearance.BorderSize = 0;
            this.Mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mini.Location = new System.Drawing.Point(1069, 0);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(31, 30);
            this.Mini.TabIndex = 2;
            this.Mini.UseVisualStyleBackColor = false;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(0, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(192, 25);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Ventanilla Unica: ";
            // 
            // Maxi
            // 
            this.Maxi.BackColor = System.Drawing.Color.Transparent;
            this.Maxi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maxi.BackgroundImage")));
            this.Maxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maxi.FlatAppearance.BorderSize = 0;
            this.Maxi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Maxi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Maxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maxi.Location = new System.Drawing.Point(1100, 0);
            this.Maxi.Name = "Maxi";
            this.Maxi.Size = new System.Drawing.Size(31, 30);
            this.Maxi.TabIndex = 1;
            this.Maxi.UseVisualStyleBackColor = false;
            this.Maxi.Click += new System.EventHandler(this.Maxi_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cerrar.BackgroundImage")));
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Location = new System.Drawing.Point(1131, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(31, 30);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(48)))));
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(5);
            this.Logo.Size = new System.Drawing.Size(208, 141);
            this.Logo.TabIndex = 0;
            // 
            // Ventanilla_unica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventanilla_unica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventanilla_unica";
            this.Load += new System.EventHandler(this.Ventanilla_unica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.SubmenuU.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Head;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button MostrarInformacion;
        private System.Windows.Forms.Button CargarDatos;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Maxi;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel SubmenuU;
        private System.Windows.Forms.Button ConfigurarUsuario;
        private System.Windows.Forms.Button NuevoUser;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Panel Contenedor;
    }
}