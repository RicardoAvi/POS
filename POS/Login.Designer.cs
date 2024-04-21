namespace POS
{
    partial class Login
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
            btn_ingresar = new Button();
            btn_cerrar = new Button();
            lbl_usuario = new Label();
            lbl_contraseña = new Label();
            txt_usuario = new TextBox();
            txt_contra = new TextBox();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.Location = new Point(520, 384);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(103, 45);
            btn_ingresar.TabIndex = 0;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.Location = new Point(386, 384);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(103, 45);
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.Location = new Point(294, 279);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(67, 20);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contraseña
            // 
            lbl_contraseña.AutoSize = true;
            lbl_contraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contraseña.Location = new Point(269, 332);
            lbl_contraseña.Name = "lbl_contraseña";
            lbl_contraseña.Size = new Size(92, 20);
            lbl_contraseña.TabIndex = 3;
            lbl_contraseña.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(386, 279);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(237, 23);
            txt_usuario.TabIndex = 4;
            // 
            // txt_contra
            // 
            txt_contra.Location = new Point(386, 333);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(237, 23);
            txt_contra.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_usuario);
            panel1.Controls.Add(btn_ingresar);
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(txt_contra);
            panel1.Controls.Add(lbl_contraseña);
            panel1.Controls.Add(txt_usuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 561);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(530, 222);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Empleado";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(401, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Administrador";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 118);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 9;
            label1.Text = "//Logo de Tienda//";
            // 
            // panel5
            // 
            panel5.BackColor = Color.CadetBlue;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(784, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 561);
            panel5.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 561);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 561);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 561);
            panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(386, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 123);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ingresar;
        private Button btn_cerrar;
        private Label lbl_usuario;
        private Label lbl_contraseña;
        private TextBox txt_usuario;
        private TextBox txt_contra;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}