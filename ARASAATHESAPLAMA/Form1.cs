using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARASAATHESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gecenay, buayendeks, tüketim, fatura;

            fatura = Convert.ToDouble(FATURABOX.Text);
            tüketim = Convert.ToDouble(TEKZAMANENDEKSBOX.Text);
            buayendeks = Convert.ToDouble(BUAYENDEKS.Text);
            gecenay = Convert.ToDouble(GEÇENAYENDEKS.Text);

            double fark = buayendeks-gecenay;
            double kwtane = fatura/tüketim;
            double ademtutarı = fark * kwtane;
            double menderestutarı = fatura - ademtutarı;

            ADEMTUTAR.Text = Convert.ToString(ademtutarı)+" TL "+" - "+fark+" KW";
            MENDERESTUTAR.Text = Convert.ToString(menderestutarı)+" TL "+" - "+(tüketim-fark)+" KW";

            yapıcı.Text = "BY DAĞLI";
            yapıcı.Visible = true;

        }
    }
}
