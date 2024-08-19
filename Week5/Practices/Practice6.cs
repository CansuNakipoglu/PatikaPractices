using Week5.Practices.Abstracts;
using System;
using System.Collections.Generic;

namespace Week5.Practices
{
    /// <summary>
    /// Hafta 5 Kapanış
    /// </summary>
    public class Practice6 : IPractice
    {
        public class Araba
        {
            public DateTime UretimTarihi { get; set; }
            public string SeriNumarasi { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
            public int KapiSayisi { get; set; }

            public Araba(string seriNumarasi, string marka, string model, string renk, int kapiSayisi)
            {
                UretimTarihi = DateTime.Now; 
                SeriNumarasi = seriNumarasi;
                Marka = marka;
                Model = model;
                Renk = renk;
                KapiSayisi = kapiSayisi;
            }

            public override string ToString()
            {
                return $"{Marka} {Model} - Seri Numarası: {SeriNumarasi}, Renk: {Renk}, Kapı Sayısı: {KapiSayisi}";
            }
        }

        public void ExecPractice()
        {
            List<Araba> arabalar = new List<Araba>();

            while (true)
            {
                Console.Write("Araba üretmek ister misiniz? (Evet/Hayır): ");
                string cevap = Console.ReadLine().Trim().ToLower();

                if (cevap == "evet")
                {
                    string seriNumarasi, marka, model, renk;
                    int kapiSayisi;

                    Console.Write("Seri Numarası: ");
                    seriNumarasi = Console.ReadLine();

                    Console.Write("Marka: ");
                    marka = Console.ReadLine();

                    Console.Write("Model: ");
                    model = Console.ReadLine();

                    Console.Write("Renk: ");
                    renk = Console.ReadLine();

                    while (true)
                    {
                        Console.Write("Kapı Sayısı: ");
                        string kapiSayisiStr = Console.ReadLine();

                        try
                        {
                            kapiSayisi = int.Parse(kapiSayisiStr);
                            break; 
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Geçersiz kapı sayısı! Lütfen geçerli bir sayı giriniz.");
                        }
                    }

                    Araba yeniAraba = new Araba(seriNumarasi, marka, model, renk, kapiSayisi);
                    arabalar.Add(yeniAraba);

                    Console.Write("Başka bir araba üretmek ister misiniz? (Evet/Hayır): ");
                    string devamCevabi = Console.ReadLine().Trim().ToLower();
                    if (devamCevabi != "evet")
                    {
                        break; 
                    }
                }
                else if (cevap == "hayır")
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen 'Evet' veya 'Hayır' olarak yanıt veriniz.");
                }
            }

            Console.WriteLine("\nArabalar Listesi:");
            foreach (Araba araba in arabalar)
            {
                Console.WriteLine($"{araba.SeriNumarasi} - {araba.Marka}");
            }
        }
    }
}
