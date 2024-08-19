using Week5.Practices.Abstracts;
using System.Collections.Generic;
namespace Week5.Practices;
/// <summary>
/// Liste Oluşturma Pratiği
/// </summary>
public class Practice2:IPractice
{
    public void ExecPractice()
    {
        List<string> davetliler = new List<string>();
        davetliler.Add("Bülent Ersoy");
        davetliler.Add("Ajda Pekkan");
        davetliler.Add("Ebru Gündeş");
        davetliler.Add("Hadise");
        davetliler.Add("Hande Yener");
        davetliler.Add("Tarkan");
        davetliler.Add("Funda Arar");
        davetliler.Add("Demet Akalın");
        
        Console.WriteLine("Davetliler: ");
        foreach (string davetli in davetliler)
        {
            Console.WriteLine(davetli);
        }
        
    }
}
    
