using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Enabled = false;
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(textnombre.Text) && 
                !string.IsNullOrEmpty(textdocumento.Text);
            btn1.Enabled = vr;
        }


        private void textdocumento_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro que desea cancelar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //intacianos la clase
            Form2 f2 = new Form2();
            f2.labelnom.Text = this.textnombre.Text;
           
            f2.Show();
            this.Hide();
        }

        private void textdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Llene el campo con solo numeros", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void textnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255) )
            {
                MessageBox.Show("Llene el campo con solo letras", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
    }
}
