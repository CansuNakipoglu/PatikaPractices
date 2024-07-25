using Week2.Practices.Abstracts;

namespace Week2.Practices;
/// <summary>
/// Yol Arkadaşı : Tatil uygulaması
/// </summary>
public class Practice4 : IPractice
{
    public void ExecPractice()
    {
        while (true)
        {
            ConsoleNewLine();
            
            var selectedCityPrice = GetSelectedCityPrice();

            var selectedPeopleCount = GetSelectedPeopleCount();

            var pathWayPrice = GetPathWayPrice();

            var totalPrice = selectedPeopleCount * (selectedCityPrice + pathWayPrice);
            
            ConsoleNewLine();
            
            Console.WriteLine($"Tatiliniz toplam bedeli = {totalPrice} \n Başka bir tatil planlamak ister misiniz ? (Evet/Hayır) = ");
            var selection = Console.ReadLine()!.Trim().ToUpper();

            switch (selection)
            {
                case "EVET":
                    continue;
                case "HAYIR":
                    ConsoleNewLine();
                    Console.WriteLine("İyi günler");
                    return;
                default:
                    ConsoleNewLine();
                    Console.WriteLine("Geçerli bir seçim yapmadınız İyi günler");
                    return;
            }
        }
    }

    private static void ConsoleNewLine()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', Console.WindowWidth));
        Console.WriteLine();
    }

    private static int GetPathWayPrice()
    {
        while (true)
        {
            ConsoleNewLine();
            Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
            Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
            Console.Write("Tatile Ne Şekilde Gitmek İstiyorsunuz? Lütfen Numarasını Yazınız = ");
            var selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    return 1500;
                case "2":
                    return 4000;
                default:
                    ConsoleNewLine();
                    Console.WriteLine("Lütfen Geçerli Bir Seçim Yapınız \n");
                    continue;
            }

            break;
        }
    }

    private static int GetSelectedPeopleCount()
    {
        while (true)
        {
            ConsoleNewLine();
            Console.Write("Kaç kişi gitmeyi planlıyorsunuz? = ");
            var peopleCount = Console.ReadLine();

            if (int.TryParse(peopleCount, out var peopleCountInteger) && peopleCountInteger > 0)
            {
                return peopleCountInteger;
            }
            else
            {
                ConsoleNewLine();
                Console.WriteLine("Hatalı giriş yaptınız lütfen tekrar deneyin.");
            }
        }
    }

    private static int GetSelectedCityPrice()
    {
        while (true)
        {
            Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
            Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
            Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
            Console.Write("Gitmek istediğiniz şehirin adını yazınız = ");
            var selection =
                Console.ReadLine()!.Trim()
                    .ToUpper(); // Kullanıcıdan alınan veriyi trim ile boşluklarını siliyoruz ve selection değişkenine atıyoruz.

            switch (selection) // Kullanıcının seçimine göre aşağıda tanımlanan private metodlar çalıştırılıyor
            {
                case "BODRUM":
                    ConsoleNewLine();
                    Console.WriteLine(
                        "Bodrum'da tatil yaparken, tarihi Bodrum Kalesi'ni ziyaret edebilir, güneşin tadını Gümbet Plajı'nda çıkarabilirsiniz.");
                    return 4000;

                case "MARMARİS":
                    ConsoleNewLine();
                    Console.WriteLine(
                        "Marmaris'te tatil yaparken, sahil boyunca uzanan İçmeler Plajı'nda güneşlenip denizin keyfini çıkarabilirsiniz.");
                    return 3000;

                case "ÇEŞME":
                    ConsoleNewLine();
                    Console.WriteLine(
                        "Çeşme'de tatil yaparken, Alaçatı'nın taş sokaklarında gezinebilir ve meşhur rüzgar sörfü noktalarında spor yapabilirsiniz.");
                    return 5000;

                default:
                    ConsoleNewLine();
                    Console.WriteLine("Lütfen Geçerli Bir Şehir Adı Giriniz \n");
                    continue;
            }
        }
    }
}