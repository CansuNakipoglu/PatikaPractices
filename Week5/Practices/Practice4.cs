using Week5.Practices.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Week5.Practices
{
    /// <summary>
    /// IMDB Listesi Oluşturma
    /// </summary>
    public class Film
    {
        public string Isim { get; set; }
        public double ImdbPuani { get; set; }

        public Film(string isim, double imdbPuani)
        {
            Isim = isim;
            ImdbPuani = imdbPuani;
        }

        public override string ToString()
        {
            return $"{Isim} - IMDb Puanı: {ImdbPuani}";
        }
    }
    public class Practice4 : IPractice
    {
        public void ExecPractice()
        {
            List<Film> filmler = new List<Film>();

            bool devamEt = true;

            while (devamEt)
            {
                Console.Write("Film İsmi: ");
                string isim = Console.ReadLine();

                Console.Write("IMDb Puanı: ");
                if (!double.TryParse(Console.ReadLine(), out double imdbPuani))
                {
                    Console.WriteLine("Geçersiz IMDb puanı. Lütfen bir sayı girin.");
                    continue;
                }
                
                Film yeniFilm = new Film(isim, imdbPuani);
                filmler.Add(yeniFilm);
                
                Console.Write("Başka bir film eklemek ister misiniz? (Evet/Hayır): ");
                string cevap = Console.ReadLine().Trim().ToLower();
                devamEt = (cevap == "evet" || cevap == "e");
            }
            
            Console.WriteLine("\nBütün Filmler:");
            foreach (Film film in filmler)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine("\nIMDb Puanı 4 ile 9 arasında olan Filmler:");
            var filteredByRating = filmler.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
            foreach (Film film in filteredByRating)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine("\nİsmi 'A' ile başlayan Filmler ve IMDb Puanları:");
            var filteredByName = filmler.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            foreach (Film film in filteredByName)
            {
                Console.WriteLine(film);
            }
        }
    }
}
