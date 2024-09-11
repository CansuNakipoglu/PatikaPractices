using Week7.Practices.Abstracts;

namespace Week7.Practices
{
    public class Practice4 : IPractice
    {
        public void ExecPractice()
        {
            // Yazarlar listesi
            List<Author> authors = new List<Author>
            {
                new Author { AuthorId = 1, Name = "Orhan Pamuk" },
                new Author { AuthorId = 2, Name = "Elif Şafak" },
                new Author { AuthorId = 3, Name = "Ahmet Ümit" }
            };

            // Kitaplar listesi
            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
                new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
                new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
                new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
            };

            // LINQ join sorgusu ile kitap ve yazarları birleştiriyoruz
            var query = from book in books
                join author in authors on book.AuthorId equals author.AuthorId
                select new { BookTitle = book.Title, AuthorName = author.Name };

            // Sonuçları uygun formatta ekrana yazdırıyoruz
            Console.WriteLine("Kitaplar ve Yazarlar:");
            foreach (var result in query)
            {
                Console.WriteLine($"Kitap Başlığı: {result.BookTitle}, Yazar: {result.AuthorName}");
            }
        }

        // Yazar sınıfı
        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
        }

        // Kitap sınıfı
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; } // Yazarla ilişkilendirilen kimlik
        }
    }
}