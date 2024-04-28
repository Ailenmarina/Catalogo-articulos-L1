using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeArticulos
{
    internal class Articulo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public int IdCategoria { get; set; }
     
<<<<<<< HEAD
        public List<Imagen> Imagenes { get; set; }
=======
       public List<Imagen> Imagenes { get; set; }
>>>>>>> 9a0a28ec4543eb009cccbea9b8f76f8293d8e458
        public decimal Precio { get; set; }

        public Articulo()
        {
            Imagenes = new List<Imagen>();
        }
    }
}
