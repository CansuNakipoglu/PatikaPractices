using Week1.Practices.Abstracts;

namespace Week1.Practices;

public class Practice6:IPractice
{
    public void ExecPractice()
    {
        #region Kullanıcıdan Verileri Al

        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");
        
        Console.WriteLine("TC Kimlik Numaranızı Yazınız");
        string kimlik = Console.ReadLine(); // Kullanıcının konsola girdiği girdiler bize string olarak döneceği için string kullandık.
        
        Console.WriteLine("Adınız ve Soyadınızı Yazınız");
        string adSoyad = Console.ReadLine();
        
        Console.WriteLine("Telefon numaranızı Giriniz");
        string telefon = Console.ReadLine();// Kullanıcının konsola girdiği girdiler bize string olarak döneceği için string kullandık.
        
        Console.WriteLine("Yaşınız?");
        string yas = Console.ReadLine(); // Kullanıcının konsola girdiği girdiler bize string olarak döneceği için string kullandık.
        
        Console.WriteLine(("İlk ürünün fiyatı"));
        string ilkFiyat = Console.ReadLine(); // Kullanıcının konsola girdiği girdiler bize string olarak döneceği için string kullandık.
        
        Console.WriteLine("İkinci ürünün fiyatı");
        string ikinciFiyat = Console.ReadLine(); // Kullanıcının konsola girdiği girdiler bize string olarak döneceği için string kullandık.       

        #endregion

        #region Hesaplamaları Yap

        int.TryParse(ilkFiyat, out int intIlkFiyat); // İki fiyatı rakamsal olarak toplayabilmek için int değişkenlere atadım
        int.TryParse(ikinciFiyat, out int intIkinciFiyat); //İki fiyatı rakamsal olarak toplayabilmek için int değişkenlere atadım

        int toplamFiyat = intIlkFiyat + intIkinciFiyat;
        int sonuc = toplamFiyat % 10; 

        #endregion
        
        #region Kullanıcı için gerekli bilgileri konsola yaz

        Console.WriteLine(kimlik + " TC kimlik numaralı " + adSoyad + " isimli kişi için kayıt oluşturulmuştur. ");
        Console.WriteLine(telefon + " Telefon numarasına bildirim mesajı gönderilmiştir.");
        Console.WriteLine(toplamFiyat + " toplam harcama karşılığı kazanılan %10 Patika puan miktarı " + sonuc + " dir." );
        
        #endregion
    }
}