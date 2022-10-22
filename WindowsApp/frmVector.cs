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
using Microsoft.VisualBasic;
namespace WindowsApp
{
    public partial class frmVector : Form
    {
        //declaramos vector
        int[] numeros;
        public frmVector()
        {
            InitializeComponent();
        }
        private void btnCrearVector_Click(object sender, EventArgs e)
        {
            

            numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Interaction.InputBox("Ingrese numero : "));
            }

            MessageBox.Show(numeros.Count().ToString());

        }

        private void btnMostrarVector_Click(object sender, EventArgs e)
        {
            foreach (int item in numeros)
            {
               lstVector.Items.Add(item);
            }
        }
    }
}
