﻿namespace POS
{
    partial class Menu_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btn_ajuste = new Button();
            btn_configuracion = new Button();
            btn_orden = new Button();
            btn_alnacen = new Button();
            btn_perfil = new Button();
            panelLogo = new Panel();
            panelTitulo = new Panel();
            lbl_Inicio = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_cerrar = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btn_ajuste);
            panelMenu.Controls.Add(btn_configuracion);
            panelMenu.Controls.Add(btn_orden);
            panelMenu.Controls.Add(btn_alnacen);
            panelMenu.Controls.Add(btn_perfil);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 561);
            panelMenu.TabIndex = 0;
            // 
            // btn_ajuste
            // 
            btn_ajuste.Dock = DockStyle.Top;
            btn_ajuste.FlatStyle = FlatStyle.Flat;
            btn_ajuste.ForeColor = Color.White;
            btn_ajuste.Location = new Point(0, 323);
            btn_ajuste.Name = "btn_ajuste";
            btn_ajuste.Size = new Size(220, 60);
            btn_ajuste.TabIndex = 5;
            btn_ajuste.Text = "Ajustes";
            btn_ajuste.UseVisualStyleBackColor = true;
            // 
            // btn_configuracion
            // 
 


            btn_configuracion.Dock = DockStyle.Top;
            btn_configuracion.FlatStyle = FlatStyle.Flat;
            btn_configuracion.ForeColor = Color.White;
            btn_configuracion.Location = new Point(0, 263);
            btn_configuracion.Name = "btn_configuracion";
            btn_configuracion.Size = new Size(220, 60);
            btn_configuracion.TabIndex = 4;
            btn_configuracion.Text = "Configuracion";
            btn_configuracion.UseVisualStyleBackColor = true;

            // 
            // btn_orden
            // 
            btn_orden.Dock = DockStyle.Top;
            btn_orden.FlatStyle = FlatStyle.Flat;
            btn_orden.ForeColor = Color.White;
            btn_orden.Location = new Point(0, 203);
            btn_orden.Name = "btn_orden";
            btn_orden.Size = new Size(220, 60);
            btn_orden.TabIndex = 3;
            btn_orden.Text = "Ventas";
            btn_orden.UseVisualStyleBackColor = true;
            // 
            // btn_alnacen
            // 
            btn_alnacen.Dock = DockStyle.Top;
            btn_alnacen.FlatStyle = FlatStyle.Flat;
            btn_alnacen.ForeColor = Color.White;
            btn_alnacen.Location = new Point(0, 143);
            btn_alnacen.Name = "btn_alnacen";
            btn_alnacen.Size = new Size(220, 60);
            btn_alnacen.TabIndex = 2;
            btn_alnacen.Text = "Productos";
            btn_alnacen.UseVisualStyleBackColor = true;
            btn_alnacen.Click += button1_Click_1;
            // 
            // btn_perfil
            // 
            btn_perfil.Dock = DockStyle.Top;
            btn_perfil.FlatStyle = FlatStyle.Flat;
            btn_perfil.ForeColor = Color.White;
            btn_perfil.Location = new Point(0, 83);
            btn_perfil.Name = "btn_perfil";
            btn_perfil.Size = new Size(220, 60);
            btn_perfil.TabIndex = 1;
            btn_perfil.Text = "Perfil";
            btn_perfil.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 64, 64);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 83);
            panelLogo.TabIndex = 1;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(64, 64, 64);
            panelTitulo.Controls.Add(label3);
            panelTitulo.Controls.Add(label2);
            panelTitulo.Controls.Add(btn_cerrar);
            panelTitulo.Controls.Add(lbl_Inicio);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(220, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(764, 83);
            panelTitulo.TabIndex = 1;
            // 
            // lbl_Inicio
            // 
            lbl_Inicio.AutoSize = true;
            lbl_Inicio.BackColor = Color.SteelBlue;
            lbl_Inicio.Font = new Font("Sitka Banner", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Inicio.Location = new Point(46, 9);
            lbl_Inicio.Name = "lbl_Inicio";
            lbl_Inicio.Size = new Size(176, 65);
            lbl_Inicio.TabIndex = 0;
            lbl_Inicio.Text = "Mclaren";
            lbl_Inicio.TextAlign = ContentAlignment.TopCenter;
            lbl_Inicio.Click += lbl_Titulo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(364, 143);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 334);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(543, 286);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 3;
            label1.Text = "//Logo de Tienda//";
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(673, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(79, 42);
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Text = " Cerrar ";
            btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(494, 12);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(494, 59);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 3;
            label3.Text = "TIPO DE USUARIO";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 80);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(41, 421);
            button1.Name = "button1";
            button1.Size = new Size(121, 56);
            button1.TabIndex = 6;
            button1.Text = "Cerrar Sesion 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Location = new Point(217, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 80);
            panel1.TabIndex = 4;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Name = "Menu_Principal";
            Text = "Menú Principal";
            Load += Menu_Principal_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button btn_perfil;
        private Panel panelLogo;
        private Button btn_ajuste;
        private Button btn_configuracion;
        private Button btn_orden;
        private Button btn_alnacen;
        private Panel panelTitulo;
        private Label lbl_Inicio;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_cerrar;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Panel panel1;
    }
}
