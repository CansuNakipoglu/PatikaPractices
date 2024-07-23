using Week1.Practices.Abstracts;

namespace Week1.Practices;

/// <summary>
/// Operatörler
/// </summary>
public class Practice4:IPractice
{
    public void ExecPractice()
    {
        int x = 2;
        int y = 5;
        int toplam = x + y;
        int carpim = x * y;
        int bolum = x / y;
        int fark = x - y;
        int kalan = x % y;
        Console.WriteLine(x > y);
        
        int z = 12;
        int sonuc=z -= 5; 
       
       Console.WriteLine(sonuc);




    }
}