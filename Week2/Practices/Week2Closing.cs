using System.Data;
using Week2.Practices.Abstracts;

namespace Week2.Practices;

/// <summary>
/// Hafta 2 Kapanış Projesi
/// </summary>
public class Week2Closing : IPractice
{
    private static Random rnd = new Random();

    public void ExecPractice()
    {
        var selection =
            TakeUserInput(); // Bu metod ile kullanıcıdan hangi alıştırmayı çalıştıracağı bilgisini alıp, Selection değişkenine atıyoruz.

        switch (selection) // Kullanıcının seçimine göre aşağıda tanımlanan private metodlar çalıştırılıyor
        {
            case "1":
                Selection1();
                break;
            case "2":
                Selection2();
                break;
            case "3":
                Selection3();
                break;
            case "4":
                Selection4();
                break;
            case "5":
                Selection5();
                break;
            case "6":
                Selection6();
                break;
            case "7":
                Selection7();
                break;
            case "8":
                BenDegerDondurmem();
                break;
            case "9":
                int resultQuestion9 = ExecuteQuestion9(6, 9);
                Console.WriteLine(resultQuestion9);
                break;
            case "10":
                string resultQuestion10 = ExecuteQuestion10(true);
                Console.WriteLine(resultQuestion10);
                break;
            case "11":
                int resultQuestion11 = ExecuteQuestion11(12, 14, 16);
                Console.WriteLine("En büyük yaş = " + resultQuestion11);
                break;
            case "12":
                try
                {
                    int resultQuestion12 = ExecuteQuestion12(12, 13, 67, 76);
                    Console.WriteLine("En büyük sayı = " + resultQuestion12);
                }
                catch (Exception ex)
                {
                    //log(ex)
                }

                break;
            case "13":
                ExecuteQuestion13();
                break;
            case "14":
                try
                {
                    bool IsEven = ExecuteQuestion14();
                    if (IsEven)
                    {
                        Console.WriteLine("Sayı çifttir. ");
                    }
                    else
                    {
                        Console.WriteLine("Sayı tektir. ");
                    }
                }
                catch (Exception ex)
                {
                    //log(ex)
                }

                break;
            case "15":
                int totalDistance = ExecuteQuestion15();
                Console.WriteLine("Gidilen yol = " + totalDistance + " km ");
                break;
            case "16":
                double area = ExecuteQuestion16();
                Console.WriteLine(area);
                break;
            case "17":
                ExecuteQuestion17();
                break;
            case "18":
                ExecuteQuestion18();
                break;
            default:
                Console.WriteLine("Lütfen Geçerli Bir Uygulama Numarası Giriniz");
                return;
        }
    }

    private static string TakeUserInput()
    {
        Console.WriteLine("1 -> Çıktıyı yazan bir program");
        Console.WriteLine(
            "2 ->Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.");
        Console.WriteLine("3 -> Rastgele bir sayı üretip , ekrana yazdırınız.");
        Console.WriteLine("4 -> Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.");
        Console.WriteLine("5 -> Kullanıcıya yaşını sorup , 18'den büyükse, küçükse yazdıran bir uygulama.");
        Console.WriteLine(
            "6 -> Ekrana 10 defa  Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem. yazan bir uygulama.");
        Console.WriteLine(
            "7 -> Kullanıcıdan 2 adet metinsel değer alıp Gülse Birsel , Demet Evgar , bunların yerlerini değiştiriniz.");
        Console.WriteLine(
            "8 -> Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma yazsın.");
        Console.WriteLine("9 -> iki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.");
        Console.WriteLine(
            "10 -> Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.");
        Console.WriteLine("11 -> 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.");
        Console.WriteLine(
            "12 -> Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.");
        Console.WriteLine(
            "13 -> Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.");
        Console.WriteLine(
            "14 -> Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.");
        Console.WriteLine(
            "15 -> Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.");
        Console.WriteLine("16 -> Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.");
        Console.WriteLine(
            "17 -> Zaman bir GeRi SayIm cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.");
        Console.WriteLine(
            "18 -> Selamlar metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.");
        Console.Write("Çalıştırmak istediğiniz uygulamanın numarasını yazınız : ");
        var selection =
            Console.ReadLine()!
                .Trim(); // Kullanıcıdan alınan veriyi trim ile boşluklarını siliyoruz ve selection değişkenine atıyoruz.

        return selection;
    }

    private void Selection1()
    {
        Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");
    }

    private void Selection2()
    {
        int number = 2;
        string text = "Cansu";
        Console.WriteLine(number + " " + text);
    }

    private void Selection3()
    {
        int randomNumber = rnd.Next();
        Console.WriteLine(randomNumber);
    }

    private void Selection4()
    {
        int randomNumber = rnd.Next();
        Console.WriteLine(randomNumber % 3);
    }

    private void Selection5()
    {
        Console.WriteLine("Yaşınız kaç?");
        string age = Console.ReadLine()!.Trim();

        if (int.TryParse(age, out int age1))
        {
            if (age1 <= 18)
            {
                Console.WriteLine(" - ");
            }
            else
            {
                Console.WriteLine(" + ");
            }
        }
        else
        {
            Console.WriteLine("Lütfen bir sayı giriniz. ");
        }
    }

    private void Selection6()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }
    }

    private void Selection7()
    {
        string name1 = "Gülse Birsel";
        string name2 = "Demet Evgar";

        string tempName = name1;
        name1 = name2;
        name2 = tempName;

        //(name1, name2) = (name2, name1); //Değişkenlerin değerlerini kolay bir şekilde değiştirmek için bu yöntem de kullanılabilir.

        Console.WriteLine("İsim 1 = " + name1 + " İsim 2 = " + name2);
    }

    private void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
    }

    private static int ExecuteQuestion9(int number1, int number2)
    {
        int result = (number1 + number2);
        return result;
    }

    private static string ExecuteQuestion10(bool IsSuccess)
    {
        if (IsSuccess)
        {
            return "Başarılı";
        }
        else
        {
            return "Başarısız";
        }
    }

    private int ExecuteQuestion11(int x, int y, int z)
    {
        return Math.Max(Math.Max(x, y), z);
    }

    private int ExecuteQuestion12(params int[] numbers)
    {
        if (numbers.Length < 1)
        {
            Console.WriteLine("Hatalı veya eksik giriş yaptınız");
            throw new InvalidDataException();
        }

        int maxNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        return maxNumber;
    }

    private void ExecuteQuestion13()
    {
        Console.WriteLine("İsim Giriniz");
        string name1 = Console.ReadLine()!;

        Console.WriteLine("İsim Giriniz");
        string name2 = Console.ReadLine()!;

        string tempName = name1;
        name1 = name2;
        name2 = tempName;

        //(name1, name2) = (name2, name1); //Değişkenlerin değerlerini kolay bir şekilde değiştirmek için bu yöntem de kullanılabilir.

        Console.WriteLine("İsim 1 = " + name1 + " İsim 2 = " + name2);
    }

    private static bool ExecuteQuestion14()
    {
        Console.Write("Bir sayı giriniz: ");
        string input = Console.ReadLine()!.Trim();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            throw new InvalidDataException();
        }
    }

    private int ExecuteQuestion15()
    {
        Console.WriteLine("Hızını giriniz");
        string speed = Console.ReadLine();

        Console.WriteLine("Sürenizi giriniz");
        string time = Console.ReadLine();

        int timeInteger = Convert.ToInt32(time);
        int speedInteger = Convert.ToInt32(speed);
        int totalDistance = speedInteger * timeInteger;

        return totalDistance;
    }

    private double ExecuteQuestion16()
    {
        Console.WriteLine("Dairenin yarıçapını giriniz");
        string r1 = Console.ReadLine();
        double r = Convert.ToInt32(r1);
        double area = Math.Pow(r, 2) * Math.PI;

        return area;
    }

    private void ExecuteQuestion17()
    {
        string text = "Zaman bir GeRi SayIm";
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.ToLower());
    }

    private void ExecuteQuestion18()
    {
        string sentence = "    Selamlar   ";
        Console.WriteLine(sentence.Trim());
    }
}