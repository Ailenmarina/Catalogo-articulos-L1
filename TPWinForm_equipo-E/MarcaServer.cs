using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeArticulos
{
    internal class MarcaServer
    {
        public List<Marca> listar()

        {
            List<Marca> Lista = new List<Marca>();
            SqlConnection Conex = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                Conex.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select id, Descripcion from MARCAS";
                Comando.Connection = Conex;


                Conex.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.ID = (int)Lector["Id"];
                    aux.Descripcion = (string)Lector["Descripcion"];
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


        public List<Marca> Mostrar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            List<Marca> Lista = new List<Marca>();
            SqlConnection Conex = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;
            try
            {
                Conex.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "Select id, Descripcion from MARCAS";
                Comando.Connection = Conex;


                Conex.Open();
                Lector = Comando.ExecuteReader();
               
                while (Lector.Read())
                {
                   
                    Marca aux = new Marca();
                    aux.ID = (int)Lector["id"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    listaMarcas.Add(aux);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las descripciones de las marcas: {ex.Message}");
            }

            return listaMarcas;
        }
    }
}
