using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresyLoops
{
    public partial class FrmCaso2 : Form
    {
        public FrmCaso2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            decimal precio1 = Convert.ToDecimal(txtPrecio1.Text);
            decimal precio2 = Convert.ToDecimal(txtPrecio2.Text);
            decimal precio3 = Convert.ToDecimal(txtPrecio3.Text);
            decimal precio4 = Convert.ToDecimal(txtPrecio4.Text);
            decimal precio5 = Convert.ToDecimal(txtPrecio5.Text);
            decimal precio6 = Convert.ToDecimal(txtPrecio6.Text);
            decimal precio7 = Convert.ToDecimal(txtPrecio7.Text);
            decimal precio8 = Convert.ToDecimal(txtPrecio8.Text);
            decimal[] suma = new decimal[8] { precio1, precio2, precio3, precio4, precio5, precio6, precio7, precio8 };

            sumaTotal(suma);

        }

        private static void sumaTotal(decimal[] suma)
        {
            decimal sumatotal = 0;
            for (int i = 0; i < 8; i++)
            {
                sumatotal+=suma[i];
            }

            MessageBox.Show("La suma total de la lista de compras es $ "+sumatotal);
        }
    }
}
