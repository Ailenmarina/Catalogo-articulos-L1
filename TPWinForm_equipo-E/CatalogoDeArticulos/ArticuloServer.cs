using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Xml.Linq;
using System.Data.SqlTypes;


namespace CatalogoDeArticulos
{
    internal class ArticuloServer
    {
        public List<Articulo> listar()
        {

            List<Articulo> Lista = new List<Articulo>();
            SqlConnection Conex = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                Conex.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select A.Id, I.Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, IdArticulo, ImagenUrl From ARTICULOS A, IMAGENES I Where A.Id= I.Id";
                Comando.Connection = Conex;
                

                Conex.Open();
                Lector =Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    aux.ID = (int)Lector["Id"];
                    aux.Codigo = (string)Lector["Codigo"];
                    aux.Nombre = (string)Lector["Nombre"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    aux.IdMarca = (int)Lector["IdMarca"];
                    aux.IdCategoria = (int)Lector["IdCategoria"];
                    //Arreglar
                    //aux.precio = (SqlMoney)Lector["Precio"]; 
                    aux.ImagenUrl = new Imagen();
                    aux.ImagenUrl.ImagenURL=(string)Lector["ImagenUrl"];
                 

                    Lista.Add(aux);
                }

                Conex.Close();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
    }
}
