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
    public partial class frmStruct : Form
    {
        public struct DatoCliente
        {
            
            public string NumeroCuenta;
            public string TipoCuenta;
            public string Titular;
            public string CBU;
            public double Saldo;
        }

        public struct Alumno
        {
            public string Nombre;
            public int[] notas;
        }

        public frmStruct()
        {
            InitializeComponent();
        }

        private void btnCreaStruct_Click(object sender, EventArgs e)
        {
            DatoCliente cliente1 =new DatoCliente();
            cliente1.Titular = "Agustin Di Nezio";
            cliente1.Saldo = 100;
            cliente1.TipoCuenta = "Cuenta Corriente";
            cliente1.NumeroCuenta = "4445555545454651";

            MessageBox.Show($"{cliente1.Titular} {cliente1.TipoCuenta}");
        }

        private void btnStructYVector_Click(object sender, EventArgs e)
        {
            Alumno[] alumnos= new Alumno[4];

        }

        public void CargaAlumnos (Alumno[] alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].Nombre = Interaction.InputBox("Ingrese nombre de alumno");
                alumnos[i].notas = new int[3];
                for (int j = 0; j < alumnos[i].notas.Length; j++)
                {
                    alumnos[i].notas[j] = Convert.ToInt32(Interaction.InputBox($"Ingrese nota {j+1} :"));
                }
            }
        }
    }
}

