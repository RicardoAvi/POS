namespace POS
{
    partial class frmConfiguraciones
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_nombre = new TextBox();
            txt_domicilio = new TextBox();
            txt_direccion = new TextBox();
            txt_correo = new TextBox();
            txt_telefono = new TextBox();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            proovedoresToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            txt_guardar = new Button();
            txt_eliminar = new Button();
            txt_actualizar = new Button();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(10, 102);
            label1.Name = "label1";
            label1.Size = new Size(107, 27);
            label1.TabIndex = 0;
            label1.Text = "* Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.Location = new Point(10, 236);
            label2.Name = "label2";
            label2.Size = new Size(109, 27);
            label2.TabIndex = 1;
            label2.Text = "* Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.Location = new Point(10, 304);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 2;
            label3.Text = "* Correo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F);
            label4.Location = new Point(10, 169);
            label4.Name = "label4";
            label4.Size = new Size(100, 27);
            label4.TabIndex = 3;
            label4.Text = "* Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F);
            label5.Location = new Point(10, 360);
            label5.Name = "label5";
            label5.Size = new Size(110, 27);
            label5.TabIndex = 4;
            label5.Text = "* Telefono";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(194, 102);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(324, 27);
            txt_nombre.TabIndex = 5;
            // 
            // txt_domicilio
            // 
            txt_domicilio.Location = new Point(194, 160);
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.Size = new Size(324, 27);
            txt_domicilio.TabIndex = 6;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(194, 216);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(324, 27);
            txt_direccion.TabIndex = 7;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(194, 292);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(324, 27);
            txt_correo.TabIndex = 8;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(194, 360);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(324, 27);
            txt_telefono.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, productosToolStripMenuItem, proovedoresToolStripMenuItem, inventarioToolStripMenuItem, ventasToolStripMenuItem, usuariosToolStripMenuItem, clientesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(787, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(89, 24);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // proovedoresToolStripMenuItem
            // 
            proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            proovedoresToolStripMenuItem.Size = new Size(106, 24);
            proovedoresToolStripMenuItem.Text = "Proovedores";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(89, 24);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(66, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // txt_guardar
            // 
            txt_guardar.ImageAlign = ContentAlignment.MiddleRight;
            txt_guardar.Location = new Point(194, 483);
            txt_guardar.Name = "txt_guardar";
            txt_guardar.Size = new Size(149, 74);
            txt_guardar.TabIndex = 11;
            txt_guardar.Text = "Guardar";
            txt_guardar.UseVisualStyleBackColor = true;
            txt_guardar.Click += button1_Click;
            // 
            // txt_eliminar
            // 
            txt_eliminar.Location = new Point(578, 483);
            txt_eliminar.Name = "txt_eliminar";
            txt_eliminar.Size = new Size(161, 74);
            txt_eliminar.TabIndex = 12;
            txt_eliminar.Text = "Eliminar";
            txt_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_actualizar
            // 
            txt_actualizar.Location = new Point(397, 483);
            txt_actualizar.Name = "txt_actualizar";
            txt_actualizar.Size = new Size(141, 74);
            txt_actualizar.TabIndex = 13;
            txt_actualizar.Text = "Actualizar";
            txt_actualizar.UseVisualStyleBackColor = true;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // frmConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(787, 583);
            Controls.Add(txt_actualizar);
            Controls.Add(txt_eliminar);
            Controls.Add(txt_guardar);
            Controls.Add(txt_telefono);
            Controls.Add(txt_correo);
            Controls.Add(txt_direccion);
            Controls.Add(txt_domicilio);
            Controls.Add(txt_nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmConfiguraciones";
            Text = "frmConfiguraciones";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_nombre;
        private TextBox txt_domicilio;
        private TextBox txt_direccion;
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private Button txt_guardar;
        private Button txt_eliminar;
        private Button txt_actualizar;
        private ToolStripMenuItem proovedoresToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}