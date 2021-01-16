using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Düştü");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Arttı");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Giriş Yapıldı");
                Console.WriteLine(ogrenciSayisi);
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yapınız");
            }


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
