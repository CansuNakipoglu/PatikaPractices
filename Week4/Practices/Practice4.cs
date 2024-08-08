using System.Net;
using Week4.Practices.Abstracts;

namespace Week4.Practices;

/// <summary>
/// Encapsulation Pratiği
/// </summary>
public class Practice4 : IPractice
{
    public void ExecPractice()
    {
        Araba araba = new Araba("Audi", "Q3", "Siyah", 5);
        Console.WriteLine(araba.Marka + " " + araba.Model + " " + araba.Renk + " " + araba.KapiSayisi);
    }
}

public class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; private set; }

    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisiGüncelle(kapiSayisi);
    }

    public void KapiSayisiGüncelle(int kapiSayisi)
    {
        if (kapiSayisi is 2 or 4)
        {
            KapiSayisi = kapiSayisi;
        }
        else
        {
            Console.WriteLine("Error");
            KapiSayisi = -1;
        }
    }
}