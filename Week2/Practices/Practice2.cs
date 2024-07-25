using Week2.Practices.Abstracts;

namespace Week2.Practices;

/// <summary>
/// While Döngüsü Pratiği
/// </summary>
public class Practice2 : IPractice
{
    public void ExecPractice()
    {
        var selection = TakeUserInput(); // Bu metod ile kullanıcıdan hangi alıştırmayı çalıştıracağı bilgisini alıp, Selection değişkenine atıyoruz.

        switch (selection) // Kullanıcının seçimine göre aşağıda tanımlanan private metodlar çalıştırılıyor
        {
            case "1":
                Selection1();
                break;
            case "2":
                Selection2();
                break;
            case "3":
                Selection3();
                break;
            case "4":
                Selection4();
                break;
            case "5":
                Selection5();
                break;

            default:
                Console.WriteLine("Lütfen Geçerli Bir Uygulama Numarası Giriniz");
                return;
        }
    }
    
    private static string TakeUserInput()
    {
        Console.WriteLine("1 -> Konsol ekranına 10 kere 'Kendime inanıyorum, ben bu yazılım işini hallederim!' yazdır");
        Console.WriteLine("2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdır.");
        Console.WriteLine("3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdır");
        Console.WriteLine("4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdır");
        Console.WriteLine("5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdır");
        Console.Write("Çalıştırmak istediğiniz uygulamanın numarasını yazınız : ");
        var selection =
            Console.ReadLine()!
                .Trim(); // Kullanıcıdan alınan veriyi trim ile boşluklarını siliyoruz ve selection değişkenine atıyoruz.

        return selection;
    }

    private void Selection1()
    {
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(" Kendime inanıyorum, ben bu yazılım işini hallederim! " + x);
                x++;
            }
        }
    }
    
    private void Selection2()
    {
        int x = 2;
        while (x < 20)    
        {
            Console.WriteLine(x);
        x++;
        }
    }
    
    private void Selection3()
    {
        int x = 2;
        while (x < 20)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
            x++;
        }
    }
    private void Selection4()
    {
        int toplam = 0;
        int x = 51;
        while (x < 150)
        { 
            toplam += x;
            x++;
        }
        Console.WriteLine(toplam);
    }
    
    private void Selection5()
    {
        int ciftToplam = 0;
        int tekToplam = 0;
        int x = 2;
        while (x < 120)
        {
            if (x % 2 == 0)
            {
                ciftToplam += x;
            }
            else
            {
                tekToplam += x;
            }
            x++;
        }
        Console.WriteLine("Çift sayıların toplamı = " + ciftToplam);
        Console.WriteLine("Tek sayıların toplamı = " + tekToplam);
    }
}