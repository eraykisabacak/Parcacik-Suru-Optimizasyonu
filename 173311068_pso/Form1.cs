using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _173311068_pso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double parcacikSayisi = (double)nudParcacik.Value;
            double jenerasyonSayisi = (double)nudJenerasyon.Value;
            double c1 = (double)nudC1.Value;
            double c2 = (double)nudC2.Value;
            chart1.Series["Uygunluk"].Points.Clear();
            Pso pso = new Pso(parcacikSayisi, jenerasyonSayisi, c1, c2);

            for(int i= 0; i < pso.uygunlukDegerleri.Count; i++)
            {
                // Uygunluk değerlerinin grafikte görünmesi için
                chart1.Series["Uygunluk"].Points.Add(pso.uygunlukDegerleri[i]);
            }
            // Uygunluk değerlerinin son değeri
            label4.Text = pso.uygunlukDegerleri[pso.uygunlukDegerleri.Count-1].ToString();
        }
    }
}
