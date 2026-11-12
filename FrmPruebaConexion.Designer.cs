namespace Biblioteca
{
    partial class FrmPruebaConexion
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAutoria = new Label();
            btnTestMariaDB = new Button();
            btnTestMongoDB = new Button();
            btnGuardarPrueba = new Button();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // lblAutoria
            // 
            lblAutoria.AutoSize = true;
            lblAutoria.Location = new Point(12, 9);
            lblAutoria.Name = "lblAutoria";
            lblAutoria.Size = new Size(500, 45);
            lblAutoria.TabIndex = 0;
            lblAutoria.Text = "Equipo N°: 3\r\nCONTRERAS Rodríguez Janis Isabel, MACÍAS Cruz Meredith Miranda,\r\nTORRES Barrera José Ángel";
            // 
            // btnTestMariaDB
            // 
            btnTestMariaDB.Location = new Point(12, 70);
            btnTestMariaDB.Name = "btnTestMariaDB";
            btnTestMariaDB.Size = new Size(160, 32);
            btnTestMariaDB.TabIndex = 1;
            btnTestMariaDB.Text = "Test Conexión MariaDB";
            btnTestMariaDB.UseVisualStyleBackColor = true;
            btnTestMariaDB.Click += btnTestMariaDB_Click;
            // 
            // btnTestMongoDB
            // 
            btnTestMongoDB.Location = new Point(182, 70);
            btnTestMongoDB.Name = "btnTestMongoDB";
            btnTestMongoDB.Size = new Size(160, 32);
            btnTestMongoDB.TabIndex = 2;
            btnTestMongoDB.Text = "Test Conexión MongoDB";
            btnTestMongoDB.UseVisualStyleBackColor = true;
            btnTestMongoDB.Click += btnTestMongoDB_Click;
            // 
            // btnGuardarPrueba
            // 
            btnGuardarPrueba.Location = new Point(352, 70);
            btnGuardarPrueba.Name = "btnGuardarPrueba";
            btnGuardarPrueba.Size = new Size(200, 32);
            btnGuardarPrueba.TabIndex = 3;
            btnGuardarPrueba.Text = "Guardar género de prueba";
            btnGuardarPrueba.UseVisualStyleBackColor = true;
            btnGuardarPrueba.Click += btnGuardarPrueba_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 114);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(620, 200);
            txtResultado.TabIndex = 4;
            // 
            // FrmPruebaConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 326);
            Controls.Add(txtResultado);
            Controls.Add(btnGuardarPrueba);
            Controls.Add(btnTestMongoDB);
            Controls.Add(btnTestMariaDB);
            Controls.Add(lblAutoria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmPruebaConexion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Prueba de conexión a bases de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAutoria;
        private Button btnTestMariaDB;
        private Button btnTestMongoDB;
        private Button btnGuardarPrueba;
        private TextBox txtResultado;
    }
}