using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeArticulos
{
    internal class CategoriaServer
    {
        public List<Categoria> listar()

        {
            List<Categoria> Lista = new List<Categoria>();
            SqlConnection Conex = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                Conex.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select id, Descripcion from CATEGORIAS";
                Comando.Connection = Conex;


                Conex.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.ID = (int)Lector["Id"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                }

                Conex.Close();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<Categoria> Mostrar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            List<Categoria> Lista = new List<Categoria>();
            SqlConnection Conex = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;
            try
            {
                Conex.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select id, Descripcion from CATEGORIAS";
                Comando.Connection = Conex;


                Conex.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {

                    Categoria aux = new Categoria();
                    aux.ID = (int)Lector["id"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    listaCategorias.Add(aux);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las descripciones de las marcas: {ex.Message}");
            }

            return listaCategorias;
        }
    }
}