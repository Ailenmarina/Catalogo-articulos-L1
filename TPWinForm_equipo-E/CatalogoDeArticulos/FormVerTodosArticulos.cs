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
    public partial class FormVerTodosArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public FormVerTodosArticulos()
        {
            InitializeComponent();
        }

        private void FormVerTodosArticulos_Load(object sender, EventArgs e)
        {
            ArticuloServer articuloServer = new ArticuloServer();
            listaArticulo= articuloServer.listar();
            DgvVerTodosArticulos.DataSource = listaArticulo;
            pictureBoxArticulo.Load(listaArticulo[0].ImagenUrl.ImagenURL);
        }

        private void pictureBoxArticulo_Click(object sender, EventArgs e)
        {
            Articulo Eleccion=(Articulo)DgvVerTodosArticulos.CurrentRow.DataBoundItem;
            pictureBoxArticulo.Load(Eleccion.ImagenUrl.ImagenURL);
        }

        private void pictureBoxArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo Eleccion = (Articulo)DgvVerTodosArticulos.CurrentRow.DataBoundItem;
            pictureBoxArticulo.Load(Eleccion.ImagenUrl.ImagenURL);
        }
    }
}
//ARREGLAR