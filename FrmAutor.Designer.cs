namespace Biblioteca
{
    partial class FrmAutor
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
            btn_Autor_Imagen = new Button();
            txB_Autor_RutaImagen = new TextBox();
            label11 = new Label();
            ckB_Estado = new CheckBox();
            txB_Autor_Nacionalidad = new TextBox();
            txB_Autor_Correo = new TextBox();
            txB_Autor_Edad = new TextBox();
            txB_Autor_Nombre = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            textInfoAutor = new TextBox();
            pbxFotografia = new PictureBox();
            btnCargarFoto = new Button();
            ofdImagen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).BeginInit();
            pnlFormularioBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(btnCargarFoto);
            pnlFormularioBase.Controls.Add(pbxFotografia);
            pnlFormularioBase.Controls.Add(textInfoAutor);
            pnlFormularioBase.Controls.Add(btn_Autor_Imagen);
            pnlFormularioBase.Controls.Add(txB_Autor_RutaImagen);
            pnlFormularioBase.Controls.Add(label11);
            pnlFormularioBase.Controls.Add(ckB_Estado);
            pnlFormularioBase.Controls.Add(txB_Autor_Nacionalidad);
            pnlFormularioBase.Controls.Add(txB_Autor_Correo);
            pnlFormularioBase.Controls.Add(txB_Autor_Edad);
            pnlFormularioBase.Controls.Add(txB_Autor_Nombre);
            pnlFormularioBase.Controls.Add(label10);
            pnlFormularioBase.Controls.Add(label9);
            pnlFormularioBase.Controls.Add(label8);
            pnlFormularioBase.Controls.Add(label6);
            pnlFormularioBase.Size = new Size(1143, 881);
            pnlFormularioBase.Controls.SetChildIndex(pbxFotografia, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnCargarFoto, 0);
            pnlFormularioBase.Controls.SetChildIndex(label1, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(label6, 0);
            pnlFormularioBase.Controls.SetChildIndex(label8, 0);
            pnlFormularioBase.Controls.SetChildIndex(label9, 0);
            pnlFormularioBase.Controls.SetChildIndex(label10, 0);
            pnlFormularioBase.Controls.SetChildIndex(txB_Autor_Nombre, 0);
            pnlFormularioBase.Controls.SetChildIndex(txB_Autor_Edad, 0);
            pnlFormularioBase.Controls.SetChildIndex(txB_Autor_Correo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txB_Autor_Nacionalidad, 0);
            pnlFormularioBase.Controls.SetChildIndex(ckB_Estado, 0);
            pnlFormularioBase.Controls.SetChildIndex(label11, 0);
            pnlFormularioBase.Controls.SetChildIndex(txB_Autor_RutaImagen, 0);
            pnlFormularioBase.Controls.SetChildIndex(btn_Autor_Imagen, 0);
            pnlFormularioBase.Controls.SetChildIndex(textInfoAutor, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(102, 59);
            // 
            // label1
            // 
            label1.Location = new Point(69, 62);
            // 
            // btn_Autor_Imagen
            // 
            btn_Autor_Imagen.Location = new Point(445, 301);
            btn_Autor_Imagen.Margin = new Padding(3, 4, 3, 4);
            btn_Autor_Imagen.Name = "btn_Autor_Imagen";
            btn_Autor_Imagen.Size = new Size(34, 33);
            btn_Autor_Imagen.TabIndex = 27;
            btn_Autor_Imagen.Text = "...";
            btn_Autor_Imagen.UseVisualStyleBackColor = true;
            // 
            // txB_Autor_RutaImagen
            // 
            txB_Autor_RutaImagen.BackColor = SystemColors.ButtonHighlight;
            txB_Autor_RutaImagen.Location = new Point(157, 301);
            txB_Autor_RutaImagen.Margin = new Padding(3, 4, 3, 4);
            txB_Autor_RutaImagen.Name = "txB_Autor_RutaImagen";
            txB_Autor_RutaImagen.ReadOnly = true;
            txB_Autor_RutaImagen.Size = new Size(282, 27);
            txB_Autor_RutaImagen.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(69, 301);
            label11.Name = "label11";
            label11.Size = new Size(68, 23);
            label11.TabIndex = 25;
            label11.Text = "Imagen";
            // 
            // ckB_Estado
            // 
            ckB_Estado.AutoSize = true;
            ckB_Estado.Checked = true;
            ckB_Estado.CheckState = CheckState.Checked;
            ckB_Estado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckB_Estado.Location = new Point(406, 61);
            ckB_Estado.Margin = new Padding(3, 4, 3, 4);
            ckB_Estado.Name = "ckB_Estado";
            ckB_Estado.Size = new Size(73, 24);
            ckB_Estado.TabIndex = 24;
            ckB_Estado.Text = "Activo";
            ckB_Estado.UseVisualStyleBackColor = true;
            // 
            // txB_Autor_Nacionalidad
            // 
            txB_Autor_Nacionalidad.Location = new Point(194, 254);
            txB_Autor_Nacionalidad.Margin = new Padding(3, 4, 3, 4);
            txB_Autor_Nacionalidad.Name = "txB_Autor_Nacionalidad";
            txB_Autor_Nacionalidad.Size = new Size(245, 27);
            txB_Autor_Nacionalidad.TabIndex = 23;
            // 
            // txB_Autor_Correo
            // 
            txB_Autor_Correo.Location = new Point(147, 201);
            txB_Autor_Correo.Margin = new Padding(3, 4, 3, 4);
            txB_Autor_Correo.Name = "txB_Autor_Correo";
            txB_Autor_Correo.Size = new Size(292, 27);
            txB_Autor_Correo.TabIndex = 22;
            // 
            // txB_Autor_Edad
            // 
            txB_Autor_Edad.Location = new Point(132, 151);
            txB_Autor_Edad.Margin = new Padding(3, 4, 3, 4);
            txB_Autor_Edad.Name = "txB_Autor_Edad";
            txB_Autor_Edad.Size = new Size(114, 27);
            txB_Autor_Edad.TabIndex = 21;
            // 
            // txB_Autor_Nombre
            // 
            txB_Autor_Nombre.Location = new Point(157, 102);
            txB_Autor_Nombre.Margin = new Padding(3, 4, 3, 4);
            txB_Autor_Nombre.Name = "txB_Autor_Nombre";
            txB_Autor_Nombre.Size = new Size(282, 27);
            txB_Autor_Nombre.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(69, 256);
            label10.Name = "label10";
            label10.Size = new Size(119, 23);
            label10.TabIndex = 18;
            label10.Text = "Nacionalidad: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(69, 203);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 17;
            label9.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(69, 155);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 16;
            label8.Text = "Edad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(69, 104);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 14;
            label6.Text = "Nombre: ";
            // 
            // textInfoAutor
            // 
            textInfoAutor.BackColor = SystemColors.Window;
            textInfoAutor.Enabled = false;
            textInfoAutor.Location = new Point(509, 41);
            textInfoAutor.Margin = new Padding(3, 4, 3, 4);
            textInfoAutor.Multiline = true;
            textInfoAutor.Name = "textInfoAutor";
            textInfoAutor.ReadOnly = true;
            textInfoAutor.ScrollBars = ScrollBars.Vertical;
            textInfoAutor.Size = new Size(598, 348);
            textInfoAutor.TabIndex = 28;
            // 
            // pbxFotografia  (Actividad 3.6: vista previa de la imagen)
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
            // btnCargarFoto  (Actividad 3.6: botón "Cargar Imagen")
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
            // FrmAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 881);
            Name = "FrmAutor";
            Text = "FrmAutor";
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).EndInit();
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Autor_Imagen;
        private TextBox txB_Autor_RutaImagen;
        private Label label11;
        private CheckBox ckB_Estado;
        private TextBox txB_Autor_Nacionalidad;
        private TextBox txB_Autor_Correo;
        private TextBox txB_Autor_Edad;
        private TextBox txB_Autor_Nombre;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private TextBox textInfoAutor;
        private PictureBox pbxFotografia;
        private Button btnCargarFoto;
        private OpenFileDialog ofdImagen;
    }
}