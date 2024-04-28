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
    public partial class EliminarArticulo : Form
    {
        public EliminarArticulo()
        {
            InitializeComponent();
        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloServer articuloServer = new ArticuloServer();
            try
            {
                articulo.ID = int.Parse(txtBoxID.Text);
                articuloServer.Eliminar(articulo.ID);
                MessageBox.Show("Se ha borrado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
