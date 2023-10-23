using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fordongotoplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla = 0;
            int sayi1 = Convert.ToInt32(txtSayi1.Text); 
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            for(int i=sayi1; i<=sayi2; i++)
            {
                topla+= i;
            }
            lblSonuc.Text = "Sonuç: "+ topla.ToString();
        }
    }
}
