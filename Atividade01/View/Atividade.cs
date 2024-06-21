using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01.View
{
    public partial class Atividade : Form
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(txb_valor1.Text);
            int num2 = Convert.ToInt16(txb_valor2.Text);
            int soma = num1 + num2;
            
            lbl_Display.Text = soma.ToString();
        }
    }
}
