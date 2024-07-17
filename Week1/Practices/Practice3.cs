using Week1.Practices.Abscracts;

namespace Week1.Practices;

/// <summary>
/// Casting İşlemleri
/// </summary>
public class Practice3: IPractice
{
    public void ExecPractice()
    {
        Console.Write("Çevirilecek sayıyı giriniz: ");
        
        string userInput = Console.ReadLine();

        var result = int.TryParse(userInput, out int convertedNumber);
        
        if (result)
        {
            Console.WriteLine("Çevirme işlemi başarılı");
        }
        else
        {
           Console.WriteLine("Çevirme işlemi başarısız"); 
        }
    }
}