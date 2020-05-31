using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio1;
using Negocio1;
using TP2_CarlosTrejo;



namespace ArticulosWeb
{
    public partial class About : Page
    {
        public List<Articulo> listaCarritoCompras { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //lee el listado que tiene en sesion de todos los Articulos - Obtengo lista original (el listado completo) 
                List<Articulo> listaOriginal = (List<Articulo>)Session[Session.SessionID + "listaArticulos"];

                

                var artSeleccionado = Convert.ToInt32(Request.QueryString["idArt"]);
                Articulo articulo = listaOriginal.Find(J => J.Id == artSeleccionado);


                //Obtengo la lista del carrito de compras de la session
                listaCarritoCompras = (List<Articulo>)Session[Session.SessionID + "listaCarritoCompras"];
                
                if (listaCarritoCompras == null)
                    listaCarritoCompras = new List<Articulo>();



                listaCarritoCompras.Add(articulo);
                Session[Session.SessionID + "listaCarritoCompras"] = listaCarritoCompras;





            }
            catch (Exception ex)
            {

                Session["Error" + Session.SessionID] = "Carrito de Compras Vacio";
                Response.Redirect("Error");
            }

        }
    }
}