using Week1.Practices.Abscracts;


namespace Week1.Practices;

/// <summary>
/// Console Komutları
/// </summary>

public class Practice5:IPractice
{
    public void ExecPractice()
    {
        
        Console.WriteLine("Adınız, Soyadınız");
        string nameSurname = Console.ReadLine();
        Console.WriteLine(" Doğum Yılınız: ");
        var BirthdayYear = Console.ReadLine();
        Console.WriteLine(nameSurname + " " + BirthdayYear);
        

    }
}