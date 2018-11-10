using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos.Enumerables
{
    public partial class frmEstructuras : Form
    {
        IList<string> miListaHileras = new List<string>() { "hello",
        "world", "to", "everybody"};
        int contador = 0;
        HashSet<string> miHashSet = new HashSet <string>();
        LinkedList<string> miListaEnlazada = new LinkedList<string>();
        IDictionary<int, string> miDiccionario = new Dictionary<int, string>();
        int tamanoVector = 5;
        string[] miVectorString = new string[5];
        public frmEstructuras()
        {
            InitializeComponent();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miListaHileras.Add(tbAgregar.Text);
            miDiccionario.Add(contador, tbAgregar.Text);
            miHashSet.Add(tbAgregar.Text);
            if (cbAgregarAlFinal.Checked)
                miListaEnlazada.AddLast(tbAgregar.Text);
            else
                miListaEnlazada.AddFirst(tbAgregar.Text);
            try
            {
                miVectorString[contador] = tbAgregar.Text;
            }
            catch (IndexOutOfRangeException)
            {

                // TODO: mensaje de error;
            }
            contador++;
            tbAgregar.Text = string.Empty;

        }

        private void btnRefrescarCB_Click(object sender, EventArgs e)
        {
            cbSalida.Items.Clear();
            foreach (var item in miListaHileras)
            {
                cbSalida.Items.Add(item);
            }
        }

        private void btnRefrescarLL_Click(object sender, EventArgs e)
        {
            cbSalida.Items.Clear();
            foreach (var item in miListaEnlazada)
            {
                cbSalida.Items.Add(item);
            }
        }
    }
}
