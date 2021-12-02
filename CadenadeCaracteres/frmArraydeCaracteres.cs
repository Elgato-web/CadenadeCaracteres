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
    public partial class frmArraydeCaracteres : Form
    {
        public frmArraydeCaracteres()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int A = 0, E = 0, O = 0, L = 0, U = 0;
            string mytring = this.lstPalabras.Text;
            string myString = this.txtCadena.Text;
            char[] myChars = myString.ToCharArray();
           foreach(char caracter in myChars)
            {
                
                Console.WriteLine("{0}", caracter);
                this.lstLista.Items.Add(caracter.ToString());
                this.txtLongitud.Text = myChars.Length.ToString();
                this.txtMinuscula.Text = myString.ToLower();
                this.txtMayuscula.Text = myString.ToLower();
                this.txtSinEspacios.Text = myString.Trim();
                this.txtPdleft.Text = myString.PadLeft(30);
                this.txtPadRight.Text = myString.PadRight(30,'+');
                string[] matriz = myString.Split(' ');
                this.lstPalabras.Items.Clear();
               

                foreach (string s1 in  matriz)
                {
                    if ('a'==caracter || 'A' == caracter)
                    {
                        ++A;
                        this.txtA.Text = A.ToString();
                            
                    }
                    else if ('e'==caracter || 'E'==caracter)
                    {
                        ++E;
                            this.txtE.Text = A.ToString();
                    }
                    else if ('o' == caracter || 'O' == caracter)
                    {
                        ++O;
                        this.txtO.Text = A.ToString();
                    }
                    else if ('l' == caracter || 'L' == caracter)
                    {
                        ++L;
                        this.txtL.Text = L.ToString();
                    }
                    else if ('u' == caracter || 'U' == caracter)
                    {
                        ++U;
                        this.txtU.Text = U.ToString();
                    }
                    Console.WriteLine($"{s1}");

                }

            }
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
