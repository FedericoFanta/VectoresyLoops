using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VectoresyLoops
{
    public partial class Form1 : Form
    {
        string[] nombres;
        decimal[] nota1;
        decimal[] nota2;
        decimal[] nota3;
        decimal[] nota4;
        decimal[] promedios;
        decimal[] mayorNota;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPideDatos_Click(object sender, EventArgs e)
        {
            nombres = new string[4];
            nota1 = new decimal[3];
            nota2 = new decimal[3];
            nota3 = new decimal[3];
            nota4 = new decimal[3];
            promedios = new decimal[3];

            PideNombres(nombres);
            PideNotas(nota1);
            PideNotas(nota2);
            PideNotas(nota3);
            PideNotas(nota4);
        }

        private void PideNombres(string[] nombres)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i]= Interaction.InputBox("Ingrese nombre: ");
            }
        }

        private void PideNotas(decimal[] notas)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i]= Convert.ToDecimal(Interaction.InputBox("Ingrese notas: "));
            }
        }

        private decimal CalcularPromedio(decimal[] notas)
        {
            decimal suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma+=notas[i];
            }
            return suma/3;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            decimal promedio1 = CalcularPromedio(nota1);
            decimal promedio2 = CalcularPromedio(nota2);
            decimal promedio3 = CalcularPromedio(nota3);
            decimal promedio4 = CalcularPromedio(nota4);
            decimal mayorNota1 = BuscaMayorNota(nota1);
            decimal mayorNota2 = BuscaMayorNota(nota2);
            decimal mayorNota3 = BuscaMayorNota(nota3);
            decimal mayorNota4 = BuscaMayorNota(nota4);

            promedios = new decimal[] { promedio1, promedio2, promedio3, promedio4 };
            mayorNota = new decimal[] { mayorNota1, mayorNota2, mayorNota3, mayorNota4 };

            MuestraPromedios(nombres, promedios, mayorNota);



        }
        private void MuestraPromedios(string[] nombres, decimal[] promedios, decimal[] notas)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                MessageBox.Show($"Promedio de {nombres[i]} : {promedios[i]}\nMayor nota: {mayorNota[i]}");
                if (promedios[i]<4)
                {
                    MessageBox.Show("Tienes que ir a recuperatorio");
                }
                else if (promedios[i]>4 && promedios[i]<7)
                {
                    MessageBox.Show("Bien");
                }
                else MessageBox.Show("Muy bien");
            }
        }

        private decimal BuscaMayorNota(decimal[] notas)
        {
            decimal mayor = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor=notas[i];
                }
            }
            return mayor;
        }

    }
}
