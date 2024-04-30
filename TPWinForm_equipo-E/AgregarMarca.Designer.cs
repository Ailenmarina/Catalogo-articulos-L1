namespace CatalogoDeArticulos
{
    partial class AgregarMarca
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textDescripcionMarcaArt = new System.Windows.Forms.TextBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // textDescripcionMarcaArt
            // 
            this.textDescripcionMarcaArt.Location = new System.Drawing.Point(102, 29);
            this.textDescripcionMarcaArt.Margin = new System.Windows.Forms.Padding(5);
            this.textDescripcionMarcaArt.Name = "textDescripcionMarcaArt";
            this.textDescripcionMarcaArt.Size = new System.Drawing.Size(152, 22);
            this.textDescripcionMarcaArt.TabIndex = 3;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Location = new System.Drawing.Point(262, 35);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(148, 16);
            this.lblAdvertencia.TabIndex = 4;
            this.lblAdvertencia.Text = "(Maximo 50 Caracteres)";
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(14, 86);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarMarca.TabIndex = 14;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(154, 86);
            this.btnCancelarMarca.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarMarca.TabIndex = 15;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 240);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.textDescripcionMarcaArt);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "AgregarMarca";
            this.Text = "AgregarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textDescripcionMarcaArt;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}