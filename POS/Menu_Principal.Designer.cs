namespace POS
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
            btn_notificacion = new Button();
            btn_orden = new Button();
            btn_alnacen = new Button();
            btn_perfil = new Button();
            panelLogo = new Panel();
            lbl_titulo = new Label();
            panelTitulo = new Panel();
            lbl_Inicio = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.Controls.Add(btn_ajuste);
            panelMenu.Controls.Add(btn_notificacion);
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
            // btn_notificacion
            // 
            btn_notificacion.Dock = DockStyle.Top;
            btn_notificacion.FlatStyle = FlatStyle.Flat;
            btn_notificacion.ForeColor = Color.White;
            btn_notificacion.Location = new Point(0, 263);
            btn_notificacion.Name = "btn_notificacion";
            btn_notificacion.Size = new Size(220, 60);
            btn_notificacion.TabIndex = 4;
            btn_notificacion.Text = "Notificacion";
            btn_notificacion.UseVisualStyleBackColor = true;
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
            btn_orden.Text = "Orden";
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
            btn_alnacen.Text = "Almacén";
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
            panelLogo.Controls.Add(lbl_titulo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 83);
            panelLogo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(3, 22);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(219, 32);
            lbl_titulo.TabIndex = 2;
            lbl_titulo.Text = "HUMBLE clothing";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(64, 64, 64);
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
            lbl_Inicio.BackColor = Color.White;
            lbl_Inicio.Font = new Font("Sitka Banner", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Inicio.Location = new Point(27, 9);
            lbl_Inicio.Name = "lbl_Inicio";
            lbl_Inicio.Size = new Size(714, 65);
            lbl_Inicio.TabIndex = 0;
            lbl_Inicio.Text = "--------------------INICIO--------------------";
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
            label1.Location = new Point(543, 286);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 3;
            label1.Text = "//Logo de Tienda//";
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(984, 561);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Name = "Menu_Principal";
            Text = "Menú Principal";
            Load += Menu_Principal_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button btn_perfil;
        private Panel panelLogo;
        private Button btn_ajuste;
        private Button btn_notificacion;
        private Button btn_orden;
        private Button btn_alnacen;
        private Panel panelTitulo;
        private Label lbl_Inicio;
        private Label lbl_titulo;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
