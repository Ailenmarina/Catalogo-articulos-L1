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
    public partial class FormAgregarArticulo : Form
    {
        private List<Imagen> ListaImagenes;
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloServer articuloServer = new ArticuloServer();
            try
            {
                articulo.Codigo= textCodigoArt.Text;
                articulo.Nombre= textNombreArt.Text;
                articulo.Descripcion= textDescripcionArt.Text;
                articulo.IdMarca = int.Parse(textIdMarcaArt.Text);
                articulo.IdCategoria=int.Parse(textIdCategoriaArt.Text);
                articulo.Imagenes = ListaImagenes;
                articulo.Precio=decimal.Parse(textPrecio.Text);
                articuloServer.Agregar(articulo);
                MessageBox.Show("Se ha guardado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textIdMarcaArt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
