namespace pryEstructuraDeDatos
{
    partial class FrmDatosProgramador
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
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCarreraED = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbox
            // 
            this.pcbox.Location = new System.Drawing.Point(12, 12);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(120, 101);
            this.pcbox.TabIndex = 0;
            this.pcbox.TabStop = false;
            this.pcbox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(158, 12);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(228, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Gaspar Verdu";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(158, 58);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDocumento.Location = new System.Drawing.Point(228, 12);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(57, 15);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "44897844";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Materia:";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMat.Location = new System.Drawing.Point(228, 100);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(101, 15);
            this.lblMat.TabIndex = 6;
            this.lblMat.Text = "Estructura de datos";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarrera.Location = new System.Drawing.Point(228, 137);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(104, 15);
            this.lblCarrera.TabIndex = 7;
            this.lblCarrera.Text = "Analista en sistemas";
            // 
            // lblCarreraED
            // 
            this.lblCarreraED.AutoSize = true;
            this.lblCarreraED.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreraED.Location = new System.Drawing.Point(158, 137);
            this.lblCarreraED.Name = "lblCarreraED";
            this.lblCarreraED.Size = new System.Drawing.Size(48, 13);
            this.lblCarreraED.TabIndex = 8;
            this.lblCarreraED.Text = "Carrera";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 132);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDatosProgramador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 181);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCarreraED);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.pcbox);
            this.Name = "FrmDatosProgramador";
            this.Text = "Datos programador";
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblCarreraED;
        private System.Windows.Forms.Button btnVolver;
    }
}