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
            btn_nuevoProveedor = new Button();
            btn_historialCompras = new Button();
            label1 = new Label();
            btn_eliminarProveedor = new Button();
            pictureBox1 = new PictureBox();
            btn_regresarPC = new Button();
            tabControl1 = new TabControl();
            tabla_numero = new TabPage();
            tabla_nombreEmpresa = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_regresarPC);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_eliminarProveedor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_historialCompras);
            panel1.Controls.Add(btn_nuevoProveedor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 85);
            panel1.TabIndex = 0;
            // 
            // btn_nuevoProveedor
            // 
            btn_nuevoProveedor.Location = new Point(3, 52);
            btn_nuevoProveedor.Name = "btn_nuevoProveedor";
            btn_nuevoProveedor.Size = new Size(115, 33);
            btn_nuevoProveedor.TabIndex = 1;
            btn_nuevoProveedor.Text = "Nuevo Proveedor";
            btn_nuevoProveedor.UseVisualStyleBackColor = true;
            // 
            // btn_historialCompras
            // 
            btn_historialCompras.Location = new Point(124, 52);
            btn_historialCompras.Name = "btn_historialCompras";
            btn_historialCompras.Size = new Size(133, 33);
            btn_historialCompras.TabIndex = 2;
            btn_historialCompras.Text = "Historial de compras";
            btn_historialCompras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 1;
            label1.Text = "Proveedores";
            // 
            // btn_eliminarProveedor
            // 
            btn_eliminarProveedor.Location = new Point(263, 52);
            btn_eliminarProveedor.Name = "btn_eliminarProveedor";
            btn_eliminarProveedor.Size = new Size(115, 33);
            btn_eliminarProveedor.TabIndex = 3;
            btn_eliminarProveedor.Text = "Eliminar Proveedor";
            btn_eliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(700, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_regresarPC
            // 
            btn_regresarPC.Location = new Point(384, 52);
            btn_regresarPC.Name = "btn_regresarPC";
            btn_regresarPC.Size = new Size(115, 33);
            btn_regresarPC.TabIndex = 5;
            btn_regresarPC.Text = "Regresar";
            btn_regresarPC.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabla_numero);
            tabControl1.Controls.Add(tabla_nombreEmpresa);
            tabControl1.Location = new Point(12, 130);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(496, 251);
            tabControl1.TabIndex = 1;
            // 
            // tabla_numero
            // 
            tabla_numero.Location = new Point(4, 24);
            tabla_numero.Name = "tabla_numero";
            tabla_numero.Padding = new Padding(3);
            tabla_numero.Size = new Size(488, 223);
            tabla_numero.TabIndex = 0;
            tabla_numero.Text = "Numero";
            tabla_numero.UseVisualStyleBackColor = true;
            // 
            // tabla_nombreEmpresa
            // 
            tabla_nombreEmpresa.Location = new Point(4, 24);
            tabla_nombreEmpresa.Name = "tabla_nombreEmpresa";
            tabla_nombreEmpresa.Padding = new Padding(3);
            tabla_nombreEmpresa.Size = new Size(192, 72);
            tabla_nombreEmpresa.TabIndex = 1;
            tabla_nombreEmpresa.Text = "Nombre de empresa";
            tabla_nombreEmpresa.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private TabPage tabla_numero;
        private TabPage tabla_nombreEmpresa;
    }
}