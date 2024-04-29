using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogoDeArticulos;


namespace CatalogoDeArticulos
{
    public partial class FormVerTodosArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public FormVerTodosArticulos()
        {
            InitializeComponent();
        }


        private int imagenActual = 0; 

        private void FormVerTodosArticulos_Load(object sender, EventArgs e)
        {
            ArticuloServer articuloServer = new ArticuloServer();
            listaArticulo = articuloServer.listar();

            
            listaArticulo = listaArticulo.GroupBy(a => a.ID).Select(g => g.First()).ToList();

            DgvVerTodosArticulos.DataSource = listaArticulo;

            if (listaArticulo.Count > 0)
            {
                MostrarSiguienteImagen(listaArticulo[0]); 
            }
        }

        private void pictureBoxArticulo_Click(object sender, EventArgs e)
        {
            Articulo Eleccion = (Articulo)DgvVerTodosArticulos.CurrentRow.DataBoundItem;
            MostrarSiguienteImagen(Eleccion);
        }

        private void pictureBoxArticulo_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo Eleccion = (Articulo)DgvVerTodosArticulos.CurrentRow.DataBoundItem;
            MostrarSiguienteImagen(Eleccion);
        }

        private void MostrarSiguienteImagen(Articulo articulo)
        {
            try
            {
                if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                {
                    imagenActual = (imagenActual + 1) % articulo.Imagenes.Count;
                    pictureBoxArticulo.Load(articulo.Imagenes[imagenActual].ImagenURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void DgvVerTodosArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvVerTodosArticulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulo Eleccion = (Articulo)DgvVerTodosArticulos.CurrentRow.DataBoundItem;
            MostrarSiguienteImagen(Eleccion);
        }
    }
}