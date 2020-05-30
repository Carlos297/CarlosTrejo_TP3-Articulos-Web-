using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio1;
using Negocio;
using Negocio1;

namespace TP2_CarlosTrejo
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        
        public frmAltaArticulo()
        {
            InitializeComponent();
        }


        public frmAltaArticulo(Articulo art)
        {
            InitializeComponent();
            articulo = art;
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SEGURO QUE QUERES SALIR??");
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                   articulo = new Articulo();


                articulo.Codigo = txtCodArt.Text.Trim();
                articulo.Nombre = txtNombre.Text.Trim();
                articulo.Descripcion = txtDescripcion.Text.Trim();
                articulo.ImagenURL = txtURLImagen.Text.Trim();
                articulo.Marca = (Marca)cboMarcas.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);


                if (articulo.Id == 0)
                    negocio.agregar(articulo);
                
                else
                     negocio.modificar(articulo);
               
                Dispose();



            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

      
        
        
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {

            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();
            
            try
            {
               


                cboCategoria.DataSource = categoria.listar();
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "IdCategoria";
                
                cboMarcas.DataSource = marca.listar();
                cboMarcas.DisplayMember = "Descripcion";
                cboMarcas.ValueMember = "IdMarca";
               


                if(articulo != null)
                {
                    Text = "Modificar";
                    txtCodArt.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtURLImagen.Text = articulo.ImagenURL;
                    txtPrecio.Text = Convert.ToString(articulo.Precio);

                    cboCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cboMarcas.SelectedValue = articulo.Marca.IdMarca;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
