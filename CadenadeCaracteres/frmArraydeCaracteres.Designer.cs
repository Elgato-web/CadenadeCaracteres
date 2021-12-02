
namespace CadenadeCaracteres
{
    partial class frmArraydeCaracteres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinuscula = new System.Windows.Forms.TextBox();
            this.txtMayuscula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSinEspacios = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPdleft = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPadRight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa una cadena de caracteres";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(299, 41);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(133, 20);
            this.txtCadena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(34, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(299, 287);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(144, 82);
            this.lstLista.TabIndex = 4;
            this.lstLista.SelectedIndexChanged += new System.EventHandler(this.lstLista_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "La longitud de la cadena es";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(299, 94);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(133, 20);
            this.txtLongitud.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "La cadena en minuscula";
            // 
            // txtMinuscula
            // 
            this.txtMinuscula.Location = new System.Drawing.Point(299, 132);
            this.txtMinuscula.Name = "txtMinuscula";
            this.txtMinuscula.Size = new System.Drawing.Size(133, 20);
            this.txtMinuscula.TabIndex = 8;
            // 
            // txtMayuscula
            // 
            this.txtMayuscula.Location = new System.Drawing.Point(299, 189);
            this.txtMayuscula.Name = "txtMayuscula";
            this.txtMayuscula.Size = new System.Drawing.Size(133, 20);
            this.txtMayuscula.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "La cadena en mayuscula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cadena sin espacios al principio y al final";
            // 
            // txtSinEspacios
            // 
            this.txtSinEspacios.Location = new System.Drawing.Point(299, 235);
            this.txtSinEspacios.Name = "txtSinEspacios";
            this.txtSinEspacios.Size = new System.Drawing.Size(133, 20);
            this.txtSinEspacios.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ejemplo Padleft";
            // 
            // txtPdleft
            // 
            this.txtPdleft.Location = new System.Drawing.Point(582, 47);
            this.txtPdleft.Name = "txtPdleft";
            this.txtPdleft.Size = new System.Drawing.Size(100, 20);
            this.txtPdleft.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ejemplo PadRight";
            // 
            // txtPadRight
            // 
            this.txtPadRight.Location = new System.Drawing.Point(582, 90);
            this.txtPadRight.Name = "txtPadRight";
            this.txtPadRight.Size = new System.Drawing.Size(100, 20);
            this.txtPadRight.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lista de palabras";
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(582, 132);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(174, 108);
            this.lstPalabras.TabIndex = 18;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // txtU
            // 
            this.txtU.Location = new System.Drawing.Point(596, 373);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(42, 20);
            this.txtU.TabIndex = 19;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(595, 249);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(42, 20);
            this.txtA.TabIndex = 20;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(596, 310);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(42, 20);
            this.txtL.TabIndex = 21;
            this.txtL.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(596, 287);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(41, 20);
            this.txtE.TabIndex = 22;
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(596, 340);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(42, 20);
            this.txtO.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total de A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total de E";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(521, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Total de L";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(521, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total de O";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total de U";
            // 
            // frmArraydeCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPadRight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPdleft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSinEspacios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMayuscula);
            this.Controls.Add(this.txtMinuscula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Name = "frmArraydeCaracteres";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinuscula;
        private System.Windows.Forms.TextBox txtMayuscula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSinEspacios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPdleft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPadRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}