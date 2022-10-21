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
    public partial class FrmCaso4 : Form
    {
        public FrmCaso4()
        {
            InitializeComponent();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            string nombre1 = txtNombre1.Text;
            string nombre2 = txtNombre2.Text;
            string nombre3 = txtNombre3.Text;
            string nombre4 = txtNombre4.Text;
            string nombre5 = txtNombre5.Text;
            int edad1 = Convert.ToInt32(txtEdad1.Text);
            int edad2 = Convert.ToInt32(txtEdad2.Text);
            int edad3 = Convert.ToInt32(txtEdad3.Text);
            int edad4 = Convert.ToInt32(txtEdad4.Text);
            int edad5 = Convert.ToInt32(txtEdad5.Text);


            string[] nombres = { nombre1, nombre2, nombre3, nombre4, nombre5 };
            int[] edad = { edad1, edad2, edad3, edad4, edad5 };

            esMayor(nombres, edad);

        }

        private static void esMayor(string[] nombres, int[] edad)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (edad[i] >= 18)
                {
                    MessageBox.Show("Es mayor: "+nombres[i]);

                }

            }
        }
    }
}
