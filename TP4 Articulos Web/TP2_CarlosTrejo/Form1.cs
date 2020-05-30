using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using FontAwesome.Sharp;
using System.Threading;
using System.Runtime.InteropServices;

namespace TP2_CarlosTrejo
{

    

    public partial class Form1 : Form
    {


        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        //Constructor
        public Form1()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 90);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconoFormHijoActual.IconChar = currentBtn.IconChar;
                iconoFormHijoActual.IconColor = color;
                
            }
        }



        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }




        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitFormularioHijo.Text = childForm.Text;
        }














        private List<Articulo> lista;

       



        private void Form1_Load(object sender, EventArgs e)
        {

            CargarGrilla();

        }


        
        private void CargarGrilla()
        {
               ArticuloNegocio negocio = new ArticuloNegocio();
               

            try
            {
                lista = negocio.listar2();
                dgvArticulos.DataSource = lista;
               
                
                          dgvArticulos.Columns[0].Visible = false;
                          dgvArticulos.Columns[1].Visible = false;
                          //dgvArticulos.Columns[2].Visible = false;
                          //dgvArticulos.Columns[3].Visible = false;
                          dgvArticulos.Columns[4].Visible = false;
                          dgvArticulos.Columns[5].Visible = false;
                          dgvArticulos.Columns[6].Visible = false;
                          dgvArticulos.Columns[7].Visible = false;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Articulo art;
                art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ptbxArticulos.Load(art.ImagenURL);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
        
            

        

       

        

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

            List<Articulo> listaFiltrada;

            try
            {
                if (txtBusqueda.Text == "")
                {
                   listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.Descripcion.ToLower().Contains(txtBusqueda.Text.ToLower()) || k.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()));
                    //dgvArticulos.DataSource = listaFiltrada;
                }

                dgvArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

       

        private void btnAgregar2_Click(object sender, EventArgs e)
        {

            
            ActivateButton(sender, RGBColors.color1);

            // OpenChildForm(new frmAltaArticulo2 ());
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            CargarGrilla();

        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            Articulo modificar;
            modificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo alta = new frmAltaArticulo(modificar);
            alta.ShowDialog();
            CargarGrilla();

        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                int id = ((Articulo)dgvArticulos.CurrentRow.DataBoundItem).Id;
                negocio.eliminar(id);
                CargarGrilla();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDetalleart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            Articulo art;
            art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //ptbxArticulos.Load(art.ImagenURL);
            MessageBox.Show("Codigo del Articulo: " + art.Codigo + "     " + Environment.NewLine + Environment.NewLine + "Marca: " + art.Marca.Descripcion + "     " + Environment.NewLine + Environment.NewLine + "Categoria: " + art.Categoria.Descripcion + "     " + Environment.NewLine + Environment.NewLine + "Precio: $ " + art.Precio);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Form1());
            //currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {

            DisableButton();
            leftBorderBtn.Visible = false;
            iconoFormHijoActual.IconChar = IconChar.Home;
            iconoFormHijoActual.IconColor = Color.Violet;
            lblTitFormularioHijo.Text = "Inicio";
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0); 
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void iconButtonMax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;


            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconButtonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
