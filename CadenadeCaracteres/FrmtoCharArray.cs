using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadenadeCaracteres
{
    public partial class FrmtoCharArray : Form
    {
        public FrmtoCharArray()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string myString = this.txtCadena.Text;
            char myChar = myString[1];
            Console.WriteLine("El caracter es : {0}",myChar);
            this.txtRes.Text = myChar.ToString();

        }
    }
}
