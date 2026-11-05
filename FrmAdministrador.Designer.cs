namespace Biblioteca
{
    partial class FrmAdministrador
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
            txb_Info_frmAdmin = new TextBox();
            txb_Depa_frmAdmin = new TextBox();
            dtp_FechaIng_frmAdmin = new DateTimePicker();
            cmb_Estado_frmAdmin = new ComboBox();
            cmb_NivAcc_frmAdmin = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txb_Correo_frmAdmin = new TextBox();
            txb_Edad_frmAdmin = new TextBox();
            txb_Nombre_frmAdmin = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_Imagen_frmAdmin = new Button();
            txb_RutaIma_frmAdmin = new TextBox();
            label69 = new Label();
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
            pnlFormularioBase.Controls.Add(btn_Imagen_frmAdmin);
            pnlFormularioBase.Controls.Add(txb_RutaIma_frmAdmin);
            pnlFormularioBase.Controls.Add(label69);
            pnlFormularioBase.Controls.Add(txb_Info_frmAdmin);
            pnlFormularioBase.Controls.Add(txb_Depa_frmAdmin);
            pnlFormularioBase.Controls.Add(dtp_FechaIng_frmAdmin);
            pnlFormularioBase.Controls.Add(cmb_Estado_frmAdmin);
            pnlFormularioBase.Controls.Add(cmb_NivAcc_frmAdmin);
            pnlFormularioBase.Controls.Add(label9);
            pnlFormularioBase.Controls.Add(label10);
            pnlFormularioBase.Controls.Add(label11);
            pnlFormularioBase.Controls.Add(txb_Correo_frmAdmin);
            pnlFormularioBase.Controls.Add(txb_Edad_frmAdmin);
            pnlFormularioBase.Controls.Add(txb_Nombre_frmAdmin);
            pnlFormularioBase.Controls.Add(label6);
            pnlFormularioBase.Controls.Add(label5);
            pnlFormularioBase.Controls.Add(label4);
            pnlFormularioBase.Controls.Add(label3);
            pnlFormularioBase.Size = new Size(1143, 886);
            pnlFormularioBase.Controls.SetChildIndex(pbxFotografia, 0);
            pnlFormularioBase.Controls.SetChildIndex(btnCargarFoto, 0);
            pnlFormularioBase.Controls.SetChildIndex(label3, 0);
            pnlFormularioBase.Controls.SetChildIndex(label4, 0);
            pnlFormularioBase.Controls.SetChildIndex(label5, 0);
            pnlFormularioBase.Controls.SetChildIndex(label6, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Nombre_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Edad_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Correo_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(label11, 0);
            pnlFormularioBase.Controls.SetChildIndex(label10, 0);
            pnlFormularioBase.Controls.SetChildIndex(label9, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmb_NivAcc_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(cmb_Estado_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtp_FechaIng_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Depa_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_Info_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(label1, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(label69, 0);
            pnlFormularioBase.Controls.SetChildIndex(txb_RutaIma_frmAdmin, 0);
            pnlFormularioBase.Controls.SetChildIndex(btn_Imagen_frmAdmin, 0);
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 47);
            // 
            // label1
            // 
            label1.Location = new Point(132, 50);
            // 
            // txb_Info_frmAdmin
            // 
            txb_Info_frmAdmin.BackColor = SystemColors.ButtonHighlight;
            txb_Info_frmAdmin.Location = new Point(422, 34);
            txb_Info_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            txb_Info_frmAdmin.Multiline = true;
            txb_Info_frmAdmin.Name = "txb_Info_frmAdmin";
            txb_Info_frmAdmin.ReadOnly = true;
            txb_Info_frmAdmin.ScrollBars = ScrollBars.Both;
            txb_Info_frmAdmin.Size = new Size(630, 432);
            txb_Info_frmAdmin.TabIndex = 49;
            // 
            // txb_Depa_frmAdmin
            // 
            txb_Depa_frmAdmin.Location = new Point(238, 285);
            txb_Depa_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            txb_Depa_frmAdmin.Name = "txb_Depa_frmAdmin";
            txb_Depa_frmAdmin.Size = new Size(150, 27);
            txb_Depa_frmAdmin.TabIndex = 48;
            // 
            // dtp_FechaIng_frmAdmin
            // 
            dtp_FechaIng_frmAdmin.Format = DateTimePickerFormat.Short;
            dtp_FechaIng_frmAdmin.Location = new Point(238, 330);
            dtp_FechaIng_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            dtp_FechaIng_frmAdmin.Name = "dtp_FechaIng_frmAdmin";
            dtp_FechaIng_frmAdmin.Size = new Size(150, 27);
            dtp_FechaIng_frmAdmin.TabIndex = 47;
            // 
            // cmb_Estado_frmAdmin
            // 
            cmb_Estado_frmAdmin.FormattingEnabled = true;
            cmb_Estado_frmAdmin.Items.AddRange(new object[] { "Activo", "Inactivo", "De vacaciones", "Suspendido" });
            cmb_Estado_frmAdmin.Location = new Point(200, 374);
            cmb_Estado_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            cmb_Estado_frmAdmin.Name = "cmb_Estado_frmAdmin";
            cmb_Estado_frmAdmin.Size = new Size(188, 28);
            cmb_Estado_frmAdmin.TabIndex = 46;
            // 
            // cmb_NivAcc_frmAdmin
            // 
            cmb_NivAcc_frmAdmin.FormattingEnabled = true;
            cmb_NivAcc_frmAdmin.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmb_NivAcc_frmAdmin.Location = new Point(251, 240);
            cmb_NivAcc_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            cmb_NivAcc_frmAdmin.Name = "cmb_NivAcc_frmAdmin";
            cmb_NivAcc_frmAdmin.Size = new Size(137, 28);
            cmb_NivAcc_frmAdmin.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 378);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 44;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(126, 331);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 43;
            label10.Text = "Fecha Ingreso:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(126, 289);
            label11.Name = "label11";
            label11.Size = new Size(109, 20);
            label11.TabIndex = 42;
            label11.Text = "Departamento:";
            // 
            // txb_Correo_frmAdmin
            // 
            txb_Correo_frmAdmin.Location = new Point(199, 190);
            txb_Correo_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            txb_Correo_frmAdmin.Name = "txb_Correo_frmAdmin";
            txb_Correo_frmAdmin.Size = new Size(189, 27);
            txb_Correo_frmAdmin.TabIndex = 41;
            // 
            // txb_Edad_frmAdmin
            // 
            txb_Edad_frmAdmin.Location = new Point(199, 141);
            txb_Edad_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            txb_Edad_frmAdmin.Name = "txb_Edad_frmAdmin";
            txb_Edad_frmAdmin.Size = new Size(189, 27);
            txb_Edad_frmAdmin.TabIndex = 40;
            // 
            // txb_Nombre_frmAdmin
            // 
            txb_Nombre_frmAdmin.Location = new Point(199, 88);
            txb_Nombre_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            txb_Nombre_frmAdmin.Name = "txb_Nombre_frmAdmin";
            txb_Nombre_frmAdmin.Size = new Size(188, 27);
            txb_Nombre_frmAdmin.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 243);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 37;
            label6.Text = "Nivel de Acceso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 194);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 36;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 145);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 35;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 91);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 34;
            label3.Text = "Nombre:";
            // 
            // btn_Imagen_frmAdmin
            // 
            btn_Imagen_frmAdmin.Location = new Point(350, 439);
            btn_Imagen_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            btn_Imagen_frmAdmin.Name = "btn_Imagen_frmAdmin";
            btn_Imagen_frmAdmin.Size = new Size(38, 32);
            btn_Imagen_frmAdmin.TabIndex = 80;
            btn_Imagen_frmAdmin.Text = "...";
            btn_Imagen_frmAdmin.UseVisualStyleBackColor = true;
            // 
            // txb_RutaIma_frmAdmin
            // 
            txb_RutaIma_frmAdmin.BackColor = SystemColors.ButtonHighlight;
            txb_RutaIma_frmAdmin.Location = new Point(126, 439);
            txb_RutaIma_frmAdmin.Margin = new Padding(3, 4, 3, 4);
            txb_RutaIma_frmAdmin.Name = "txb_RutaIma_frmAdmin";
            txb_RutaIma_frmAdmin.ReadOnly = true;
            txb_RutaIma_frmAdmin.Size = new Size(217, 27);
            txb_RutaIma_frmAdmin.TabIndex = 79;
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Font = new Font("Segoe UI", 9F);
            label69.Location = new Point(126, 415);
            label69.Name = "label69";
            label69.Size = new Size(59, 20);
            label69.TabIndex = 78;
            label69.Text = "Imagen";
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
            // FrmAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 886);
            Name = "FrmAdministrador";
            Text = "FrmAdministrador";
            ((System.ComponentModel.ISupportInitialize)pbxFotografia).EndInit();
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txb_Info_frmAdmin;
        private TextBox txb_Depa_frmAdmin;
        private DateTimePicker dtp_FechaIng_frmAdmin;
        private ComboBox cmb_Estado_frmAdmin;
        private ComboBox cmb_NivAcc_frmAdmin;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txb_Correo_frmAdmin;
        private TextBox txb_Edad_frmAdmin;
        private TextBox txb_Nombre_frmAdmin;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_Imagen_frmAdmin;
        private TextBox txb_RutaIma_frmAdmin;
        private Label label69;
        private PictureBox pbxFotografia;
        private Button btnCargarFoto;
        private OpenFileDialog ofdImagen;
    }
}