using Week1.Practices.Abstracts;

namespace Week1.Practices;
/// <summary>
/// Kim Milyoner OLmak İster Pratiği
/// </summary>

public class Practice9: IPractice
{
    public void ExecPractice()
    {
        int toplamDogurCevap = 0;
        
        Console.WriteLine("1) Kızınca tüküren hayvan hangisidir ?");
        Console.WriteLine("a) Lama b) Deve ");
        var ilkSorununCevabi = Console.ReadLine().Trim().ToUpper();

        if (ilkSorununCevabi == "A")
        {
            Console.WriteLine("Tebrikler Doğru Cevap");
            toplamDogurCevap++;
        }
        else
        {
            Console.WriteLine("Ne yazık ki yanlış cevap");
        }
        
        Console.WriteLine("2) Dünya'ya en yakın gezegen hangisidir ?");
        Console.WriteLine("a) Venüs b) Mars ");
        var ikinciSorununCevabi = Console.ReadLine().Trim().ToUpper();
        
        if (ikinciSorununCevabi == "A")
        {
            Console.WriteLine("Tebrikler Doğru Cevap");
            toplamDogurCevap++;
        }
        else
        {
            Console.WriteLine("Ne yazık ki yanlış cevap");
        }

        if (toplamDogurCevap == 2)
        {
            Console.WriteLine("Tebrikler yarışmayı kazandınız.");
            return;
        }
        else if (toplamDogurCevap == 0)
        {
            Console.WriteLine("Ne yazık ki yarışmayı kaybettiniz");
            return;
        }
        
        Console.WriteLine("3) 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
        Console.WriteLine("a) 7 b) 12 ");
        var ucuncuSorununCevabi = Console.ReadLine().Trim().ToUpper();
        
        if (ucuncuSorununCevabi == "B")
        {
            Console.WriteLine("Tebrikler Doğru Cevap");
            toplamDogurCevap++;
        }
        else
        {
            Console.WriteLine("Ne yazık ki yanlış cevap");
        }
        
        if (toplamDogurCevap >= 2)
        {
            Console.WriteLine("Tebrikler yarışmayı kazandınız.");
            return;
        }
        else
        {
            Console.WriteLine("Ne yazık ki yarışmayı kaybettiniz");
            return;
        }
        
    }
}