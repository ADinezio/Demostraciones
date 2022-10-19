using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsApp
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnFormLoop_Click(object sender, EventArgs e)
        {

            int total = 0;
            MessageBox.Show("Ingresar 4 numeros menores a 100");
            for (int i = 1; i <=4 ; i++)
            {
                int numero = Int32.Parse(Interaction.InputBox("Ingrese numero : ","Carga de numeros"));
                while (numero >=100)
                {
                    MessageBox.Show("El numero ingresado es mayor que 100.");
                    numero = Int32.Parse(Interaction.InputBox("Ingrese numero : ", "Carga de numeros"));
                }
                total += numero;

            }
            MessageBox.Show($"La suma de todos los numeros es : {total}");
        }
    }
}
