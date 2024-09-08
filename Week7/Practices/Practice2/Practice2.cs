using Week7.Practices.Abstracts;

namespace Week7.Practices;

public class Practice2 : IPractice
{
    public void ExecPractice()
    {
        var artists = GenerateArtists();

        
        //Adı 'S' ile başlayan şarkıcılar
        var artistsStartWithS = artists.Where(x => x.Name.ToLower()[0] =='s').ToList();
        
        //Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
       var artistsWithAlbumSalesOver10Million = artists.Where(artist => artist.AlbumSales > 10).ToList();
       
       //2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
       var popSingersWhoDebutedBefore2000 =
           artists.Where(x => x.ReleaseYear < 2000 && x.MusicType.ToLower() == "pop").OrderBy(x => x.Name).ToList();
       
       //En çok albüm satan şarkıcı
       var bestSellingAlbumArtist = artists.OrderByDescending(x => x.AlbumSales).FirstOrDefault();
       
       //En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
       var newestAndOldestSinger = artists.Where(x =>
               artists.Max(y => y.ReleaseYear) == x.ReleaseYear || artists.Min(y => y.ReleaseYear) == x.ReleaseYear)
           .ToList();


    }

    public List<Artist> GenerateArtists()
    {
        var artists = new List<Artist>
        {
            new Artist
            {
                Name = "Ajda Pekkan",
                MusicType = "Pop",
                ReleaseYear = 1968,
                AlbumSales = 20
            },
            new Artist
            {
                Name = "Sezen Aksu",
                MusicType = "Türk Halk Müziği/Pop",
                ReleaseYear = 1971,
                AlbumSales = 10
            },
            new Artist
            {
                Name = "Funda Arar",
                MusicType = "Pop",
                ReleaseYear = 1999,
                AlbumSales = 3
            },
            new Artist
            {
                Name = "Sertab Erener",
                MusicType = "Pop",
                ReleaseYear = 1994,
                AlbumSales = 5
            },
            new Artist
            {
                Name = "Sıla",
                MusicType = "Pop",
                ReleaseYear = 2009,
                AlbumSales = 3
            },
            new Artist
            {
                Name = "Serdar Ortaç",
                MusicType = "Pop",
                ReleaseYear = 1994,
                AlbumSales = 10
            },
            new Artist
            {
                Name = "Tarkan",
                MusicType = "Pop",
                ReleaseYear = 1992,
                AlbumSales = 40
            },
            new Artist
            {
                Name = "Hande Yener",
                MusicType = "Pop",
                ReleaseYear = 1999,
                AlbumSales = 7
            },
            new Artist
            {
                Name = "Hadise",
                MusicType = "Pop",
                ReleaseYear = 2005,
                AlbumSales = 5
            },
            new Artist
            {
                Name = "Gülben Ergen",
                MusicType = "Pop/Türk Halk Müziği",
                ReleaseYear = 1997,
                AlbumSales = 10
            },
            new Artist
            {
                Name = "Neşet Ertaş",
                MusicType = "Türk Halk Müziği",
                ReleaseYear = 1960,
                AlbumSales = 2
            },
        };
        return artists;
    }
}

