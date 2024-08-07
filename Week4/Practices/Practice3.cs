using System.Runtime.InteropServices;
using Week4.Practices.Abstracts;

namespace Week4.Practices;
/// <summary>
/// Patika Kütüphanesi
/// </summary>
public class Practice3:IPractice
{
    public void ExecPractice() 
    {
        //Aşağıdaki satırda tipi PatikaKütüphanesi olan bir değişken tanımlıyoruz ve ona değer atıyoruz. Değer atama işleminde new keywordunu kullanıyoruz.
        //Bu keyword sayesinde PatikaKütüphanesi sınıfından bir örnek almış oluyoruz ve değişkenimizin değerlerini saklayabileceğimiz heap bellekten yer ayırmış oluyoruz.
        PatikaKutuphanesi kitap1 = new PatikaKutuphanesi("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitapevi");
        Console.WriteLine(kitap1.KitapAdi + " " + kitap1.YazarAdi + " " + kitap1.YazarSoyadi + " " + kitap1.SayfaSayisi + " " + kitap1.Yayinevi);

        PatikaKutuphanesi kitap2 = new PatikaKutuphanesi();
        Console.WriteLine("Kitap 2 Kayıt Tarihi: " + kitap2.KayitTarihi);
    }
}

public class PatikaKutuphanesi //Object orianted çalışabilmek adına Patika Kütüphanesi adında bir sınıf tanımladım. 
{
    //Sınıfımıza ait özellikleri (propertyleri) tanımlıyoruz.
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string Yayinevi { get; set; }
    public DateTime KayitTarihi { get; set; }
    
    //Paramtresiz bir oluşturucu method tanımlıyoruz ve bu sayade kullanıcı dilerse propertyleri doldurmadan da bu sınıftan bir örnek oluşturabilir.
    
    public PatikaKutuphanesi()
    {
        KayitTarihi = DateTime.Now;
    }
    
    //Burada da parametreleri olan bir oluşturucu method (constructor method) tanımlıyoruz. Bu sayade sınıfın örneğinin oluşturulduğu esnada özellikleri dolu bir şekilde oluşmasını sağlıyoruz.
    public PatikaKutuphanesi(string kitapAdi, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
    {
        KitapAdi = kitapAdi;
        YazarAdi = yazarAdi;
        YazarSoyadi = yazarSoyadi;
        SayfaSayisi = sayfaSayisi;
        Yayinevi = yayinevi;
        KayitTarihi = DateTime.Now;
    }
}
