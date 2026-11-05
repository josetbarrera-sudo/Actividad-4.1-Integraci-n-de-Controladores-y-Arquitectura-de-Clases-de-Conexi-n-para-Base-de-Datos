namespace Biblioteca
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            lblAutoria = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.Location = new Point(28, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio de sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 74);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 98);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(320, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(30, 140);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(88, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(30, 164);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(320, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(130, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(104, 34);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(246, 214);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 34);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAutoria
            // 
            lblAutoria.BorderStyle = BorderStyle.FixedSingle;
            lblAutoria.Dock = DockStyle.Bottom;
            lblAutoria.Location = new Point(0, 272);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(380, 86);
            lblAutoria.TabIndex = 7;
            lblAutoria.Text = "Equipo 3\r\nCONTRERAS Rodríguez Janis Isabel\r\nMACÍAS Cruz Meredith Miranda\r\nTORRES Barrera José Ángel";
            lblAutoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 358);
            Controls.Add(lblAutoria);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca - Iniciar sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblAutoria;
    }
}
