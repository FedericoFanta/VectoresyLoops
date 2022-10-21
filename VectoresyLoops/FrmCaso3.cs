using Microsoft.VisualBasic;
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
    public partial class FrmCaso3 : Form
    {
        public FrmCaso3()
        {
            InitializeComponent();
        }

        private void btnSueldos_Click(object sender, EventArgs e)
        {
            string op1 = txtOp1.Text;
            string op2 = txtOp2.Text;
            string op3 = txtOp3.Text;
            string op4 = txtOp4.Text;

            string[] operarios = { op1, op2, op3, op4 };
            int[] sueldos = new int[4];

            IngreseSueldo(operarios, sueldos);
            MostrandoOperarioYsueldo(operarios, sueldos);
        }

        private static void MostrandoOperarioYsueldo(string[] operarios, int[] sueldos)
        {
            for (int i = 0; i < operarios.Length; i++)
            {
                MessageBox.Show("Operario "+operarios[i] + "  sueldo trimestral: " +sueldos[i]);
            }
        }

        private static void IngreseSueldo(string[] operarios, int[] sueldos)
        {
            for (int i = 0; i < operarios.Length; i++)
            {
                sueldos[i]=Convert.ToInt32(Interaction.InputBox("Ingrese la el sueldo trimestral de "+operarios[i]));
            }
        }
    }
}
