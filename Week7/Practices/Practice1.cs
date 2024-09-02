using Week7.Practices.Abstracts;

namespace Week7.Practices;
/// <summary>
/// Linq Pratiği
/// </summary>
public class Practice1 : IPractice
{
    public void ExecPractice()
{
            // Rastgele 10 adet sayıdan oluşan liste oluşturma
            Random rand = new Random();
            List<int> numbers = Enumerable.Range(0, 10).Select(_ => rand.Next(-10, 30)).ToList();

            Console.WriteLine("Liste: " + string.Join(", ", numbers));

            // Çift olan sayılar
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Çift olan sayılar: " + string.Join(", ", evenNumbers));

            // Tek olan sayılar
            var oddNumbers = numbers.Where(n => n % 2 != 0);
            Console.WriteLine("Tek olan sayılar: " + string.Join(", ", oddNumbers));

            // Negatif sayılar
            var negativeNumbers = numbers.Where(n => n < 0);
            Console.WriteLine("Negatif sayılar: " + string.Join(", ", negativeNumbers));

            // Pozitif sayılar
            var positiveNumbers = numbers.Where(n => n > 0);
            Console.WriteLine("Pozitif sayılar: " + string.Join(", ", positiveNumbers));

            // 15'ten büyük ve 22'den küçük sayılar
            var between15and22 = numbers.Where(n => n > 15 && n < 22);
            Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", between15and22));

            // Listedeki her bir sayının karesi
            var squares = numbers.Select(n => n * n).ToList();
            Console.WriteLine("Her bir sayının karesi: " + string.Join(", ", squares));
        }
    }
