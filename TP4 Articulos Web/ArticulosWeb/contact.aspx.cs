using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio1;
using Negocio1;
using Negocio;
using TP2_CarlosTrejo;


namespace ArticulosWeb
{
    public partial class Contact : Page
    {
        public Articulo articulo { get; set; }

        public void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            

            List<Articulo> listaArticulo;

            //List<ItemCarritoCompra> listaCarrito;

            try
            {
                listaArticulo = negocio.listar2();
                //
                // int numeroPokemon = Convert.ToInt32(Session["NumeroPokemon" + Session.SessionID]);
                
                var artSeleccionado = Convert.ToInt32(Request.QueryString["idArt"]);

                articulo = listaArticulo.Find(J => J.Id == artSeleccionado);



            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex;
                Response.Redirect("Error.aspx");
            }



        }
    }
}