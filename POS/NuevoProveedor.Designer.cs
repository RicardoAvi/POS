namespace POS
{
    partial class NuevoProveedor
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
            lbl_nombreNP = new Label();
            lbl_representanteNP = new Label();
            lbl_telefonoNP = new Label();
            lbl_correoNP = new Label();
            lbl_paginaNP = new Label();
            lbl_comentarios = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            panel4 = new Panel();
            panel2 = new Panel();
            btn_crearNP = new Button();
            btn_regresarP = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nombreNP
            // 
            lbl_nombreNP.AutoSize = true;
            lbl_nombreNP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_nombreNP.ForeColor = Color.Black;
            lbl_nombreNP.Location = new Point(187, 93);
            lbl_nombreNP.Name = "lbl_nombreNP";
            lbl_nombreNP.Size = new Size(61, 17);
            lbl_nombreNP.TabIndex = 0;
            lbl_nombreNP.Text = "Nombre:";
            // 
            // lbl_representanteNP
            // 
            lbl_representanteNP.AutoSize = true;
            lbl_representanteNP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_representanteNP.ForeColor = Color.Black;
            lbl_representanteNP.Location = new Point(187, 132);
            lbl_representanteNP.Name = "lbl_representanteNP";
            lbl_representanteNP.Size = new Size(99, 17);
            lbl_representanteNP.TabIndex = 1;
            lbl_representanteNP.Text = "Representante:";
            // 
            // lbl_telefonoNP
            // 
            lbl_telefonoNP.AutoSize = true;
            lbl_telefonoNP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_telefonoNP.ForeColor = Color.Black;
            lbl_telefonoNP.Location = new Point(187, 173);
            lbl_telefonoNP.Name = "lbl_telefonoNP";
            lbl_telefonoNP.Size = new Size(62, 17);
            lbl_telefonoNP.TabIndex = 2;
            lbl_telefonoNP.Text = "Telefono:";
            // 
            // lbl_correoNP
            // 
            lbl_correoNP.AutoSize = true;
            lbl_correoNP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_correoNP.ForeColor = Color.Black;
            lbl_correoNP.Location = new Point(187, 216);
            lbl_correoNP.Name = "lbl_correoNP";
            lbl_correoNP.Size = new Size(52, 17);
            lbl_correoNP.TabIndex = 3;
            lbl_correoNP.Text = "Correo:";
            // 
            // lbl_paginaNP
            // 
            lbl_paginaNP.AutoSize = true;
            lbl_paginaNP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lbl_paginaNP.ForeColor = Color.Black;
            lbl_paginaNP.Location = new Point(187, 258);
            lbl_paginaNP.Name = "lbl_paginaNP";
            lbl_paginaNP.Size = new Size(84, 17);
            lbl_paginaNP.TabIndex = 4;
            lbl_paginaNP.Text = "Pagina Web:";
            // 
            // lbl_comentarios
            // 
            lbl_comentarios.AutoSize = true;
            lbl_comentarios.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_comentarios.Location = new Point(289, 296);
            lbl_comentarios.Name = "lbl_comentarios";
            lbl_comentarios.Size = new Size(88, 17);
            lbl_comentarios.TabIndex = 5;
            lbl_comentarios.Text = "Comentarios:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_regresarP);
            panel1.Controls.Add(btn_crearNP);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_nombreNP);
            panel1.Controls.Add(lbl_comentarios);
            panel1.Controls.Add(lbl_representanteNP);
            panel1.Controls.Add(lbl_paginaNP);
            panel1.Controls.Add(lbl_telefonoNP);
            panel1.Controls.Add(lbl_correoNP);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 52);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 6;
            label1.Text = "Nuevo Proveedor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 210);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(289, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(270, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(289, 316);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(270, 78);
            textBox6.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(93, 450);
            panel4.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Right;
            panel2.ImeMode = ImeMode.Off;
            panel2.Location = new Point(707, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(93, 450);
            panel2.TabIndex = 15;
            // 
            // btn_crearNP
            // 
            btn_crearNP.BackColor = Color.Gainsboro;
            btn_crearNP.BackgroundImageLayout = ImageLayout.None;
            btn_crearNP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_crearNP.Location = new Point(315, 400);
            btn_crearNP.Name = "btn_crearNP";
            btn_crearNP.Size = new Size(108, 38);
            btn_crearNP.TabIndex = 16;
            btn_crearNP.Text = "Crear Proveedor";
            btn_crearNP.UseVisualStyleBackColor = false;
            // 
            // btn_regresarP
            // 
            btn_regresarP.BackColor = Color.Silver;
            btn_regresarP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_regresarP.Location = new Point(429, 400);
            btn_regresarP.Name = "btn_regresarP";
            btn_regresarP.Size = new Size(107, 38);
            btn_regresarP.TabIndex = 17;
            btn_regresarP.Text = "Regresar";
            btn_regresarP.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(93, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 40);
            panel3.TabIndex = 18;
            // 
            // NuevoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "NuevoProveedor";
            Text = "NuevoProveedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_nombreNP;
        private Label lbl_representanteNP;
        private Label lbl_telefonoNP;
        private Label lbl_correoNP;
        private Label lbl_paginaNP;
        private Label lbl_comentarios;
        private Panel panel1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button btn_regresarP;
        private Button btn_crearNP;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
    }
}