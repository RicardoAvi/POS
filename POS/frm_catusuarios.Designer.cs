namespace POS
{
    partial class frm_catusuarios
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
            picturebox_prueba = new PictureBox();
            USUARIOS = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_nombre = new TextBox();
            txt_apellidoP = new TextBox();
            txt_apellidoM = new TextBox();
            txt_correo = new TextBox();
            txt_direccion = new TextBox();
            btn_agregar = new Button();
            btn_eliminar = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_prueba).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(picturebox_prueba);
            panel1.Controls.Add(USUARIOS);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 196);
            panel1.TabIndex = 0;
            // 
            // picturebox_prueba
            // 
            picturebox_prueba.BackColor = Color.SlateGray;
            picturebox_prueba.Image = Properties.Resources.icons8_user_90;
            picturebox_prueba.Location = new Point(420, 69);
            picturebox_prueba.Name = "picturebox_prueba";
            picturebox_prueba.Size = new Size(88, 95);
            picturebox_prueba.TabIndex = 1;
            picturebox_prueba.TabStop = false;
            // 
            // USUARIOS
            // 
            USUARIOS.AutoSize = true;
            USUARIOS.Font = new Font("Myanmar Text", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOS.ForeColor = SystemColors.ButtonFace;
            USUARIOS.Location = new Point(360, 0);
            USUARIOS.Name = "USUARIOS";
            USUARIOS.Size = new Size(214, 66);
            USUARIOS.TabIndex = 0;
            USUARIOS.Text = "USUARIOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(27, 244);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 1;
            label1.Text = "* Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(27, 315);
            label2.Name = "label2";
            label2.Size = new Size(242, 38);
            label2.TabIndex = 2;
            label2.Text = "* Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(27, 391);
            label3.Name = "label3";
            label3.Size = new Size(252, 38);
            label3.TabIndex = 3;
            label3.Text = "* Apellido Materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(27, 452);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 4;
            label4.Text = "* Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new Point(27, 516);
            label5.Name = "label5";
            label5.Size = new Size(154, 38);
            label5.TabIndex = 5;
            label5.Text = "* Direccion";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(348, 244);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(289, 27);
            txt_nombre.TabIndex = 6;
            // 
            // txt_apellidoP
            // 
            txt_apellidoP.Location = new Point(348, 326);
            txt_apellidoP.Name = "txt_apellidoP";
            txt_apellidoP.Size = new Size(289, 27);
            txt_apellidoP.TabIndex = 7;
            // 
            // txt_apellidoM
            // 
            txt_apellidoM.Location = new Point(348, 402);
            txt_apellidoM.Name = "txt_apellidoM";
            txt_apellidoM.Size = new Size(289, 27);
            txt_apellidoM.TabIndex = 8;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(348, 463);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(289, 27);
            txt_correo.TabIndex = 9;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(348, 527);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(289, 27);
            txt_direccion.TabIndex = 10;
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(567, 592);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(153, 64);
            btn_agregar.TabIndex = 11;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(785, 592);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(153, 64);
            btn_eliminar.TabIndex = 12;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 596);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 13;
            label6.Text = "Contraseña";
            // 
            // frm_catusuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 668);
            Controls.Add(label6);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_agregar);
            Controls.Add(txt_direccion);
            Controls.Add(txt_correo);
            Controls.Add(txt_apellidoM);
            Controls.Add(txt_apellidoP);
            Controls.Add(txt_nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_catusuarios";
            Text = "frm_catusuarios";
            Load += frm_catusuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_prueba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label USUARIOS;
        private PictureBox picturebox_prueba;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_nombre;
        private TextBox txt_apellidoP;
        private TextBox txt_apellidoM;
        private TextBox txt_correo;
        private TextBox txt_direccion;
        private Button btn_agregar;
        private Button btn_eliminar;
        private Label label6;
    }
}