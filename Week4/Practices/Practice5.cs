using System.Net.Sockets;
using Week4.Practices.Abstracts;

namespace Week4.Practices;
/// <summary>
/// Inheritance Pratiği
/// </summary>

public class Practice5 : IPractice
{
    public void ExecPractice()
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = "Cansu";
        ogrenci.Soyad = "Nakipoğlu";
        ogrenci.OgrenciNumarasi = 635265;
        ogrenci.OgrenciyiYaz();

        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Seher",
            Soyad = "Kaya",
            MaasBilgisi = 4754
        };
        ogretmen.OgretmeniYaz();
    }
}

public class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void KisiyiYaz()
    {
        Console.Write(Ad + " " + Soyad + ", ");
    }
}

public class Ogrenci : BaseKisi
{
    public int OgrenciNumarasi { get; set; }

    public void OgrenciyiYaz()
    {
        KisiyiYaz();
        Console.WriteLine("Öğrenci Numarası: " + OgrenciNumarasi);
    }
}

public class Ogretmen : BaseKisi
{
    public int MaasBilgisi { get; set; }

    public void OgretmeniYaz()
    {
        KisiyiYaz();
        Console.WriteLine(" Maaşı: " + MaasBilgisi + " " + " TL ");
    }
}