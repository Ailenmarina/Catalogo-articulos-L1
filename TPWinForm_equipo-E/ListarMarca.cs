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
    public partial class ListarMarca : Form
    {
        private List<Marca> listaMarca;
        public ListarMarca()
        {
            InitializeComponent();
        }

        private void DgvLeerMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarMarca_Load(object sender, EventArgs e)
        {
           MarcaServer marcaServer = new MarcaServer();
            DgvLeerMarcas.DataSource = marcaServer.listar();
             
        }
    }
}
