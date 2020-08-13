using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311068_pso
{
    class Parcacik
    {
        // Değerlerin sınırları
        double altSinir;
        double ustSinir;

        // Değerler
        public double x1;
        public double x2;

        // Uygunluk değeri
        public double uygunlukDegeri;

        // Parçacıkların hızları
        public double v1;
        public double v2;

        // Farklı random sayı üretmek için bir kilitleme nesnesi oluşturuldu
        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();

        public Parcacik(double altSinir,double ustSinir)
        {
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;

            // Parçacıklar için random değer atanır
            x1 = RandomSayi();
            x2 = RandomSayi();
            // Six Hump fonksiyon ile uygunluk değeri bulunur.
            uygunlukDegeri = sixHumpCamel(x1, x2);
            
        }

        public double sixHumpCamel(double x1,double x2)
        {
            return (4 * Math.Pow(x1, 2)) - (2 * Math.Pow(x1, 4)) + ((1 / 3) * Math.Pow(x1, 6)) + (x1 * x2) - 4 * Math.Pow(x2, 2) + 4 * Math.Pow(x2, 4);
        }        public double RandomSayi()
        {
            // Aynı random sayı gelmemesi için bir lock oluşturulmuştur.
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
        }        public double uygunlukDegeriHesapla(double x1, double x2)
        {
            // Tekrardan uygunluk değeri hesaplamak için
           return sixHumpCamel(x1, x2);
        }
    }
}
