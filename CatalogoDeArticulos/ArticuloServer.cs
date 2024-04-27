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
                Conex.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT A.Id, I.Id AS ImagenId, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, CAST(Precio AS DECIMAL(18, 2)) AS Precio, ImagenUrl FROM ARTICULOS A INNER JOIN IMAGENES I ON A.Id = I.IdArticulo";
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
                    aux.Precio = (decimal)Lector["Precio"];

                    Imagen imagen = new Imagen();
                    imagen.ID= (int)Lector["ImagenId"];
                    imagen.ImagenURL = (string)Lector["ImagenUrl"];
                    aux.Imagenes.Add(imagen);


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
