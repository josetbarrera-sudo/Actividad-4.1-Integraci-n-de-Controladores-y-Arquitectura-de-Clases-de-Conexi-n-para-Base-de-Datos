namespace Biblioteca
{
    partial class FrmBase
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
            components = new System.ComponentModel.Container();
            pnlFormularioBase = new Panel();
            txtId = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            pbxFotografia = new PictureBox();
            btnCargarFoto = new Button();
            ofdImagen = new OpenFileDialog();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(btnCargarFoto);
            pnlFormularioBase.Controls.Add(pbxFotografia);
            pnlFormularioBase.Controls.Add(txtId);
            pnlFormularioBase.Controls.Add(label1);
            pnlFormularioBase.Dock = DockStyle.Left;
            pnlFormularioBase.Location = new Point(0, 0);
            pnlFormularioBase.Name = "pnlFormularioBase";
            pnlFormularioBase.Size = new Size(1143, 343);
            pnlFormularioBase.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(223, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 128);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // pbxFotografia  (Actividad 3.6: vista previa de la imagen, común a todos los formularios)
            // 
            pbxFotografia.BackColor = SystemColors.ButtonHighlight;
            pbxFotografia.BorderStyle = BorderStyle.FixedSingle;
            pbxFotografia.Location = new Point(830, 490);
            pbxFotografia.Name = "pbxFotografia";
            pbxFotografia.Size = new Size(209, 200);
            pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFotografia.TabIndex = 95;
            pbxFotografia.TabStop = false;
            // 
            // btnCargarFoto  (Actividad 3.6: botón "Cargar Imagen", común a todos los formularios)
            // 
            btnCargarFoto.Location = new Point(830, 698);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(209, 32);
            btnCargarFoto.TabIndex = 96;
            btnCargarFoto.Text = "Cargar Imagen";
            btnCargarFoto.UseVisualStyleBackColor = true;
            // 
            // ofdImagen  (OpenFileDialog de la Actividad 3.3, filtrado a imágenes)
            // 
            ofdImagen.CheckFileExists = true;
            ofdImagen.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            ofdImagen.Title = "Seleccionar imagen";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 343);
            Controls.Add(pnlFormularioBase);
            Name = "FrmBase";
            Text = "FrmBase";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).EndInit();
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnlFormularioBase;
        protected TextBox txtId;
        protected Label label1;
        protected ErrorProvider errorProvider1;
        protected PictureBox pbxFotografia;
        protected Button btnCargarFoto;
        protected OpenFileDialog ofdImagen;
    }
}