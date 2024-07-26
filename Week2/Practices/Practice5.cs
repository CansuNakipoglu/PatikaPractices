using Week2.Practices.Abstracts;

namespace Week2.Practices;

/// <summary>
/// Metotlar Pratiği
/// </summary>
public class Practice5 : IPractice
{
    private static Random rnd = new Random();

    public void ExecPractice()
    {
        string CanBonomo = " Rüyamda buluttum. ";
        Console.WriteLine(CanBonomo);
    }

    public static int Numbers()
    {
        int rastgeleSayi = rnd.Next();
        int a = rastgeleSayi % 2;
        Console.WriteLine(a);
        return a;
    }

    public static int Carpim(int x, int y)
    {
        int z = x * y;
        Console.WriteLine(z);
        return z;
    }

    public void Bilgiler(string Ad, string Soyad)
    {
        Console.WriteLine($" Hoş Geldiniz {Ad} {Soyad} ");
    }
}
