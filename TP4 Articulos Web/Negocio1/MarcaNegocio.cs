using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio1;
using Negocio;
using System.Data.SqlClient;

namespace Negocio1
{
    public class MarcaNegocio
    {


        public List<Marca> listar()

        {

            List<Marca> listado = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from MARCAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Marca aux = new Marca();
                    //aux.Nombre = (string)lector["nombre"];
                    //aux.ID = lector.GetInt32(0);
                    aux.IdMarca = lector.GetInt32(0);
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
