﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograIV.AW.Products.AccesoBL
{
    public class Productos
    {
        public IList<Model.ComboDeProductos> ListarProductosPorColor(string elColor)
        {
            var elClienteWcf = new SI.WcfProductos.AWProductosClient();

            var elResultado = elClienteWcf.ListarIdYNombreDeProductosPorColor(elColor);
            elClienteWcf.Close();
            return elResultado;
        }

    }
}
