using System;

namespace KampIntro_13_Ocak_2021_2.Gün
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself- Kendini tekrarlama

            string  kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;    
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = false;
             
            if (sistemeGirisYapmısMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            //Console.WriteLine(ogrenciSayisi);
            //Console.WriteLine(faizOrani);

            Console.ReadLine();


             
        }
    }
}
