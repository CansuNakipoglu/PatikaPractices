using Week7.Practices.Abstracts;

namespace Week7.Practices;

public class Practice3 : IPractice
{
    public void ExecPractice()
    {
        var tvSeries = GenerateTvSeries();
        var comedySeries = tvSeries.Where(series => series.Type.Contains("Komedi")).ToList();
        var sortedComedySeries = comedySeries.OrderBy(series => series.Name).ThenBy(series => series.Directors).ToList();
        Console.WriteLine("Komedi Dizileri:");
       
        foreach (var series in sortedComedySeries)
        {
            Console.WriteLine($"Dizi Adı: {series.Name}, Tür: {series.Type}, Yönetmen: {series.Directors}");
        }
    }

    public List<TvSeries> GenerateTvSeries()
    {
        var tvSeries = new List<TvSeries>
        {
            new TvSeries
            {
                Name = "Avrupa Yakası",
                YearOfConstruction = 2004,
                Type = "Komedi",
                PublicationYear = 2004,
                Directors = "Yüksel Aksu",
                FirstPublishedPlace = "Kanal D"
            },
            new TvSeries
            {
                Name = "Yalan Dünya",
                YearOfConstruction = 2012,
                Type = "Komedi",
                PublicationYear = 2012,
                Directors = "Gülseren Buda Başkaya",
                FirstPublishedPlace = "Fox TV"
            },
            new TvSeries
            {
                Name = "Jet Sosyete",
                YearOfConstruction = 2018,
                Type = "Komedi",
                PublicationYear = 2018,
                Directors = "Gülseren Buda Başkaya",
                FirstPublishedPlace = "TV8"
            },
            new TvSeries
            {
                Name = "Dadı",
                YearOfConstruction = 2006,
                Type = "Komedi",
                PublicationYear = 2006,
                Directors = "Yusuf Pirhasan",
                FirstPublishedPlace = "Kanal D"
            },
            new TvSeries
            {
                Name = "Belalı Baldız",
                YearOfConstruction = 2007,
                Type = "Komedi",
                PublicationYear = 2007,
                Directors = "Yüksel Aksu",
                FirstPublishedPlace = "Kanal D"
            },
            new TvSeries
            {
                Name = "Arka Sokaklar",
                YearOfConstruction = 2004,
                Type = "Polisiye,Dram",
                PublicationYear = 2004,
                Directors = "Orhan Oğuz",
                FirstPublishedPlace = "Kanal D"
            },
            new TvSeries
            {
                Name = "Aşk-ı Memnu",
                YearOfConstruction = 2008,
                Type = "Dram, Romantik",
                PublicationYear = 2008,
                Directors = "Hilal Saral",
                FirstPublishedPlace = "Kanal D"
            },
            new TvSeries
            {
                Name = "Muhteşem Yüzyıl",
                YearOfConstruction = 2011,
                Type = "Tarihi,Dram",
                PublicationYear = 2011,
                Directors = "Mercan Çilingiroğlu",
                FirstPublishedPlace = "Star TV"
            },
            new TvSeries
            {
                Name = "Yaprak Dökümü",
                YearOfConstruction = 2006,
                Type = "Dram",
                PublicationYear = 2006,
                Directors = "Serdar Akar",
                FirstPublishedPlace = "Kanal D"
            }
        };
        return tvSeries;
    }
}
