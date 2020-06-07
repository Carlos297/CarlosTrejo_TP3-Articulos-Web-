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
       
        public List<ItemCarritoCompra> carritoCompras { get; set; }
        public decimal total;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                carritoCompras = (List<ItemCarritoCompra>)Session[Session.SessionID + "carritoCompras"];
                

                var artQuitar = Request.QueryString["idQuitar"];

                if (artQuitar != null) {
                    

                    ItemCarritoCompra articuloQuitar = carritoCompras.Find(J => J.Id == int.Parse(artQuitar));
                    carritoCompras.Remove(articuloQuitar);
                    Session[Session.SessionID + "carritoCompras"] = carritoCompras;
                    


                }
                else if(Request.QueryString["idArt"]!=null)
                {

                    //lee el listado que tiene en sesion de todos los Articulos - Obtengo lista original (el listado completo) 
                    List<Articulo> listaOriginal = (List<Articulo>)Session[Session.SessionID + "listaArticulos"];



                    var artSeleccionado = Convert.ToInt32(Request.QueryString["idArt"]);
                    Articulo articulo = listaOriginal.Find(J => J.Id == artSeleccionado);


                    //Obtengo la lista del carrito de compras de la session
                    

                    if (carritoCompras == null)
                        carritoCompras = new List<ItemCarritoCompra>();

                    ItemCarritoCompra objcarrito = new ItemCarritoCompra();
                    objcarrito.Id = articulo.Id;
                    objcarrito.NombreProducto = articulo.Nombre;
                    objcarrito.CodigoProducto = articulo.Codigo;
                    objcarrito.Precio = articulo.Precio;
                    objcarrito.imagUrl = articulo.ImagenURL;
                    //total = articulo.Precio;
                    
                    


                   // int aux = carritoCompras.Count();


                    carritoCompras.Add(objcarrito);

                    

                    Session[Session.SessionID + "carritoCompras"] = carritoCompras;
                    
                    

                    

                }



                





            }
            catch (Exception)
            {

                Session["Error" + Session.SessionID] = "Carrito de Compras Vacio";
                Response.Redirect("Error");
            }

        }
    }
}