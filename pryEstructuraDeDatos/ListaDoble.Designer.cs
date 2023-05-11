
namespace pryEstructuraDeDatos
{
    partial class ListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDoble));
            this.gboListado = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cboCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.grbElementoNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboListarDatos = new System.Windows.Forms.GroupBox();
            this.rboDescendente = new System.Windows.Forms.RadioButton();
            this.rboAscendente = new System.Windows.Forms.RadioButton();
            this.gboListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.gboElementoEliminado.SuspendLayout();
            this.grbElementoNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboListarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboListado
            // 
            this.gboListado.Controls.Add(this.lstListado);
            this.gboListado.Controls.Add(this.grilla);
            this.gboListado.Location = new System.Drawing.Point(12, 183);
            this.gboListado.Name = "gboListado";
            this.gboListado.Size = new System.Drawing.Size(465, 179);
            this.gboListado.TabIndex = 11;
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
            // gboElementoEliminado
            // 
            this.gboElementoEliminado.Controls.Add(this.cboCodigo);
            this.gboElementoEliminado.Controls.Add(this.btnEliminar);
            this.gboElementoEliminado.Controls.Add(this.lblCodigoEliminar);
            this.gboElementoEliminado.Location = new System.Drawing.Point(306, 12);
            this.gboElementoEliminado.Name = "gboElementoEliminado";
            this.gboElementoEliminado.Size = new System.Drawing.Size(177, 77);
            this.gboElementoEliminado.TabIndex = 10;
            this.gboElementoEliminado.TabStop = false;
            this.gboElementoEliminado.Text = "Elemento eliminado";
            // 
            // cboCodigo
            // 
            this.cboCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigo.FormattingEnabled = true;
            this.cboCodigo.Location = new System.Drawing.Point(56, 19);
            this.cboCodigo.Name = "cboCodigo";
            this.cboCodigo.Size = new System.Drawing.Size(109, 21);
            this.cboCodigo.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(15, 24);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminar.TabIndex = 4;
            this.lblCodigoEliminar.Text = "Codigo:";
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
            this.grbElementoNuevo.TabIndex = 9;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gboListarDatos
            // 
            this.gboListarDatos.Controls.Add(this.rboDescendente);
            this.gboListarDatos.Controls.Add(this.rboAscendente);
            this.gboListarDatos.Location = new System.Drawing.Point(306, 100);
            this.gboListarDatos.Name = "gboListarDatos";
            this.gboListarDatos.Size = new System.Drawing.Size(177, 77);
            this.gboListarDatos.TabIndex = 11;
            this.gboListarDatos.TabStop = false;
            this.gboListarDatos.Text = "Listar Datos";
            // 
            // rboDescendente
            // 
            this.rboDescendente.AutoSize = true;
            this.rboDescendente.Location = new System.Drawing.Point(8, 48);
            this.rboDescendente.Name = "rboDescendente";
            this.rboDescendente.Size = new System.Drawing.Size(89, 17);
            this.rboDescendente.TabIndex = 1;
            this.rboDescendente.TabStop = true;
            this.rboDescendente.Text = "Descendente";
            this.rboDescendente.UseVisualStyleBackColor = true;
            this.rboDescendente.CheckedChanged += new System.EventHandler(this.rboDescendente_CheckedChanged);
            // 
            // rboAscendente
            // 
            this.rboAscendente.AutoSize = true;
            this.rboAscendente.Location = new System.Drawing.Point(8, 25);
            this.rboAscendente.Name = "rboAscendente";
            this.rboAscendente.Size = new System.Drawing.Size(82, 17);
            this.rboAscendente.TabIndex = 0;
            this.rboAscendente.TabStop = true;
            this.rboAscendente.Text = "Ascendente";
            this.rboAscendente.UseVisualStyleBackColor = true;
            this.rboAscendente.CheckedChanged += new System.EventHandler(this.rboAscendente_CheckedChanged);
            // 
            // ListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 385);
            this.Controls.Add(this.gboListarDatos);
            this.Controls.Add(this.gboListado);
            this.Controls.Add(this.gboElementoEliminado);
            this.Controls.Add(this.grbElementoNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListaDoble";
            this.Text = "ListaDoble";
            this.Load += new System.EventHandler(this.ListaDoble_Load_1);
            this.gboListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.gboElementoEliminado.ResumeLayout(false);
            this.gboElementoEliminado.PerformLayout();
            this.grbElementoNuevo.ResumeLayout(false);
            this.grbElementoNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboListarDatos.ResumeLayout(false);
            this.gboListarDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboListado;
        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gboElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.GroupBox grbElementoNuevo;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboCodigo;
        private System.Windows.Forms.GroupBox gboListarDatos;
        private System.Windows.Forms.RadioButton rboDescendente;
        private System.Windows.Forms.RadioButton rboAscendente;
    }
}