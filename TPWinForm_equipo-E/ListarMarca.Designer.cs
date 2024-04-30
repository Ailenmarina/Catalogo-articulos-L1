namespace CatalogoDeArticulos
{
    partial class ListarMarca
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
            this.DgvLeerMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLeerMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLeerMarcas
            // 
            this.DgvLeerMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLeerMarcas.Location = new System.Drawing.Point(3, 2);
            this.DgvLeerMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvLeerMarcas.Name = "DgvLeerMarcas";
            this.DgvLeerMarcas.RowHeadersWidth = 51;
            this.DgvLeerMarcas.RowTemplate.Height = 24;
            this.DgvLeerMarcas.Size = new System.Drawing.Size(383, 407);
            this.DgvLeerMarcas.TabIndex = 1;
            this.DgvLeerMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLeerMarcas_CellContentClick);
            // 
            // ListarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 452);
            this.Controls.Add(this.DgvLeerMarcas);
            this.Name = "ListarMarca";
            this.Text = "ListarMarca";
            this.Load += new System.EventHandler(this.ListarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLeerMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLeerMarcas;
    }
}