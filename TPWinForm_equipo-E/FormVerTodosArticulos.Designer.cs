﻿namespace CatalogoDeArticulos
{
    partial class FormVerTodosArticulos
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
            this.DgvVerTodosArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVerTodosArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVerTodosArticulos
            // 
            this.DgvVerTodosArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVerTodosArticulos.Location = new System.Drawing.Point(0, 0);
            this.DgvVerTodosArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvVerTodosArticulos.Name = "DgvVerTodosArticulos";
            this.DgvVerTodosArticulos.RowHeadersWidth = 51;
            this.DgvVerTodosArticulos.RowTemplate.Height = 24;
            this.DgvVerTodosArticulos.Size = new System.Drawing.Size(603, 217);
            this.DgvVerTodosArticulos.TabIndex = 0;
            this.DgvVerTodosArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVerTodosArticulos_CellContentClick);
            this.DgvVerTodosArticulos.SelectionChanged += new System.EventHandler(this.DgvVerTodosArticulos_SelectionChanged);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(639, 0);
            this.pictureBoxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(268, 217);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 1;
            this.pictureBoxArticulo.TabStop = false;
            this.pictureBoxArticulo.Click += new System.EventHandler(this.pictureBoxArticulo_Click);
            this.pictureBoxArticulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxArticulo_MouseClick);
            // 
            // FormVerTodosArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.DgvVerTodosArticulos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormVerTodosArticulos";
            this.Text = "FormVerTodosArticulos";
            this.Load += new System.EventHandler(this.FormVerTodosArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVerTodosArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVerTodosArticulos;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
    }
}