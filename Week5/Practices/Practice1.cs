using Week5.Practices.Abstracts;

namespace Week5.Practices;

/// <summary>
/// Array Pratiği
/// </summary>
public class Practice1:IPractice
{
    public void ExecPractice()
    {
        int[] sayilar = new int[10];
        
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = i + 1; 
        }
        
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("1 Sayı ekleyiniz");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());
        
        int[] yeniDizi = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }
        yeniDizi[sayilar.Length] = yeniSayi;

        Array.Sort(yeniDizi);
        
        Array.Reverse(yeniDizi);
        
        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }
    }
}

