using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIV.AW.Products.AccesoBL
{
    public class Productos
    {
        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            var elClienteWcf = new SI.WcfProductos.AWProductosClient();

            var elResultado = elClienteWcf.ListarProductosPorColor(elColor);
            elClienteWcf.Close();
            return elResultado;
        }

    }
}
