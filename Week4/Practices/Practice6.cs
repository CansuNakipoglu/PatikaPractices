using Week4.Practices.Abstracts;

namespace Week4.Practices;
/// <summary>
/// Polymorphism Pratiği
/// </summary>

public class Practice6:IPractice
{
    public void ExecPractice()
    {
        Kare kare = new Kare();
        kare.genislik = 5;
        kare.yukseklik = 5;
        kare.KareAlanı();
        
        Dikdörtgen dikdortgen = new Dikdörtgen();
        dikdortgen.genislik = 5;
        dikdortgen.yukseklik = 6;
        dikdortgen.DikdortgenAlanı();
            
        DikUcgen dikUcgen = new DikUcgen();
        dikUcgen.genislik = 5;
        dikUcgen.yukseklik = 6;
        dikUcgen.UcgenAlanı();

    }
}

public class BaseGeometrikSekil
{
    public int genislik { get; set; }
    public int yukseklik { get; set; }

    public virtual void AlanHesapla()
    {
        // Temel sınıfta herhangi bir hesaplama yapılmıyor, alt sınıflar tarafından geçersiz kılınacak
    }
}

public class Kare : BaseGeometrikSekil
{
    public void KareAlanı()
    {
        // Kare için alan hesaplamasını yap
        int alan = genislik * genislik;  // Kare olduğu için genislik ve yükseklik aynı
        Console.WriteLine("Karenin Alanı: " + alan);
    }
}

public class Dikdörtgen : BaseGeometrikSekil
{
    public void DikdortgenAlanı()
    {
        // Dikdörtgen için alan hesaplamasını yap
        int alan = genislik * yukseklik;
        Console.WriteLine("Dikdörtgenin Alanı: " + alan);
    }
}

public class DikUcgen : BaseGeometrikSekil
{
    public void UcgenAlanı()
    {
        // Üçgen için alan hesaplamasını yap
        int alanUcgen = (genislik * yukseklik) / 2;
        Console.WriteLine("Üçgenin Alanı: " + alanUcgen);
    }
}
