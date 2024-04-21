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
            productosToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            proovedoresToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 224);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(9, 163);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Domicilio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 364);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(145, 106);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(248, 27);
            txt_nombre.TabIndex = 5;
            // 
            // txt_domicilio
            // 
            txt_domicilio.Location = new Point(145, 164);
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.Size = new Size(248, 27);
            txt_domicilio.TabIndex = 6;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(145, 220);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(248, 27);
            txt_direccion.TabIndex = 7;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(145, 296);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(248, 27);
            txt_correo.TabIndex = 8;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(145, 364);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(248, 27);
            txt_telefono.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, productosToolStripMenuItem, proovedoresToolStripMenuItem, inventarioToolStripMenuItem, ventasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(901, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(89, 24);
            productosToolStripMenuItem.Text = "Productos";
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
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(222, 571);
            button1.Name = "button1";
            button1.Size = new Size(126, 59);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(648, 571);
            button2.Name = "button2";
            button2.Size = new Size(139, 59);
            button2.TabIndex = 12;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(448, 571);
            button3.Name = "button3";
            button3.Size = new Size(126, 59);
            button3.TabIndex = 13;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // proovedoresToolStripMenuItem
            // 
            proovedoresToolStripMenuItem.Name = "proovedoresToolStripMenuItem";
            proovedoresToolStripMenuItem.Size = new Size(106, 24);
            proovedoresToolStripMenuItem.Text = "Proovedores";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // frmConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(901, 651);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private ToolStripMenuItem proovedoresToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
    }
}