using Week2.Practices.Abstracts;

namespace Week2.Practices;
/// <summary>
/// For Döngüsü Pratiği
/// </summary>
public class Practice1: IPractice
{
    public void ExecPractice()
    { 
        var selection = TakeUserInput();
        
        switch (selection)
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
        var selection = Console.ReadLine()!.Trim();

        return selection;
    }
    
    private static void Selection1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }
    }
    
    private static void Selection2()
    {
        for (int i = 1; i < 20; i++)
        {
            Console.WriteLine(i);
        }
    }
    
    private static void Selection3()
    {
        for (int i = 1; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    private static void Selection4()
    {
        int toplam = 0;
        for (int i = 51; i < 150; i++)
        {
            toplam += i;
        }

        Console.WriteLine(toplam);
    }
    
    private static void Selection5()
    {
        int ciftToplam = 0;
        int tekToplam = 0;
        for (int i = 1; i < 120; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplam += i;
            }
            else
            {
                tekToplam += i;
            }
        }
        
        Console.WriteLine("Çift sayıların toplamı = " + ciftToplam + " Tek sayıların toplamı = " + tekToplam);
    }
}