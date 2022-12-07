using System;
using System.ComponentModel;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayi = new List<int>();
            sayi.Add(1);
            sayi.Add(2);
            sayi.Add(3);
            sayi.Add(7);

            foreach (int i in sayi)
                Console.Write(i+" ");
            Console.WriteLine("\n");

            sayi.Remove(1);
            sayi.RemoveAt(2);
            sayi.ForEach(i => Console.Write(i+" "));

            Console.WriteLine("\n");

            sayi.Clear();
            sayi.ForEach(i => Console.Write(i+" "));

            Console.WriteLine("\n");

            List<string> isimler = new List<string>();
            isimler.Add("Fatih");
            isimler.Add("Sinem");
            isimler.Add("Zeynep");
            isimler.Add("Mithat");

            isimler.ForEach(i => Console.Write(i + " "));

            Console.WriteLine("\n");

            List<Kisi> kisiler = new List<Kisi>();
            
            Kisi kisi1=new Kisi();
            kisi1.Isim = "Fatih";
            kisi1.Soyisim = "Turgutlugil";
            kisi1.Yas = 21;
            kisiler.Add(kisi1);

            Kisi kisi2 = new Kisi()
            {
                Isim = "Mert",
                Soyisim = "Çelebi",
                Yas = 20
            };
            kisiler.Add(kisi2);

            kisiler.Add(new Kisi()
            {
                Isim="Çağlayan",
                Soyisim="Tekin",
                Yas=21
            });

            foreach(Kisi i in kisiler)
            {
                Console.WriteLine("İsim: " + i.Isim);
                Console.WriteLine("Soyisim: " + i.Soyisim);
                Console.WriteLine("Yaş: " + i.Yas);
                Console.WriteLine("\n");
            }
        }
    }

    public class Kisi
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}