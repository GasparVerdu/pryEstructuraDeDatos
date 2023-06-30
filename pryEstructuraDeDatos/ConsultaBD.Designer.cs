namespace pryEstructuraDeDatos
{
    partial class FrmConsultaBaseDatos
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
            this.txtConsultaSql = new System.Windows.Forms.TextBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblConsultaSql = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaSql
            // 
            this.txtConsultaSql.Location = new System.Drawing.Point(12, 40);
            this.txtConsultaSql.Multiline = true;
            this.txtConsultaSql.Name = "txtConsultaSql";
            this.txtConsultaSql.Size = new System.Drawing.Size(612, 175);
            this.txtConsultaSql.TabIndex = 0;
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(12, 250);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(612, 188);
            this.grilla.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(550, 221);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblConsultaSql
            // 
            this.lblConsultaSql.AutoSize = true;
            this.lblConsultaSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSql.Location = new System.Drawing.Point(12, 17);
            this.lblConsultaSql.Name = "lblConsultaSql";
            this.lblConsultaSql.Size = new System.Drawing.Size(120, 20);
            this.lblConsultaSql.TabIndex = 3;
            this.lblConsultaSql.Text = "Consulta SQL";
            // 
            // FrmConsultaBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.lblConsultaSql);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.txtConsultaSql);
            this.Name = "FrmConsultaBaseDatos";
            this.Text = "Consulta base de datos";
            this.Load += new System.EventHandler(this.FrmConsultaBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsultaSql;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblConsultaSql;
    }
}