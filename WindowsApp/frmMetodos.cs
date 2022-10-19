using Microsoft.Win32;
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
    public partial class frmMetodos : Form
    {
        public frmMetodos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir("Agustin");
            int resultado = Suma(10, 20);
            MessageBox.Show(resultado.ToString());
        }
        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            Imprimir("Agustin", "Di Nezio");
        }

        //Mis Funciones void
        //Metodo creado con inteligencia artificial.
        private static void Imprimir()
        {
            MessageBox.Show("Bienvenido");
        }
  
        private static void Imprimir(string nombre)
        {
            MessageBox.Show($"Bienvenido {nombre}");
        }

        private static void Imprimir(string nombre, string apellido)
        {
            MessageBox.Show($"Bienvenido {nombre} {apellido}");
        }
       
        //Mis funciones con retorno
        private int Suma(int num1,int num2) =>  num1 + num2;

        private int Suma(int num1, int num2, int num3) => num1 + num2 + num3;

    }
}
