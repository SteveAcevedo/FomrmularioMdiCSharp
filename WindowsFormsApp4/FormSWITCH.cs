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
    public partial class FormSWITCH : Form
    {
        public FormSWITCH()
        {
            InitializeComponent();
           
        }

        private void mensaje(string mes)
        {
            MessageBox.Show(mes, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)

        {

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril",
                               "Mayo", "Junio", "Julio", "Agosto", 
                               "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            
            switch (textBox1.Text)
            {
                case "1":
                    mensaje(meses[0]);

                    break;
                case "2":
                    mensaje(meses[1]);
                    break;
                case "3":
                    mensaje(meses[2]);
                    break;
                case "4":
                    mensaje(meses[3]);
                    break;
                case "5":
                    mensaje(meses[4]);
                    break;
                case "6":
                    mensaje(meses[5]);
                    break;
                case "7":
                    mensaje(meses[6]);
                    break;
                case "8":
                    mensaje(meses[7]);
                    break;
                case "9":
                    mensaje(meses[8]);
                    break;
                case "10":
                    mensaje(meses[9]);
                    break;
                case "11":
                    mensaje(meses[10]);
                    break;
                case "12":
                    mensaje(meses[11]);
                    break;
                default:
                    MessageBox.Show("Error Digite un numero entre 1 y 12","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSWITCH_Load(object sender, EventArgs e)
        {
   
        }
    }

  
}
