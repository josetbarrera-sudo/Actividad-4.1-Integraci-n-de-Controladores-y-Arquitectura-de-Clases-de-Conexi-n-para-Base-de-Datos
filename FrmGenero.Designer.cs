namespace Biblioteca
{
    partial class FrmGenero
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
            btn_Imagen_frmGene = new Button();
            txb_RutaIma_frmGene = new TextBox();
            label69 = new Label();
            txb_Info_frmGene = new TextBox();
            ckb_Activo_frmGene = new CheckBox();
            txb_Descripcion_frmGene = new TextBox();
            label4 = new Label();
            txb_Nombre_frmGene = new TextBox();
            label2 = new Label();
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
            pnlFormularioBase.Controls.Add(btn_Imagen_frmGene);
            pnlFormularioBase.Controls.Add(txb_RutaIma_frmGene);
            pnlFormularioBase.Controls.Add(label69);
            pnlFormularioBase.Controls.Add(txb_Info_frmGene);
            pnlFormularioBase.Controls.Add(ckb_Activo_frmGene);
            pnlFormularioBase.Controls.Add(txb_Descripcion_frmGene);
            pnlFormularioBase.Controls.Add(label4);
            pnlFormularioBase.Controls.Add(txb_Nombre_frmGene);
            pnlFormularioBase.Controls.Add(label2);
            pnlFormularioBase.Size = new Size(1143, 882);
            pnlFormularioBase.Controls.SetChildIndex(pbxFotografia, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnCargarFoto, 0);
            pnlFormularioBase.Controls.SetChildIndex(label1, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(label2, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Nombre_frmGene, 0);
            pnlFormularioBase.Controls.SetChildIndex(label4, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Descripcion_frmGene, 0);
            pnlFormularioBase.Controls.SetChildIndex(ckb_Activo_frmGene, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Info_frmGene, 0);
            pnlFormularioBase.Controls.SetChildIndex(label69, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_RutaIma_frmGene, 0);
            pnlFormularioBase.Controls.SetChildIndex(btn_Imagen_frmGene, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 38);
            // 
            // label1
            // 
            label1.Location = new Point(120, 41);
            // 
            // btn_Imagen_frmGene
            // 
            btn_Imagen_frmGene.Location = new Point(384, 348);
            btn_Imagen_frmGene.Margin = new Padding(3, 4, 3, 4);
            btn_Imagen_frmGene.Name = "btn_Imagen_frmGene";
            btn_Imagen_frmGene.Size = new Size(38, 32);
            btn_Imagen_frmGene.TabIndex = 77;
            btn_Imagen_frmGene.Text = "...";
            btn_Imagen_frmGene.UseVisualStyleBackColor = true;
            // 
            // txb_RutaIma_frmGene
            // 
            txb_RutaIma_frmGene.BackColor = SystemColors.ButtonHighlight;
            txb_RutaIma_frmGene.Location = new Point(115, 348);
            txb_RutaIma_frmGene.Margin = new Padding(3, 4, 3, 4);
            txb_RutaIma_frmGene.Name = "txb_RutaIma_frmGene";
            txb_RutaIma_frmGene.ReadOnly = true;
            txb_RutaIma_frmGene.Size = new Size(261, 27);
            txb_RutaIma_frmGene.TabIndex = 76;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI", 9F);
            label69.Location = new Point(115, 324);
            label69.Name = "label69";
            label69.Size = new Size(59, 20);
            label69.TabIndex = 75;
            label69.Text = "Imagen";
            // 
            // txb_Info_frmGene
            // 
            txb_Info_frmGene.BackColor = SystemColors.ButtonHighlight;
            txb_Info_frmGene.Location = new Point(442, 28);
            txb_Info_frmGene.Margin = new Padding(3, 4, 3, 4);
            txb_Info_frmGene.Multiline = true;
            txb_Info_frmGene.Name = "txb_Info_frmGene";
            txb_Info_frmGene.ReadOnly = true;
            txb_Info_frmGene.ScrollBars = ScrollBars.Both;
            txb_Info_frmGene.Size = new Size(605, 332);
            txb_Info_frmGene.TabIndex = 74;
            // 
            // ckb_Activo_frmGene
            // 
            ckb_Activo_frmGene.AutoSize = true;
            ckb_Activo_frmGene.Location = new Point(120, 288);
            ckb_Activo_frmGene.Margin = new Padding(3, 4, 3, 4);
            ckb_Activo_frmGene.Name = "ckb_Activo_frmGene";
            ckb_Activo_frmGene.Size = new Size(73, 24);
            ckb_Activo_frmGene.TabIndex = 73;
            ckb_Activo_frmGene.Text = "Activo";
            ckb_Activo_frmGene.UseVisualStyleBackColor = true;
            // 
            // txb_Descripcion_frmGene
            // 
            txb_Descripcion_frmGene.BackColor = SystemColors.ButtonHighlight;
            txb_Descripcion_frmGene.Location = new Point(120, 158);
            txb_Descripcion_frmGene.Margin = new Padding(3, 4, 3, 4);
            txb_Descripcion_frmGene.Multiline = true;
            txb_Descripcion_frmGene.Name = "txb_Descripcion_frmGene";
            txb_Descripcion_frmGene.ReadOnly = true;
            txb_Descripcion_frmGene.ScrollBars = ScrollBars.Both;
            txb_Descripcion_frmGene.Size = new Size(302, 116);
            txb_Descripcion_frmGene.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 121);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 71;
            label4.Text = "Descripción:";
            // 
            // txb_Nombre_frmGene
            // 
            txb_Nombre_frmGene.Location = new Point(185, 79);
            txb_Nombre_frmGene.Margin = new Padding(3, 4, 3, 4);
            txb_Nombre_frmGene.Name = "txb_Nombre_frmGene";
            txb_Nombre_frmGene.Size = new Size(237, 27);
            txb_Nombre_frmGene.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 67;
            label2.Text = "Nombre:";
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
            // FrmGenero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 882);
            Name = "FrmGenero";
            Text = "FrmGenero";
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).EndInit();
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Imagen_frmGene;
        private TextBox txb_RutaIma_frmGene;
        private Label label69;
        private TextBox txb_Info_frmGene;
        private CheckBox ckb_Activo_frmGene;
        private TextBox txb_Descripcion_frmGene;
        private Label label4;
        private TextBox txb_Nombre_frmGene;
        private Label label2;
        private PictureBox pbxFotografia;
        private Button btnCargarFoto;
        private OpenFileDialog ofdImagen;
    }
}