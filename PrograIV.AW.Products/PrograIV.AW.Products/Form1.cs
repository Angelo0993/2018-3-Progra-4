using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograIV.AW.Products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var elAccesoAlBussinessLogic = new AccesoBL.Productos();
            var listaDeProductos = elAccesoAlBussinessLogic.ListarProductosPorColor(cbColores.Text);
            CargarComboBoxConListaDeProductos(listaDeProductos);
        }

        private void CargarComboBoxConListaDeProductos(IList<Model.ComboDeProductos> laLista)
        {
            cbProductos.Items.Clear();
            cbProductos.ValueMember = "idProducto";
            cbProductos.DisplayMember = "NombreProducto";
            foreach (var item in laLista)
            {
                cbProductos.Items.Add(item.NombreProducto);
            }
            //           cbProductos.DataSource = laLista;
        }

    }
}
