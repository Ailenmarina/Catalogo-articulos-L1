namespace CatalogoDeArticulos
{
    partial class EliminarMarcacs
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
            this.BotonCancelarMarca = new System.Windows.Forms.Button();
            this.BotonAceptarMarca = new System.Windows.Forms.Button();
            this.txtBoxIDMarca = new System.Windows.Forms.TextBox();
            this.TextEliminarMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCancelarMarca
            // 
            this.BotonCancelarMarca.Location = new System.Drawing.Point(115, 100);
            this.BotonCancelarMarca.Name = "BotonCancelarMarca";
            this.BotonCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelarMarca.TabIndex = 8;
            this.BotonCancelarMarca.Text = "Cancelar";
            this.BotonCancelarMarca.UseVisualStyleBackColor = true;
            this.BotonCancelarMarca.Click += new System.EventHandler(this.BotonCancelarMarca_Click);
            // 
            // BotonAceptarMarca
            // 
            this.BotonAceptarMarca.Location = new System.Drawing.Point(15, 100);
            this.BotonAceptarMarca.Name = "BotonAceptarMarca";
            this.BotonAceptarMarca.Size = new System.Drawing.Size(75, 23);
            this.BotonAceptarMarca.TabIndex = 7;
            this.BotonAceptarMarca.Text = "Aceptar";
            this.BotonAceptarMarca.UseVisualStyleBackColor = true;
            this.BotonAceptarMarca.Click += new System.EventHandler(this.BotonAceptarMarca_Click);
            // 
            // txtBoxIDMarca
            // 
            this.txtBoxIDMarca.Location = new System.Drawing.Point(15, 61);
            this.txtBoxIDMarca.Name = "txtBoxIDMarca";
            this.txtBoxIDMarca.Size = new System.Drawing.Size(175, 22);
            this.txtBoxIDMarca.TabIndex = 6;
            // 
            // TextEliminarMarca
            // 
            this.TextEliminarMarca.AutoSize = true;
            this.TextEliminarMarca.Location = new System.Drawing.Point(12, 9);
            this.TextEliminarMarca.Name = "TextEliminarMarca";
            this.TextEliminarMarca.Size = new System.Drawing.Size(275, 32);
            this.TextEliminarMarca.TabIndex = 5;
            this.TextEliminarMarca.Text = "INGRESE LA ID DE LA MARCA QUE DESEA\r\nELIMINAR";
            // 
            // EliminarMarcacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 295);
            this.Controls.Add(this.BotonCancelarMarca);
            this.Controls.Add(this.BotonAceptarMarca);
            this.Controls.Add(this.txtBoxIDMarca);
            this.Controls.Add(this.TextEliminarMarca);
            this.Name = "EliminarMarcacs";
            this.Text = "EliminarMarcacs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCancelarMarca;
        private System.Windows.Forms.Button BotonAceptarMarca;
        private System.Windows.Forms.TextBox txtBoxIDMarca;
        private System.Windows.Forms.Label TextEliminarMarca;
    }
}