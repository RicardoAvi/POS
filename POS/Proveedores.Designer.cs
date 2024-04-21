namespace POS
{
    partial class Proveedores
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
            panel1 = new Panel();
            btn_regresarPC = new Button();
            pictureBox1 = new PictureBox();
            btn_eliminarProveedor = new Button();
            label1 = new Label();
            btn_historialCompras = new Button();
            btn_nuevoProveedor = new Button();
            tabControl1 = new TabControl();
            tabla_empresa = new TabPage();
            btn_editarProveedor = new Button();
            tabla_representante = new TabPage();
            tabla_telefono = new TabPage();
            tabla_correo = new TabPage();
            tabla_pagina = new TabPage();
            tabla_comentarios = new TabPage();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_editarProveedor);
            panel1.Controls.Add(btn_regresarPC);
            panel1.Controls.Add(btn_historialCompras);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_eliminarProveedor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_nuevoProveedor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 97);
            panel1.TabIndex = 0;
            // 
            // btn_regresarPC
            // 
            btn_regresarPC.BackColor = Color.FromArgb(224, 224, 224);
            btn_regresarPC.Location = new Point(753, 49);
            btn_regresarPC.Name = "btn_regresarPC";
            btn_regresarPC.Size = new Size(115, 33);
            btn_regresarPC.TabIndex = 5;
            btn_regresarPC.Text = "Regresar";
            btn_regresarPC.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(887, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_eliminarProveedor
            // 
            btn_eliminarProveedor.BackColor = Color.FromArgb(224, 224, 224);
            btn_eliminarProveedor.Location = new Point(408, 49);
            btn_eliminarProveedor.Name = "btn_eliminarProveedor";
            btn_eliminarProveedor.Size = new Size(115, 33);
            btn_eliminarProveedor.TabIndex = 3;
            btn_eliminarProveedor.Text = "Eliminar Proveedor";
            btn_eliminarProveedor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 6);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 1;
            label1.Text = "Proveedores";
            // 
            // btn_historialCompras
            // 
            btn_historialCompras.BackColor = Color.FromArgb(224, 224, 224);
            btn_historialCompras.Location = new Point(572, 49);
            btn_historialCompras.Name = "btn_historialCompras";
            btn_historialCompras.Size = new Size(133, 33);
            btn_historialCompras.TabIndex = 2;
            btn_historialCompras.Text = "Historial de compras";
            btn_historialCompras.UseVisualStyleBackColor = false;
            // 
            // btn_nuevoProveedor
            // 
            btn_nuevoProveedor.BackColor = Color.FromArgb(224, 224, 224);
            btn_nuevoProveedor.Location = new Point(20, 49);
            btn_nuevoProveedor.Name = "btn_nuevoProveedor";
            btn_nuevoProveedor.Size = new Size(115, 33);
            btn_nuevoProveedor.TabIndex = 1;
            btn_nuevoProveedor.Text = "Nuevo Proveedor";
            btn_nuevoProveedor.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabla_empresa);
            tabControl1.Controls.Add(tabla_representante);
            tabControl1.Controls.Add(tabla_telefono);
            tabControl1.Controls.Add(tabla_correo);
            tabControl1.Controls.Add(tabla_pagina);
            tabControl1.Controls.Add(tabla_comentarios);
            tabControl1.Location = new Point(16, 155);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 377);
            tabControl1.TabIndex = 1;
            // 
            // tabla_empresa
            // 
            tabla_empresa.Location = new Point(4, 24);
            tabla_empresa.Name = "tabla_empresa";
            tabla_empresa.Padding = new Padding(3);
            tabla_empresa.Size = new Size(935, 349);
            tabla_empresa.TabIndex = 1;
            tabla_empresa.Text = "Empresa";
            tabla_empresa.UseVisualStyleBackColor = true;
            // 
            // btn_editarProveedor
            // 
            btn_editarProveedor.BackColor = Color.FromArgb(224, 224, 224);
            btn_editarProveedor.Location = new Point(208, 49);
            btn_editarProveedor.Name = "btn_editarProveedor";
            btn_editarProveedor.Size = new Size(133, 33);
            btn_editarProveedor.TabIndex = 6;
            btn_editarProveedor.Text = "Editar";
            btn_editarProveedor.UseVisualStyleBackColor = false;
            // 
            // tabla_representante
            // 
            tabla_representante.Location = new Point(4, 24);
            tabla_representante.Name = "tabla_representante";
            tabla_representante.Size = new Size(935, 349);
            tabla_representante.TabIndex = 2;
            tabla_representante.Text = "Representante";
            tabla_representante.UseVisualStyleBackColor = true;
            // 
            // tabla_telefono
            // 
            tabla_telefono.Location = new Point(4, 24);
            tabla_telefono.Name = "tabla_telefono";
            tabla_telefono.Size = new Size(935, 349);
            tabla_telefono.TabIndex = 3;
            tabla_telefono.Text = "telefono";
            tabla_telefono.UseVisualStyleBackColor = true;
            // 
            // tabla_correo
            // 
            tabla_correo.Location = new Point(4, 24);
            tabla_correo.Name = "tabla_correo";
            tabla_correo.Size = new Size(935, 349);
            tabla_correo.TabIndex = 4;
            tabla_correo.Text = "Correo";
            tabla_correo.UseVisualStyleBackColor = true;
            // 
            // tabla_pagina
            // 
            tabla_pagina.Location = new Point(4, 24);
            tabla_pagina.Name = "tabla_pagina";
            tabla_pagina.Size = new Size(935, 349);
            tabla_pagina.TabIndex = 5;
            tabla_pagina.Text = "Pagina Web";
            tabla_pagina.UseVisualStyleBackColor = true;
            // 
            // tabla_comentarios
            // 
            tabla_comentarios.Location = new Point(4, 24);
            tabla_comentarios.Name = "tabla_comentarios";
            tabla_comentarios.Size = new Size(935, 349);
            tabla_comentarios.TabIndex = 6;
            tabla_comentarios.Text = "Comentarios";
            tabla_comentarios.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(912, 39);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "imagen";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(984, 561);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Proveedores";
            Text = "Proveedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_historialCompras;
        private Button btn_nuevoProveedor;
        private Button btn_eliminarProveedor;
        private Label label1;
        private Button btn_regresarPC;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabla_empresa;
        private Button btn_editarProveedor;
        private TabPage tabla_representante;
        private TabPage tabla_telefono;
        private TabPage tabla_correo;
        private TabPage tabla_pagina;
        private TabPage tabla_comentarios;
        private Label label2;
    }
}