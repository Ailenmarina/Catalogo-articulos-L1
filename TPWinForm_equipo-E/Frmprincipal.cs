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
    public partial class Frmprincipal : System.Windows.Forms.Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo Alta = new FormAgregarArticulo();
            Alta.ShowDialog();
        }

        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarArticulo ventana = new FormBuscarArticulo();
            ventana.Show();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarArticulo ventana = new FormModificarArticulo();
            ventana.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verTodosLosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerTodosArticulos ventana= new FormVerTodosArticulos();
            ventana.Show();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarArticulo ventana=new EliminarArticulo(); ;
            ventana.Show();
        }

        private void ListarBtn_Click(object sender, EventArgs e)
        {
            ListarMarca ventana=new ListarMarca();
            ventana.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMarca ventana=new AgregarMarca();
            ventana.Show();
        }
    }
}
