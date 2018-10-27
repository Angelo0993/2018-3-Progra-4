using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograIV.Interfaces
{
    public partial class frmInvocarWcf : Form
    {
        public frmInvocarWcf()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var elCalculo = new PrograIV.Interfaces.LogicaNegocio.EjemploCalculos();
            var elPrimerCalculo = (PrograIV.Interfaces.LogicaNegocio.IEjemploCalculos)elCalculo;
            tbSalida1.Text = elPrimerCalculo.Show(tbMensaje1.Text);
            var elSegundoCalculo = (PrograIV.Interfaces.LogicaNegocio.IEjemploCalculosDos)elCalculo;
            tbSalida2.Text = elSegundoCalculo.Show(tbMensaje2.Text);
        }
    }
}
