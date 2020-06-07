using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio1
{
     public class ItemCarritoCompra
    {

        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string imagUrl { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal? precioParcial { get; set; }  //cant * precio

    

    }
}
