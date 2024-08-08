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
        Araba arabaAdi = new Araba("Audi", "Q3", "Siyah", 5);
    }
}

public class Araba
{
    public string ArabaMarkasi { get; set; }
    public string ArabaModeli { get; set; }
    public string ArabaRengi { get; set; }
    public int KapiSayisi { get; private set; }

    public Araba(string arabaMarkasi, string arabaModeli, string arabaRengi, int kapiSayisi)
    {
        ArabaMarkasi = arabaMarkasi;
        ArabaModeli = arabaModeli;
        ArabaRengi = arabaRengi;
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