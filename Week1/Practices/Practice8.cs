using System.Diagnostics;
using System.Security.Cryptography;
using Week1.Practices.Abscracts;

namespace Week1.Practices;
/// <summary>
/// Switch Case Yapısı
/// </summary>
public class Practice8 : IPractice
{
    public void ExecPractice()
    {
        string elmaFiyati = "2 TL";
        string armutFiyati = "3 TL";
        string cilekFiyati = "2 TL";
        string muzFiyati = "3 TL";
        string meyveFiyati = "4 TL";

        Console.WriteLine("Rüya manavına hoşgeldiniz! ");
        Console.WriteLine("Elma = " + elmaFiyati);
        Console.WriteLine("Armut = " + armutFiyati);
        Console.WriteLine("Çilek = " + cilekFiyati);
        Console.WriteLine("Muz = " + muzFiyati);
        Console.WriteLine("Diğer  bütün meyveler = " + meyveFiyati);
        Console.Write(" Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer) = ");
        string secilenMeyve = Console.ReadLine()?.Trim().ToUpper();

        /*
        if (secilenMeyve == "ELMA")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + elmaFiyati);
        }
        else if (secilenMeyve == "ARMUT")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + armutFiyati);
        }
        else if (secilenMeyve == "ÇİLEK")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + cilekFiyati);
        }
        else if (secilenMeyve == "MUZ")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + muzFiyati);
        }
        else
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + meyveFiyati);
        }
        */
        
        // Meyve sayıları artış gösterebileceği için switch yapısı daha okunur ve daha verimli olucaktır
        switch (secilenMeyve)
        {
            case "ELMA":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + elmaFiyati);
                break;
            case "ARMUT":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + armutFiyati);
                break;
            case "ÇİLEK":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + cilekFiyati);
                break;
            case "MUZ":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + muzFiyati);
                break;
            default:
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı = " + meyveFiyati);
                break;
        }
    }

}