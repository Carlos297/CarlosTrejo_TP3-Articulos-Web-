using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio1;
using Negocio;
using Dominio1;
using TP2_CarlosTrejo;
using System.Security.Cryptography.X509Certificates;

namespace ArticulosWeb
{
    public partial class _Default : Page
    {

        public List<Articulo> listaArticulos { get; set; }

        

        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar2();
                //dgvar = listaArticulos;
                //dgvPokemons.DataBind();

                Session[Session.SessionID + "listaArticulos"] = listaArticulos;

                //cboti.DataSource = listaPokemons;
                //cboPokemons.DataBind();

                
                //cboPokemons.Items.Add("Rojo");
                //cboPokemons.Items.Add("Azul");
                //cboPokemons.Items.Add("Verde");

                if (!IsPostBack)
                { //pregunto si es la primera carga de la page
                    //txtNumeroPokemon.Text = "150";
                    //cbotipoArt.DataSource = listaArticulos;
                    //cbotipoArt.DataBind();

                    //esto es lo que necesitamos para el repeater.
                    //repetidor.DataSource = listaPokemons;
                    //repetidor.DataBind();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }


        protected void txtFiltro_TextChanged(object source, RepeaterCommandEventArgs e)
        {

             List<Articulo> listaFiltrada;
           

           

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                if (txtFiltro.Text == "")
                {
                    listaFiltrada = listaArticulos;
                }
                else
                {
                    listaFiltrada = listaArticulos.FindAll(k => k.Descripcion.ToLower().Contains(txtFiltro.Text.ToLower()) || k.Nombre.ToLower().Contains(txtFiltro.Text.ToLower()));
                    
                }

                listaFiltrada = negocio.listar2();


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



      

        
    }
}