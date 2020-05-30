using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio1;
using Negocio;
using System.Net.Http;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()

        {

            List<Categoria> listado = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from CATEGORIAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    //aux.Nombre = (string)lector["nombre"];
                    //aux.ID = lector.GetInt32(0);
                    aux.IdCategoria = lector.GetInt32(0);
                    aux.Descripcion = lector.GetString(1);

                    listado.Add(aux);



                }

                
                
                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
    }
}
