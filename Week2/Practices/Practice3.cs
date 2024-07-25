using Week2.Practices.Abstracts;

namespace Week2.Practices;

/// <summary>
/// While vs Do-While Pratiği
/// </summary>
public class Practice3 : IPractice
{
    public void ExecPractice()
    {
        int deger;
        Console.WriteLine("Lütfen bir değer girin");
        deger = Convert.ToInt32(Console.ReadLine());
        int sayac = 0;
        while (sayac <= deger)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }

        Console.Write("Lütfen bir limit değeri girin: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sayac1 = 0;

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac1++;
        } while (sayac1 <= limit);
        // do while önce işi yapar sonra şartını kontrol eder. Şartı sağlıyorsa işi yapmaya devam eder. Şartı sağlamıyor ise işi yapmayı bırakır.
        // while ise önce şartı kontrol eder, şartı sağlıyorsa işi yapar sağlamıyorsa işi yapmaz.
    }
}