using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.AccessControl;


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

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch ( Exception exe)
            {
                throw exe;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }  
        
        public void Eliminar(int ID)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", ID);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
