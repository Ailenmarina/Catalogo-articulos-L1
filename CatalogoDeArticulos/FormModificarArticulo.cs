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
    public partial class FormModificarArticulo : Form
    {
        public FormModificarArticulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void FormModificarArticulo_Load(object sender, EventArgs e)
        {

            //REVISAR 
            cboOpcionesArticulo.Items.Add("Codigo");
            cboOpcionesArticulo.Items.Add("Nombre");
            cboOpcionesArticulo.Items.Add("Descripcion");
            cboOpcionesArticulo.Items.Add("Marca");
            cboOpcionesArticulo.Items.Add("Categoria");
            cboOpcionesArticulo.Items.Add("Imagen");
            cboOpcionesArticulo.Items.Add("Precio");
        }

        private void FormModificarArticulo_Load_1(object sender, EventArgs e)
        {
            cboOpcionesArticulo.Items.Add("Opcion 1");
            cboOpcionesArticulo.Items.Add("Opcion 2");
            cboOpcionesArticulo.Items.Add("Opcion 3");
        }
    }
}
