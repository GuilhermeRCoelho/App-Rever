using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Rever.View
{
    public partial class TelaForm : Form
    {
        public TelaForm()
        {
            InitializeComponent();
        }

        //Criar uma Função

        private int resulValor(int num)
        {
            int resultado = num;

            return resultado;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbx_PrimeiroValor.Text);
            int num2 = Convert.ToInt32(tbx_SegundoValor.Text);
            int num3 = Convert.ToInt32(tbx_TerceiroValor.Text);

            lbl_Resultado.Text += "O primeiro valor é: " + (num) + "\n";
            lbl_Resultado.Text += "O segundo valor é: " + (num2) + "\n";
            lbl_Resultado.Text += "O terceiro valor é: " + (num3) + "\n";

            if (num > num2 && num > num3)
            {
                lbl_Resultado.Text += "O maior número é: " + num + "\n";
            }

            if (num2 > num && num2 > num3)
            {
                lbl_Resultado.Text += "O maior número é: " + num2 + "\n";
            }

            if (num < num3 && num2 < num3)
            {
                lbl_Resultado.Text += "O maior número é: " + num3 + "\n";
            }


            tbx_PrimeiroValor.Focus();
            tbx_PrimeiroValor.SelectAll();


        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = " ";
        }
    }
}
