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
    public partial class frmAltaArticulo2 : Form
    {
        private Articulo articulo = null;


        public frmAltaArticulo2()
        {
            InitializeComponent();
        }



        public frmAltaArticulo2(Articulo art)
        {
            InitializeComponent();
            articulo = art;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SEGURO QUE QUERES SALIR??");
            Dispose();
        }




        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
