using Week4.Practices.Abstracts;

namespace Week4.Practices;

/// <summary>
/// Hafta 4 Kapanış
/// </summary>
public class Practice8 : IPractice
{
    public void ExecPractice()
    {
        while (true)
        {
            Console.Write("Telefon Üretmek İçin 1'e, Bilgisayar Üretmek İçin 2'ye Basınız: ");
            var selectedKey = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (!(selectedKey is '1' or '2'))
            {
                Console.WriteLine("Hatalı Bir Giriş Yaptınız Lütfen Tekrar Deneyiniz");
            }

            Console.Write("Lütfen Bir Seri Numarası Giriniz: ");
            var serialNo = Console.ReadLine().ToString();

            Console.Write("Lütfen Bir Ad Giriniz: ");
            var name = Console.ReadLine().ToString();

            Console.Write("Lütfen Bir Açıklama Giriniz: ");
            var description = Console.ReadLine().ToString();

            Console.Write("Lütfen Bir İşletim Sistemi Giriniz: ");
            var operatingSystem = Console.ReadLine().ToString();

            var selectedText = selectedKey == '1' ? "Türkiye Lisans" : "Blutooth";
            Console.Write($"Lütfen {selectedText} Bilgisini Giriniz (VAR / YOK): ");
            bool isTrue = Console.ReadLine().ToUpper() == "VAR";

            BaseMakine makine;

            if (selectedKey == '1')
            {
                var telefon = new Telefon();
                telefon.Ad = name;
                telefon.SeriNumara = serialNo;
                telefon.IsletimSistemi = operatingSystem;
                telefon.Aciklama = description;
                telefon.TrLisansli = isTrue;

                makine = telefon;
            }
            else
            {
                var bilgisayar = new Bilgisayar();
                bilgisayar.Ad = name;
                bilgisayar.SeriNumara = serialNo;
                bilgisayar.IsletimSistemi = operatingSystem;
                bilgisayar.Aciklama = description;
                bilgisayar.Bluetooth = isTrue;

                Console.Write("Lütfen USB Port Sayısı Giriniz(2-4): ");
                var usbPortNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                bilgisayar.UsbGirisSayisiGuncelle(usbPortNumber);

                makine = bilgisayar;
            }

            Console.WriteLine(new string('═', Console.WindowWidth));
            makine.BilgileriYazdir();
            Console.WriteLine(new string('═', Console.WindowWidth));
            Console.Write("Ürün Başarılı Bir Şekilde Üretildi.\n \nYeni Bir Ürün Üretmek için Lütfen 1'e basınız: ");

            if (Console.ReadKey().KeyChar != '1')
            {
                Console.WriteLine("\n \nİyi Günler!");
                break;
            }

            Console.WriteLine("\n \n");
        }
    }
}

public abstract class BaseMakine
{
    public DateTime UretimTarihi { get; protected set; }
    public string SeriNumara { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public abstract void BilgileriYazdir();
    public abstract void UrunAdiGetir();
}

public class Telefon : BaseMakine
{
    public bool TrLisansli { get; set; }

    public Telefon()
    {
        UretimTarihi = DateTime.Now;
    }

    public override void BilgileriYazdir()
    {
        var lisansText = TrLisansli ? "var" : "yok";
        Console.WriteLine(
            $"Üretim Tarihi:{UretimTarihi} \nSeri Numarası: {SeriNumara} \nAd:{Ad} \nAçıklama: {Aciklama} \nİşletim Sistemi: {IsletimSistemi} \nTürkiye Lisansı: {lisansText}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

public class Bilgisayar : BaseMakine
{
    public bool Bluetooth { get; set; }

    public Bilgisayar()
    {
        UretimTarihi = DateTime.Now;
    }

    public int UsbGirisSayisi { get; private set; }

    public void UsbGirisSayisiGuncelle(int girisSayisi)
    {
        if (girisSayisi is 2 or 4)
        {
            UsbGirisSayisi = girisSayisi;
        }
        else
        {
            Console.WriteLine("Hatalı usb giriş sayısı yazdınız ");
            UsbGirisSayisi = -1;
        }
    }

    public override void BilgileriYazdir()
    {
        var blutoohtText = Bluetooth ? "var" : "yok";
        Console.WriteLine(
            $"Üretim Tarihi:{UretimTarihi} \nSeri Numarası: {SeriNumara} \nAd:{Ad} \nAçıklama: {Aciklama} \nİşletim Sistemi: {IsletimSistemi} \nUsb Giriş Sayısı: {UsbGirisSayisi} \nBluetooth: {blutoohtText}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}