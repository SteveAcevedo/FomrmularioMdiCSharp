using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormFOR : Form
    {
        public FormFOR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int cantidad = int.Parse(textBox1.Text);
                int numeroBase = 1;

                int factorial = 1;
                for (int i = 0; i < cantidad; i++)
                {
                    factorial = factorial * numeroBase;
                    numeroBase = numeroBase + 1;
                }

                MessageBox.Show($"el numero es ==>   {factorial}", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
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
