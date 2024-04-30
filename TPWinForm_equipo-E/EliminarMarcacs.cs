using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeArticulos
{
    public partial class EliminarMarcacs : Form
    {
        public EliminarMarcacs()
        {
            InitializeComponent();
        }

        private void BotonAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaServer marcaServer = new MarcaServer();
            try
            {
                marca.ID = int.Parse(txtBoxIDMarca.Text);
                marcaServer.Eliminar(marca.ID);
                MessageBox.Show("Se ha borrado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void BotonCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
