namespace CatalogoDeArticulos
{
    partial class FormAgregarArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigoArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNombreArt = new System.Windows.Forms.TextBox();
            this.textDescripcionArt = new System.Windows.Forms.TextBox();
            this.textImagenURL = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textIdMarcaArt = new System.Windows.Forms.TextBox();
            this.textIdCategoriaArt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de articulo:";
            // 
            // textCodigoArt
            // 
            this.textCodigoArt.Location = new System.Drawing.Point(251, 57);
            this.textCodigoArt.Margin = new System.Windows.Forms.Padding(4);
            this.textCodigoArt.Name = "textCodigoArt";
            this.textCodigoArt.Size = new System.Drawing.Size(168, 22);
            this.textCodigoArt.TabIndex = 1;
            this.textCodigoArt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "IdMarca:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "IdCategoria:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Imagen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio:";
            // 
            // textNombreArt
            // 
            this.textNombreArt.Location = new System.Drawing.Point(251, 95);
            this.textNombreArt.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreArt.Name = "textNombreArt";
            this.textNombreArt.Size = new System.Drawing.Size(168, 22);
            this.textNombreArt.TabIndex = 8;
            // 
            // textDescripcionArt
            // 
            this.textDescripcionArt.Location = new System.Drawing.Point(251, 133);
            this.textDescripcionArt.Margin = new System.Windows.Forms.Padding(4);
            this.textDescripcionArt.Name = "textDescripcionArt";
            this.textDescripcionArt.Size = new System.Drawing.Size(168, 22);
            this.textDescripcionArt.TabIndex = 9;
            // 
            // textImagenURL
            // 
            this.textImagenURL.Location = new System.Drawing.Point(251, 254);
            this.textImagenURL.Margin = new System.Windows.Forms.Padding(4);
            this.textImagenURL.Name = "textImagenURL";
            this.textImagenURL.Size = new System.Drawing.Size(168, 22);
            this.textImagenURL.TabIndex = 11;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(251, 293);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(168, 22);
            this.textPrecio.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(320, 379);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textIdMarcaArt
            // 
            this.textIdMarcaArt.Location = new System.Drawing.Point(251, 180);
            this.textIdMarcaArt.Margin = new System.Windows.Forms.Padding(4);
            this.textIdMarcaArt.Name = "textIdMarcaArt";
            this.textIdMarcaArt.Size = new System.Drawing.Size(168, 22);
            this.textIdMarcaArt.TabIndex = 15;
            this.textIdMarcaArt.TextChanged += new System.EventHandler(this.textIdMarcaArt_TextChanged);
            // 
            // textIdCategoriaArt
            // 
            this.textIdCategoriaArt.Location = new System.Drawing.Point(251, 219);
            this.textIdCategoriaArt.Margin = new System.Windows.Forms.Padding(4);
            this.textIdCategoriaArt.Name = "textIdCategoriaArt";
            this.textIdCategoriaArt.Size = new System.Drawing.Size(168, 22);
            this.textIdCategoriaArt.TabIndex = 16;
            // 
            // FormAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textIdCategoriaArt);
            this.Controls.Add(this.textIdMarcaArt);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textImagenURL);
            this.Controls.Add(this.textDescripcionArt);
            this.Controls.Add(this.textNombreArt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigoArt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAgregarArticulo";
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.FormAgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigoArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNombreArt;
        private System.Windows.Forms.TextBox textDescripcionArt;
        private System.Windows.Forms.TextBox textImagenURL;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textIdMarcaArt;
        private System.Windows.Forms.TextBox textIdCategoriaArt;
    }
}