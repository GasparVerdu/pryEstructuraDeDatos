namespace pryEstructuraDeDatos
{
    partial class FrmColas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbElementoNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.gboElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteEliminarRes = new System.Windows.Forms.Label();
            this.lblNombreEliminarRes = new System.Windows.Forms.Label();
            this.lblCodigoEliminarRes = new System.Windows.Forms.Label();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboListado = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbElementoNuevo.SuspendLayout();
            this.gboElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.gboListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbElementoNuevo
            // 
            this.grbElementoNuevo.Controls.Add(this.txtTramiteNuevo);
            this.grbElementoNuevo.Controls.Add(this.txtNombreNuevo);
            this.grbElementoNuevo.Controls.Add(this.txtCodigoNuevo);
            this.grbElementoNuevo.Controls.Add(this.btnAgregar);
            this.grbElementoNuevo.Controls.Add(this.lblTramiteNuevo);
            this.grbElementoNuevo.Controls.Add(this.lblNombreNuevo);
            this.grbElementoNuevo.Controls.Add(this.lblCodigoNuevo);
            this.grbElementoNuevo.Location = new System.Drawing.Point(148, 12);
            this.grbElementoNuevo.Name = "grbElementoNuevo";
            this.grbElementoNuevo.Size = new System.Drawing.Size(152, 149);
            this.grbElementoNuevo.TabIndex = 1;
            this.grbElementoNuevo.TabStop = false;
            this.grbElementoNuevo.Text = "Nuevo elemento";
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Location = new System.Drawing.Point(63, 86);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(83, 20);
            this.txtTramiteNuevo.TabIndex = 6;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(63, 57);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(83, 20);
            this.txtNombreNuevo.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(63, 28);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigoNuevo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(14, 86);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteNuevo.TabIndex = 2;
            this.lblTramiteNuevo.Text = "Tramite:";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(14, 57);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreNuevo.TabIndex = 1;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(14, 28);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Codigo:";
            // 
            // gboElementoEliminado
            // 
            this.gboElementoEliminado.Controls.Add(this.lblTramiteEliminarRes);
            this.gboElementoEliminado.Controls.Add(this.lblNombreEliminarRes);
            this.gboElementoEliminado.Controls.Add(this.lblCodigoEliminarRes);
            this.gboElementoEliminado.Controls.Add(this.lblTramiteEliminar);
            this.gboElementoEliminado.Controls.Add(this.btnEliminar);
            this.gboElementoEliminado.Controls.Add(this.lblNombreEliminar);
            this.gboElementoEliminado.Controls.Add(this.lblCodigoEliminar);
            this.gboElementoEliminado.Location = new System.Drawing.Point(306, 12);
            this.gboElementoEliminado.Name = "gboElementoEliminado";
            this.gboElementoEliminado.Size = new System.Drawing.Size(177, 149);
            this.gboElementoEliminado.TabIndex = 2;
            this.gboElementoEliminado.TabStop = false;
            this.gboElementoEliminado.Text = "Elemento eliminado";
            // 
            // lblTramiteEliminarRes
            // 
            this.lblTramiteEliminarRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEliminarRes.Location = new System.Drawing.Point(66, 88);
            this.lblTramiteEliminarRes.Name = "lblTramiteEliminarRes";
            this.lblTramiteEliminarRes.Size = new System.Drawing.Size(99, 17);
            this.lblTramiteEliminarRes.TabIndex = 9;
            // 
            // lblNombreEliminarRes
            // 
            this.lblNombreEliminarRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEliminarRes.Location = new System.Drawing.Point(66, 59);
            this.lblNombreEliminarRes.Name = "lblNombreEliminarRes";
            this.lblNombreEliminarRes.Size = new System.Drawing.Size(99, 17);
            this.lblNombreEliminarRes.TabIndex = 8;
            // 
            // lblCodigoEliminarRes
            // 
            this.lblCodigoEliminarRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEliminarRes.Location = new System.Drawing.Point(66, 30);
            this.lblCodigoEliminarRes.Name = "lblCodigoEliminarRes";
            this.lblCodigoEliminarRes.Size = new System.Drawing.Size(99, 17);
            this.lblCodigoEliminarRes.TabIndex = 7;
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Location = new System.Drawing.Point(15, 86);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteEliminar.TabIndex = 6;
            this.lblTramiteEliminar.Text = "Tramite:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 120);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Location = new System.Drawing.Point(15, 57);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEliminar.TabIndex = 5;
            this.lblNombreEliminar.Text = "Nombre:";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(15, 28);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminar.TabIndex = 4;
            this.lblCodigoEliminar.Text = "Codigo:";
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.grilla.Location = new System.Drawing.Point(124, 19);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(335, 147);
            this.grilla.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // gboListado
            // 
            this.gboListado.Controls.Add(this.lstListado);
            this.gboListado.Controls.Add(this.grilla);
            this.gboListado.Location = new System.Drawing.Point(12, 183);
            this.gboListado.Name = "gboListado";
            this.gboListado.Size = new System.Drawing.Size(465, 179);
            this.gboListado.TabIndex = 3;
            this.gboListado.TabStop = false;
            this.gboListado.Text = "Listado en una grilla y lista";
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(6, 19);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(112, 147);
            this.lstListado.TabIndex = 4;
            // 
            // FrmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 374);
            this.Controls.Add(this.gboListado);
            this.Controls.Add(this.gboElementoEliminado);
            this.Controls.Add(this.grbElementoNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmColas";
            this.Text = "Estructura dinamica linea - Colas";
            this.Load += new System.EventHandler(this.FrmColas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbElementoNuevo.ResumeLayout(false);
            this.grbElementoNuevo.PerformLayout();
            this.gboElementoEliminado.ResumeLayout(false);
            this.gboElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.gboListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbElementoNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.GroupBox gboElementoEliminado;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Label lblTramiteEliminarRes;
        private System.Windows.Forms.Label lblNombreEliminarRes;
        private System.Windows.Forms.Label lblCodigoEliminarRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gboListado;
        private System.Windows.Forms.ListBox lstListado;
    }
}