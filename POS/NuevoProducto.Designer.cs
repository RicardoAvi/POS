namespace POS
{
    partial class NuevoProducto
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
            btn_regresarPr = new Button();
            btn_añadirNPr = new Button();
            txt_precioNPr = new TextBox();
            txt_correoNP = new TextBox();
            txt_VentaNPr = new TextBox();
            txt_codigoNPr = new TextBox();
            label1 = new Label();
            lbl_codigoNPr = new Label();
            lbl_representanteNP = new Label();
            lbl_paginaNP = new Label();
            lbl_telefonoNP = new Label();
            lbl_correoNP = new Label();
            rbd_x20 = new RadioButton();
            rbd_x30 = new RadioButton();
            rbd_x50 = new RadioButton();
            cmb_producto = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_regresarPr
            // 
            btn_regresarPr.BackColor = Color.FromArgb(224, 224, 224);
            btn_regresarPr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresarPr.Location = new Point(465, 457);
            btn_regresarPr.Name = "btn_regresarPr";
            btn_regresarPr.Size = new Size(107, 38);
            btn_regresarPr.TabIndex = 32;
            btn_regresarPr.Text = "Regresar";
            btn_regresarPr.UseVisualStyleBackColor = false;
            // 
            // btn_añadirNPr
            // 
            btn_añadirNPr.BackColor = Color.Gainsboro;
            btn_añadirNPr.BackgroundImageLayout = ImageLayout.None;
            btn_añadirNPr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadirNPr.Location = new Point(302, 457);
            btn_añadirNPr.Name = "btn_añadirNPr";
            btn_añadirNPr.Size = new Size(108, 38);
            btn_añadirNPr.TabIndex = 31;
            btn_añadirNPr.Text = "Añadir Producto";
            btn_añadirNPr.UseVisualStyleBackColor = false;
            // 
            // txt_precioNPr
            // 
            txt_precioNPr.Location = new Point(302, 383);
            txt_precioNPr.Name = "txt_precioNPr";
            txt_precioNPr.Size = new Size(270, 23);
            txt_precioNPr.TabIndex = 29;
            // 
            // txt_correoNP
            // 
            txt_correoNP.Location = new Point(302, 264);
            txt_correoNP.Name = "txt_correoNP";
            txt_correoNP.Size = new Size(270, 23);
            txt_correoNP.TabIndex = 28;
            // 
            // txt_VentaNPr
            // 
            txt_VentaNPr.Location = new Point(302, 204);
            txt_VentaNPr.Name = "txt_VentaNPr";
            txt_VentaNPr.Size = new Size(270, 23);
            txt_VentaNPr.TabIndex = 27;
            // 
            // txt_codigoNPr
            // 
            txt_codigoNPr.Location = new Point(302, 85);
            txt_codigoNPr.Name = "txt_codigoNPr";
            txt_codigoNPr.Size = new Size(270, 23);
            txt_codigoNPr.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 24;
            label1.Text = "Nuevo Producto";
            // 
            // lbl_codigoNPr
            // 
            lbl_codigoNPr.AutoSize = true;
            lbl_codigoNPr.FlatStyle = FlatStyle.System;
            lbl_codigoNPr.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_codigoNPr.ForeColor = Color.Black;
            lbl_codigoNPr.Location = new Point(118, 85);
            lbl_codigoNPr.Name = "lbl_codigoNPr";
            lbl_codigoNPr.Size = new Size(166, 23);
            lbl_codigoNPr.TabIndex = 18;
            lbl_codigoNPr.Text = "Codigo de barras:";
            // 
            // lbl_representanteNP
            // 
            lbl_representanteNP.AutoSize = true;
            lbl_representanteNP.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_representanteNP.ForeColor = Color.Black;
            lbl_representanteNP.Location = new Point(118, 146);
            lbl_representanteNP.Name = "lbl_representanteNP";
            lbl_representanteNP.Size = new Size(91, 23);
            lbl_representanteNP.TabIndex = 19;
            lbl_representanteNP.Text = "Producto";
            // 
            // lbl_paginaNP
            // 
            lbl_paginaNP.AutoSize = true;
            lbl_paginaNP.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lbl_paginaNP.ForeColor = Color.Black;
            lbl_paginaNP.Location = new Point(118, 264);
            lbl_paginaNP.Name = "lbl_paginaNP";
            lbl_paginaNP.Size = new Size(94, 23);
            lbl_paginaNP.TabIndex = 22;
            lbl_paginaNP.Text = "Ganancia";
            // 
            // lbl_telefonoNP
            // 
            lbl_telefonoNP.AutoSize = true;
            lbl_telefonoNP.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lbl_telefonoNP.ForeColor = Color.Black;
            lbl_telefonoNP.Location = new Point(118, 380);
            lbl_telefonoNP.Name = "lbl_telefonoNP";
            lbl_telefonoNP.Size = new Size(72, 23);
            lbl_telefonoNP.TabIndex = 20;
            lbl_telefonoNP.Text = "Precio:";
            // 
            // lbl_correoNP
            // 
            lbl_correoNP.AutoSize = true;
            lbl_correoNP.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            lbl_correoNP.ForeColor = Color.Black;
            lbl_correoNP.Location = new Point(118, 204);
            lbl_correoNP.Name = "lbl_correoNP";
            lbl_correoNP.Size = new Size(61, 23);
            lbl_correoNP.TabIndex = 21;
            lbl_correoNP.Text = "Venta";
            // 
            // rbd_x20
            // 
            rbd_x20.AutoSize = true;
            rbd_x20.Font = new Font("Segoe UI", 12F);
            rbd_x20.Location = new Point(302, 321);
            rbd_x20.Name = "rbd_x20";
            rbd_x20.Size = new Size(53, 25);
            rbd_x20.TabIndex = 33;
            rbd_x20.TabStop = true;
            rbd_x20.Text = "x20";
            rbd_x20.UseVisualStyleBackColor = true;
            rbd_x20.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbd_x30
            // 
            rbd_x30.AutoSize = true;
            rbd_x30.Font = new Font("Segoe UI", 12F);
            rbd_x30.Location = new Point(417, 321);
            rbd_x30.Name = "rbd_x30";
            rbd_x30.Size = new Size(53, 25);
            rbd_x30.TabIndex = 34;
            rbd_x30.TabStop = true;
            rbd_x30.Text = "x30";
            rbd_x30.UseVisualStyleBackColor = true;
            // 
            // rbd_x50
            // 
            rbd_x50.AutoSize = true;
            rbd_x50.Font = new Font("Segoe UI", 12F);
            rbd_x50.Location = new Point(519, 321);
            rbd_x50.Name = "rbd_x50";
            rbd_x50.Size = new Size(53, 25);
            rbd_x50.TabIndex = 35;
            rbd_x50.TabStop = true;
            rbd_x50.Text = "x50";
            rbd_x50.UseVisualStyleBackColor = true;
            // 
            // cmb_producto
            // 
            cmb_producto.FormattingEnabled = true;
            cmb_producto.Items.AddRange(new object[] { "Camisetas", "Pantalones", "Sueter", "Shorts" });
            cmb_producto.Location = new Point(302, 146);
            cmb_producto.Name = "cmb_producto";
            cmb_producto.Size = new Size(270, 23);
            cmb_producto.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(118, 321);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 37;
            label2.Text = "Lote";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_codigoNPr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbl_correoNP);
            panel1.Controls.Add(cmb_producto);
            panel1.Controls.Add(lbl_telefonoNP);
            panel1.Controls.Add(rbd_x50);
            panel1.Controls.Add(lbl_paginaNP);
            panel1.Controls.Add(rbd_x30);
            panel1.Controls.Add(lbl_representanteNP);
            panel1.Controls.Add(rbd_x20);
            panel1.Controls.Add(btn_regresarPr);
            panel1.Controls.Add(txt_codigoNPr);
            panel1.Controls.Add(btn_añadirNPr);
            panel1.Controls.Add(txt_VentaNPr);
            panel1.Controls.Add(txt_precioNPr);
            panel1.Controls.Add(txt_correoNP);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 561);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 50);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleTurquoise;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(96, 511);
            panel3.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(637, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 229);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleTurquoise;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(888, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(96, 511);
            panel4.TabIndex = 41;
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "NuevoProducto";
            Text = "NuevoProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_regresarPr;
        private Button btn_añadirNPr;
        private TextBox txt_precioNPr;
        private TextBox txt_correoNP;
        private TextBox txt_VentaNPr;
        private TextBox txt_codigoNPr;
        private Label label1;
        private Label lbl_codigoNPr;
        private Label lbl_representanteNP;
        private Label lbl_paginaNP;
        private Label lbl_telefonoNP;
        private Label lbl_correoNP;
        private RadioButton rbd_x20;
        private RadioButton rbd_x30;
        private RadioButton rbd_x50;
        private ComboBox cmb_producto;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}