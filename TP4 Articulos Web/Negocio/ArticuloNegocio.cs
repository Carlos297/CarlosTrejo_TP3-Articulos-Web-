using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace TP2_CarlosTrejo
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()

        {

            List<Articulo> listado = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Nombre, Descripcion, IdMarca, IdCategoria, ImagenURL, Precio from Articulos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.Nombre = (string)lector["nombre"];
                    aux.ID = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);
                    aux.IdMarca = lector.GetInt32(3);
                    aux.IdCategoria = lector.GetInt32(4);
                    aux.ImagenURL = lector.GetString(5);
                    aux.Precio = (float)lector.GetDecimal(6);

                    
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