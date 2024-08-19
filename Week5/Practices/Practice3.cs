using Week5.Practices.Abstracts;
using System.Collections.Generic;
namespace Week5.Practices;
/// <summary>
/// Liste Oluşturma Pratiği 2
/// </summary>
public class Practice3:IPractice
{
    public void ExecPractice()
    {
        List<string> kahveler = new List<string>();
        
        Console.WriteLine("Lütfen 5 kahve ismi girin:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Kahve {i + 1}: ");
            string kahveIsmi = Console.ReadLine();
            kahveler.Add(kahveIsmi);
        }
        
        Console.WriteLine("\nGirilen kahve isimleri:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}