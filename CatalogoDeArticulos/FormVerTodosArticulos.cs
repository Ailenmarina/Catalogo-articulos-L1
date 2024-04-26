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
        public FormVerTodosArticulos()
        {
            InitializeComponent();
        }

        private void FormVerTodosArticulos_Load(object sender, EventArgs e)
        {
            ArticuloServer articuloServer = new ArticuloServer();
            DgvVerTodosArticulos.DataSource = articuloServer.listar();
        }
    }
}
