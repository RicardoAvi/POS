﻿namespace POS
{
    partial class frm_clientes
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
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_numerocliente = new TextBox();
            txt_clave = new TextBox();
            txt_nombre = new TextBox();
            txt_telefono = new TextBox();
            txt_correo = new TextBox();
            label11 = new Label();
            txt_rfc = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(387, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 58);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.DarkCyan;
            panel2.Location = new Point(-1, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 51);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(712, 11);
            label5.Name = "label5";
            label5.Size = new Size(185, 31);
            label5.TabIndex = 4;
            label5.Text = "* Complementos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(511, 11);
            label4.Name = "label4";
            label4.Size = new Size(169, 31);
            label4.TabIndex = 3;
            label4.Text = "* Huella Digital";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(253, 11);
            label3.Name = "label3";
            label3.Size = new Size(212, 31);
            label3.TabIndex = 2;
            label3.Text = "* Datos Facturacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(46, 11);
            label2.Name = "label2";
            label2.Size = new Size(170, 31);
            label2.TabIndex = 0;
            label2.Text = "* Datos Basicos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(221, 140);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 2;
            label6.Text = "No. de Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(501, 140);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 3;
            label7.Text = "Clave:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.Location = new Point(29, 360);
            label8.Name = "label8";
            label8.Size = new Size(124, 31);
            label8.TabIndex = 4;
            label8.Text = "* Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.Location = new Point(24, 448);
            label9.Name = "label9";
            label9.Size = new Size(135, 31);
            label9.TabIndex = 5;
            label9.Text = "* Teléfono: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.Location = new Point(24, 522);
            label10.Name = "label10";
            label10.Size = new Size(102, 31);
            label10.TabIndex = 6;
            label10.Text = "* Correo";
            // 
            // txt_numerocliente
            // 
            txt_numerocliente.Location = new Point(213, 187);
            txt_numerocliente.Name = "txt_numerocliente";
            txt_numerocliente.Size = new Size(159, 27);
            txt_numerocliente.TabIndex = 7;
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(463, 187);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(156, 27);
            txt_clave.TabIndex = 8;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(198, 366);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(185, 27);
            txt_nombre.TabIndex = 9;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(198, 454);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(185, 27);
            txt_telefono.TabIndex = 10;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(198, 528);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(185, 27);
            txt_correo.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label11.Location = new Point(29, 278);
            label11.Name = "label11";
            label11.Size = new Size(71, 31);
            label11.TabIndex = 12;
            label11.Text = "* RFC";
            // 
            // txt_rfc
            // 
            txt_rfc.Location = new Point(198, 278);
            txt_rfc.Name = "txt_rfc";
            txt_rfc.Size = new Size(185, 27);
            txt_rfc.TabIndex = 13;
            // 
            // label12
            // 
            label12.BackColor = Color.GhostWhite;
            label12.Image = Properties.Resources.icons8_user_90;
            label12.Location = new Point(12, 140);
            label12.Name = "label12";
            label12.Size = new Size(153, 121);
            label12.TabIndex = 14;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 606);
            Controls.Add(label12);
            Controls.Add(txt_rfc);
            Controls.Add(label11);
            Controls.Add(txt_correo);
            Controls.Add(txt_telefono);
            Controls.Add(txt_nombre);
            Controls.Add(txt_clave);
            Controls.Add(txt_numerocliente);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_clientes";
            Text = "frm_clientes";
            Load += frm_clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_numerocliente;
        private TextBox txt_clave;
        private TextBox txt_nombre;
        private TextBox txt_telefono;
        private TextBox txt_correo;
        private Label label11;
        private TextBox txt_rfc;
        private Label label12;
    }
}