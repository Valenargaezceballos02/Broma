using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       private void Form2_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnno.Width);
            int y = r.Next(0, this.Height - btnno.Height);
            btnno.Location = new Point(x, y);
        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnno.Location == btnsi.Location || btnno.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¡Traspaso echo exitosamente :)!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information); 
               
            Application.Exit();
          
        }
    }
}
 