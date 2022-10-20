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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarNumero_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(Interaction.InputBox("Ingrese un numero entero","Carga numero"));
            MessageBox.Show("Usted ingreso " + numero + " y es de tipo " + numero.GetTypeCode());
            ///cambiamos el tipo de dato
            double numeroDouble = 0;
            numeroDouble = (double)numero;
            MessageBox.Show("Ahora su numero es " + numeroDouble + " y es de tipo " + numeroDouble.GetTypeCode());

        }
    }
}
