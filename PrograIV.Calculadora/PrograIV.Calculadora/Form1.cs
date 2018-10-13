using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograIV.Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //var laLogica = new LogicaCalculadora();
            LogicaCalculadora laLogica = new LogicaCalculadora();
            tbResultado.Text = laLogica.RealizarOperacion(tbOperandoUno.Text, tbOperandoDos.Text, cbOperadores.Text);
            //tbResultado.Text = laLogica.RealizarOperacion(Convert.ToDouble(tbOperandoUno.Text), Convert.ToDouble(tbOperandoDos.Text), cbOperadores.Text).ToString();
            /*
        switch (cbOperadores.Text)
        {
            case "Suma":
                {
                    tbResultado.Text = (Convert.ToDouble(tbOperandoUno.Text) + Convert.ToDouble(tbOperandoDos.Text)).ToString();
                    break;
                }
            case "Resta":
                {
                    tbResultado.Text = (Convert.ToDouble(tbOperandoUno.Text) - Convert.ToDouble(tbOperandoDos.Text)).ToString();
                    break;
                }
            case "Multiplicación":
                {
                    tbResultado.Text = (Convert.ToDouble(tbOperandoUno.Text) * Convert.ToDouble(tbOperandoDos.Text)).ToString();
                    break;
                }
            case "División":
                {
                    tbResultado.Text = (Convert.ToDouble(tbOperandoUno.Text) / Convert.ToDouble(tbOperandoDos.Text)).ToString();
                    break;
                }

        }
        */
        }
    }
}
