using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173311068_pso
{
    class Pso
    {
        Parcacik[] pbest;
        Parcacik gbest;

        double parcacikSayisi;
        double jenerasyonSayisi;
        double c1;
        double c2;

        public List<double> uygunlukDegerleri = new List<double>();

        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();

        int altSinir = -5;
        int ustSinir = 5;

        Parcacik[] parcacik;

        public Pso(double parcacikSayisi, double jenerasyonSayisi, double c1, double c2)
        {
            this.parcacikSayisi = parcacikSayisi;
            this.jenerasyonSayisi = jenerasyonSayisi;
            this.c1 = c1;
            this.c2 = c2;

            parcacik = new Parcacik[(int)parcacikSayisi];

            // Parçacık sayısı kadar parçacık oluşturulur. 
            for (int i = 0; i < parcacikSayisi; i++)
            {
                parcacik[i] = new Parcacik(altSinir,ustSinir);
            }

            pbest = new Parcacik[(int)parcacikSayisi];

            // Oluşturulan parçacıklar pbestler olarak diziye eklenir
            for(int i = 0; i < parcacikSayisi; i++)
            {
                pbest[i] = parcacik[i];
            }

            // Pbestin ilk değeri Gbest olarak verilir.
            gbest = parcacik[0];
            uygunlukDegerleri.Add(gbest.uygunlukDegeri);

            for (int i = 0; i < jenerasyonSayisi; i++)
            {
                // Pbest
                for(int j = 0; j < parcacikSayisi; j++)
                {
                    // 0'a en yakınını almak için mutlak değerini aldım ve pbestlerle ile karşılaştırdım
                    if (Math.Abs(parcacik[j].uygunlukDegeri) < Math.Abs(pbest[j].uygunlukDegeri))
                    {
                        pbest[j].x1 = parcacik[j].x1;
                        pbest[j].x2 = parcacik[j].x2;
                        pbest[j].v1 = parcacik[j].v1;
                        pbest[j].v2 = parcacik[j].v2;
                    }
                }

                // Gbest
                for (int j = 0; j < pbest.Length; j++)
                {
                    // 0'a en yakınını almak için mutlak değerini aldım ve gbest ile pbestleri karşılaştırdım
                    if (Math.Abs(gbest.uygunlukDegeri) > Math.Abs(pbest[j].uygunlukDegeri))
                    {
                        gbest.x1 = pbest[j].x1;
                        gbest.x2 = pbest[j].x2;
                        gbest.v1 = pbest[j].v1;
                        gbest.v2 = pbest[j].v2;
                        gbest.uygunlukDegeri = pbest[j].uygunlukDegeri;
                    }
                }
                uygunlukDegerleri.Add(gbest.uygunlukDegeri);


                // Hız hesaplaması için random sayılar üretildi                
                double randomSayi1 = RandomSayi(0, 1);
                double randomSayi2 = RandomSayi(0, 1);

                // Hızların Hesaplanması
                for (int j = 0; j < parcacikSayisi; j++)
                {
                    // v(i) (k+1) = v(i) (k) + c1 * rand(0,1) * (pbest - x1) + c2 * rand(0,1) * (gbest - x1)

                    parcacik[j].v1 = parcacik[j].v1 + 
                                    c1 * randomSayi1 * (pbest[j].x1 - parcacik[j].x1)
                                    + c2 * randomSayi2 * (gbest.x1 - parcacik[j].x1);

                    // v(i) (k+1) = v(i) (k) + c1 * rand(0,1) * (pbest - x2) + c2 * rand(0,1) * (gbest - x2)

                    parcacik[j].v2 = parcacik[j].v2 + 
                                    c1 * randomSayi1 * (pbest[j].x2 - parcacik[j].x2)
                                    + c2 * randomSayi2 * (gbest.x2 - parcacik[j].x2);

                    // Burada parçacıkların konumları güncellenir.
                    parcacik[j].x1 += parcacik[j].v1;
                    parcacik[j].x2 += parcacik[j].v2;

                    parcacik[j].uygunlukDegeri = parcacik[j].uygunlukDegeriHesapla(parcacik[j].x1, parcacik[j].x2);
                }

            }
        }

        public double RandomSayi()
        {
            // Aynı random sayı gelmemesi için bir lock oluşturulmuştur.
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (ustSinir - altSinir) + altSinir;
            }
        }

        public double RandomSayi(double xUst,double yAlt)
        {
            // Aynı random sayı gelmemesi için bir lock oluşturulmuştur.
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (xUst - yAlt) + yAlt;
            }
        }
    }
}
