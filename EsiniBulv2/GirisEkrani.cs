using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBulv2
{
    public partial class GirisEkrani : Form
    {
        public int zorluk;

        //Form1.ActiveForm.Hide();
        //Form2 form2 = new Form2();
        //form2.Show();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        public void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            

            if (rtnIki.Checked)
            {
                zorluk = 2;
            }else if (rtnDort.Checked)
            {
                zorluk = 4;
            }
            else
            {
                zorluk = 6;
            }

            

            GirisEkrani.ActiveForm.Hide();
            Form1 form1 = new Form1(zorluk);
            form1.Show();



        }

        
    }
}
