﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograIV.AW.Products.BL.Repositorio
{
    internal class Productos
    {
        private Model.AdventureWorks2016Entities _contexto = new Model.AdventureWorks2016Entities();

        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            var elResultado = _contexto.Product.Where(p => p.Color.Contains(elColor)).ToList();
            return elResultado;
        }

        public IList<Model.ComboDeProductos> ListarIdYNombreDeProductosPorColor(string elColor)
        {
            var elResultado = _contexto.Product.Where(p => p.Color.Contains(elColor)).ToList();
            return elResultado;
        }


    }
}