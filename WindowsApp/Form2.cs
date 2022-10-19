using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);
            double[] notas = new double[4] { nota1, nota2, nota3, nota4 };
            double mayor = 0;
            double promedio = 0;
            double suma = 0;
            for(int i = 0; i < notas.Length; i++)
            { 
                if (notas[i]>mayor) mayor = notas[i];
                suma+=notas[i];
            }
            promedio = suma / 4;

            if (promedio >= 9) MessageBox.Show($"Mayor nota: {mayor}\nPromedio: {promedio}\nDevolucion: Exelente!");
            else if (promedio < 9 && promedio >= 7) MessageBox.Show($"Mayor nota: {mayor}\nPromedio: {promedio}\nDevolucion: Muy Bien!");
            else if (promedio < 7 && promedio >= 4) MessageBox.Show($"Mayor nota: {mayor}\nPromedio: {promedio}\nDevolucion: Regular.");
            else MessageBox.Show($"Mayor nota: {mayor}\nPromedio: {promedio}\nDevolucion: En proceso de aprendizaje.");
  
        }
    }
}
