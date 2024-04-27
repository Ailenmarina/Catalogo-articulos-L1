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
        public int IdCategoria { get; set; }
       public Marca Marca { get; set; }
       public Categoria Categoria { get; set; }
        public Imagen Imagen { get; set; }
        //public SqlMoney precio { get; set; }
    }
}
