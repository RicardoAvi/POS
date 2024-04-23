namespace POS
{
    partial class Productos
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
            panel2 = new Panel();
            label2 = new Label();
            btn_editarProducto = new Button();
            btn_regresarPD = new Button();
            btn_almacen = new Button();
            pictureBox1 = new PictureBox();
            btn_eliminarProducto = new Button();
            label1 = new Label();
            btn_nuevoProducto = new Button();
            tabControl1 = new TabControl();
            tabla_producto = new TabPage();
            tabla_talla = new TabPage();
            tabla_precioCompra = new TabPage();
            tabla_cantidad = new TabPage();
            tabla_precioVenta = new TabPage();
            tabla_comentariosP = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 561);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_editarProducto);
            panel2.Controls.Add(btn_regresarPD);
            panel2.Controls.Add(btn_almacen);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_eliminarProducto);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_nuevoProducto);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 97);
            panel2.TabIndex = 1;
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
            // btn_editarProducto
            // 
            btn_editarProducto.BackColor = Color.FromArgb(224, 224, 224);
            btn_editarProducto.Location = new Point(208, 49);
            btn_editarProducto.Name = "btn_editarProducto";
            btn_editarProducto.Size = new Size(133, 33);
            btn_editarProducto.TabIndex = 6;
            btn_editarProducto.Text = "Editar";
            btn_editarProducto.UseVisualStyleBackColor = false;
            // 
            // btn_regresarPD
            // 
            btn_regresarPD.BackColor = Color.FromArgb(224, 224, 224);
            btn_regresarPD.Location = new Point(753, 49);
            btn_regresarPD.Name = "btn_regresarPD";
            btn_regresarPD.Size = new Size(115, 33);
            btn_regresarPD.TabIndex = 5;
            btn_regresarPD.Text = "Regresar";
            btn_regresarPD.UseVisualStyleBackColor = false;
            // 
            // btn_almacen
            // 
            btn_almacen.BackColor = Color.FromArgb(224, 224, 224);
            btn_almacen.Location = new Point(572, 49);
            btn_almacen.Name = "btn_almacen";
            btn_almacen.Size = new Size(133, 33);
            btn_almacen.TabIndex = 2;
            btn_almacen.Text = "Almacen";
            btn_almacen.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(887, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_eliminarProducto
            // 
            btn_eliminarProducto.BackColor = Color.FromArgb(224, 224, 224);
            btn_eliminarProducto.Location = new Point(408, 49);
            btn_eliminarProducto.Name = "btn_eliminarProducto";
            btn_eliminarProducto.Size = new Size(115, 33);
            btn_eliminarProducto.TabIndex = 3;
            btn_eliminarProducto.Text = "Eliminar Producto";
            btn_eliminarProducto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // btn_nuevoProducto
            // 
            btn_nuevoProducto.BackColor = Color.FromArgb(224, 224, 224);
            btn_nuevoProducto.Location = new Point(20, 49);
            btn_nuevoProducto.Name = "btn_nuevoProducto";
            btn_nuevoProducto.Size = new Size(115, 33);
            btn_nuevoProducto.TabIndex = 1;
            btn_nuevoProducto.Text = "Nuevo Producto";
            btn_nuevoProducto.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabla_producto);
            tabControl1.Controls.Add(tabla_talla);
            tabControl1.Controls.Add(tabla_precioCompra);
            tabControl1.Controls.Add(tabla_cantidad);
            tabControl1.Controls.Add(tabla_precioVenta);
            tabControl1.Controls.Add(tabla_comentariosP);
            tabControl1.Location = new Point(16, 149);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 377);
            tabControl1.TabIndex = 2;
            // 
            // tabla_producto
            // 
            tabla_producto.Location = new Point(4, 24);
            tabla_producto.Name = "tabla_producto";
            tabla_producto.Padding = new Padding(3);
            tabla_producto.Size = new Size(935, 349);
            tabla_producto.TabIndex = 1;
            tabla_producto.Text = "Producto";
            tabla_producto.UseVisualStyleBackColor = true;
            tabla_producto.Click += tabla_producto_Click;
            // 
            // tabla_talla
            // 
            tabla_talla.Location = new Point(4, 24);
            tabla_talla.Name = "tabla_talla";
            tabla_talla.Size = new Size(935, 349);
            tabla_talla.TabIndex = 2;
            tabla_talla.Text = "Talla";
            tabla_talla.UseVisualStyleBackColor = true;
            // 
            // tabla_precioCompra
            // 
            tabla_precioCompra.Location = new Point(4, 24);
            tabla_precioCompra.Name = "tabla_precioCompra";
            tabla_precioCompra.Size = new Size(935, 349);
            tabla_precioCompra.TabIndex = 3;
            tabla_precioCompra.Text = "Precio/Compra";
            tabla_precioCompra.UseVisualStyleBackColor = true;
            // 
            // tabla_cantidad
            // 
            tabla_cantidad.Location = new Point(4, 24);
            tabla_cantidad.Name = "tabla_cantidad";
            tabla_cantidad.Size = new Size(935, 349);
            tabla_cantidad.TabIndex = 4;
            tabla_cantidad.Text = "Cantidad";
            tabla_cantidad.UseVisualStyleBackColor = true;
            // 
            // tabla_precioVenta
            // 
            tabla_precioVenta.Location = new Point(4, 24);
            tabla_precioVenta.Name = "tabla_precioVenta";
            tabla_precioVenta.Size = new Size(935, 349);
            tabla_precioVenta.TabIndex = 5;
            tabla_precioVenta.Text = "Precio/Venta";
            tabla_precioVenta.UseVisualStyleBackColor = true;
            // 
            // tabla_comentariosP
            // 
            tabla_comentariosP.Location = new Point(4, 24);
            tabla_comentariosP.Name = "tabla_comentariosP";
            tabla_comentariosP.Size = new Size(935, 349);
            tabla_comentariosP.TabIndex = 6;
            tabla_comentariosP.Text = "Comentarios";
            tabla_comentariosP.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "Productos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button btn_editarProducto;
        private Button btn_regresarPD;
        private Button btn_almacen;
        private PictureBox pictureBox1;
        private Button btn_eliminarProducto;
        private Label label1;
        private Button btn_nuevoProducto;
        private TabControl tabControl1;
        private TabPage tabla_producto;
        private TabPage tabla_talla;
        private TabPage tabla_precioCompra;
        private TabPage tabla_cantidad;
        private TabPage tabla_precioVenta;
        private TabPage tabla_comentariosP;
    }
}