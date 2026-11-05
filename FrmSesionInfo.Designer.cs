namespace Biblioteca
{
    partial class FrmSesionInfo
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
            lblUsuarioTitulo = new Label();
            lblUsuarioValor = new Label();
            lblRolTitulo = new Label();
            lblRolValor = new Label();
            lblHoraTitulo = new Label();
            lblHoraValor = new Label();
            lblNota = new Label();
            btnActualizar = new Button();
            btnCerrar = new Button();
            lblAutoria = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Datos de la sesión activa";
            // 
            // lblUsuarioTitulo
            // 
            lblUsuarioTitulo.AutoSize = true;
            lblUsuarioTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioTitulo.Location = new Point(26, 76);
            lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            lblUsuarioTitulo.Size = new Size(68, 23);
            lblUsuarioTitulo.TabIndex = 1;
            lblUsuarioTitulo.Text = "Usuario:";
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 10F);
            lblUsuarioValor.Location = new Point(150, 76);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(15, 23);
            lblUsuarioValor.TabIndex = 2;
            lblUsuarioValor.Text = "-";
            // 
            // lblRolTitulo
            // 
            lblRolTitulo.AutoSize = true;
            lblRolTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRolTitulo.Location = new Point(26, 112);
            lblRolTitulo.Name = "lblRolTitulo";
            lblRolTitulo.Size = new Size(36, 23);
            lblRolTitulo.TabIndex = 3;
            lblRolTitulo.Text = "Rol:";
            // 
            // lblRolValor
            // 
            lblRolValor.AutoSize = true;
            lblRolValor.Font = new Font("Segoe UI", 10F);
            lblRolValor.Location = new Point(150, 112);
            lblRolValor.Name = "lblRolValor";
            lblRolValor.Size = new Size(15, 23);
            lblRolValor.TabIndex = 4;
            lblRolValor.Text = "-";
            // 
            // lblHoraTitulo
            // 
            lblHoraTitulo.AutoSize = true;
            lblHoraTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHoraTitulo.Location = new Point(26, 148);
            lblHoraTitulo.Name = "lblHoraTitulo";
            lblHoraTitulo.Size = new Size(118, 23);
            lblHoraTitulo.TabIndex = 5;
            lblHoraTitulo.Text = "Inicio de sesión:";
            // 
            // lblHoraValor
            // 
            lblHoraValor.AutoSize = true;
            lblHoraValor.Font = new Font("Segoe UI", 10F);
            lblHoraValor.Location = new Point(150, 148);
            lblHoraValor.Name = "lblHoraValor";
            lblHoraValor.Size = new Size(15, 23);
            lblHoraValor.TabIndex = 6;
            lblHoraValor.Text = "-";
            // 
            // lblNota
            // 
            lblNota.ForeColor = SystemColors.GrayText;
            lblNota.Location = new Point(26, 192);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(380, 44);
            lblNota.TabIndex = 7;
            lblNota.Text = "Estos datos se leen directamente de la clase estática SesionSistema, sin parámetros en el constructor ni base de datos.";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(196, 246);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 34);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(306, 246);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 34);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblAutoria
            // 
            lblAutoria.BorderStyle = BorderStyle.FixedSingle;
            lblAutoria.Dock = DockStyle.Bottom;
            lblAutoria.Location = new Point(0, 298);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(430, 86);
            lblAutoria.TabIndex = 10;
            lblAutoria.Text = "Equipo 3\r\nCONTRERAS Rodríguez Janis Isabel\r\nMACÍAS Cruz Meredith Miranda\r\nTORRES Barrera José Ángel";
            lblAutoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmSesionInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 384);
            Controls.Add(lblAutoria);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(lblNota);
            Controls.Add(lblHoraValor);
            Controls.Add(lblHoraTitulo);
            Controls.Add(lblRolValor);
            Controls.Add(lblRolTitulo);
            Controls.Add(lblUsuarioValor);
            Controls.Add(lblUsuarioTitulo);
            Controls.Add(lblTitulo);
            Name = "FrmSesionInfo";
            Text = "Datos de sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuarioTitulo;
        private Label lblUsuarioValor;
        private Label lblRolTitulo;
        private Label lblRolValor;
        private Label lblHoraTitulo;
        private Label lblHoraValor;
        private Label lblNota;
        private Button btnActualizar;
        private Button btnCerrar;
        private Label lblAutoria;
    }
}
