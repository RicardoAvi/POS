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
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            txt_guardar = new Button();
            txt_eliminar = new Button();
            txt_actualizar = new Button();
 
            label6 = new Label();

            rHToolStripMenuItem = new ToolStripMenuItem();
 
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(9, 76);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "* Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.Location = new Point(9, 177);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "* Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.Location = new Point(9, 228);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "* Correo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F);
            label4.Location = new Point(9, 127);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "* Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F);
            label5.Location = new Point(9, 270);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 4;
            label5.Text = "* Telefono";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(170, 76);
            txt_nombre.Margin = new Padding(3, 2, 3, 2);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(284, 23);
            txt_nombre.TabIndex = 5;
            // 
            // txt_domicilio
            // 
            txt_domicilio.Location = new Point(170, 120);
            txt_domicilio.Margin = new Padding(3, 2, 3, 2);
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.Size = new Size(284, 23);
            txt_domicilio.TabIndex = 6;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(170, 162);
            txt_direccion.Margin = new Padding(3, 2, 3, 2);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(284, 23);
            txt_direccion.TabIndex = 7;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(170, 219);
            txt_correo.Margin = new Padding(3, 2, 3, 2);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(284, 23);
            txt_correo.TabIndex = 8;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(170, 270);
            txt_telefono.Margin = new Padding(3, 2, 3, 2);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(284, 23);
            txt_telefono.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, productosToolStripMenuItem, proovedoresToolStripMenuItem, inventarioToolStripMenuItem, ventasToolStripMenuItem, usuariosToolStripMenuItem, clientesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(689, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(73, 20);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // proovedoresToolStripMenuItem
            // 
            proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
 
            proovedoresToolStripMenuItem.Size = new Size(85, 20);
            proovedoresToolStripMenuItem.Text = "Proovedores";

            proovedoresToolStripMenuItem.Size = new Size(105, 24);
            proovedoresToolStripMenuItem.Text = "Proveedores";
            proovedoresToolStripMenuItem.Click += proovedoresToolStripMenuItem_Click;
 
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
 
            usuariosToolStripMenuItem.Size = new Size(64, 20);

            usuariosToolStripMenuItem.Size = new Size(79, 24);
 
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // clientesToolStripMenuItem
            // 

            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);

            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rHToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
 
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // txt_guardar
            // 
            txt_guardar.ImageAlign = ContentAlignment.MiddleRight;
            txt_guardar.Location = new Point(170, 362);
            txt_guardar.Margin = new Padding(3, 2, 3, 2);
            txt_guardar.Name = "txt_guardar";
            txt_guardar.Size = new Size(130, 56);
            txt_guardar.TabIndex = 11;
            txt_guardar.Text = "Guardar";
            txt_guardar.UseVisualStyleBackColor = true;
            txt_guardar.Click += button1_Click;
            // 
            // txt_eliminar
            // 
            txt_eliminar.Location = new Point(506, 362);
            txt_eliminar.Margin = new Padding(3, 2, 3, 2);
            txt_eliminar.Name = "txt_eliminar";
            txt_eliminar.Size = new Size(141, 56);
            txt_eliminar.TabIndex = 12;
            txt_eliminar.Text = "Eliminar";
            txt_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_actualizar
            // 
            txt_actualizar.Location = new Point(347, 362);
            txt_actualizar.Margin = new Padding(3, 2, 3, 2);
            txt_actualizar.Name = "txt_actualizar";
            txt_actualizar.Size = new Size(123, 56);
            txt_actualizar.TabIndex = 13;
            txt_actualizar.Text = "Actualizar";
            txt_actualizar.UseVisualStyleBackColor = true;
            // 
 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 330);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 14;
            label6.Text = "Contraseña";

            // rHToolStripMenuItem
            // 
            rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            rHToolStripMenuItem.Size = new Size(224, 26);
            rHToolStripMenuItem.Text = "RH";

            // 
            // frmConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(689, 437);
            Controls.Add(label6);
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
            Margin = new Padding(3, 2, 3, 2);
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
 
        private Label label6;

        private ToolStripMenuItem rHToolStripMenuItem;
 
    }
}