using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormIF : Form
    {
        public FormIF()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int numero = int.Parse(textBox1.Text);

                if(numero == 0 )
                {
                    MessageBox.Show("El numero es Cero" ,"", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (numero <0)
                {
                    MessageBox.Show("El numero es Negativo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (numero>0)
                {
                    MessageBox.Show("El numero es Positivo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBox1.Text = "";

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
