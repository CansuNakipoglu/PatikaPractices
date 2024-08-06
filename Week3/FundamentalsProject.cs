namespace Week3;
/// <summary>
/// Fundamentals Project
/// </summary>

public static class FundamentalsProject
{
    public static void Exec()
    {
        var selection = TakeUserInput(); // Bu metod ile kullanıcıdan hangi alıştırmayı çalıştıracağı bilgisini alıp, Selection değişkenine atıyoruz.

        switch (selection) // Kullanıcının seçimine göre aşağıda tanımlanan private metodlar çalıştırılıyor
        {
            case "1":
                ExecFindRandomNumberGame();
                break;
            case "2" :
                Calculator();
                break;
        }
}

    private static string TakeUserInput()
    {
        Console.WriteLine("1 -> Rastgele Sayı Bulma Oyunu");
        Console.WriteLine("2 -> Hesap Makinesi");
        Console.WriteLine("3 -> Ortalama Hesaplama");
        
        var selection = Console.ReadLine()!.Trim(); // Kullanıcıdan alınan veriyi trim ile boşluklarını siliyoruz ve selection değişkenine atıyoruz.

        return selection;
    }

    private static void ExecFindRandomNumberGame()
    {
   Random rnd = new Random();
   int randomNumber = rnd.Next(10);
   Console.WriteLine("Sayıyı tahmin ediniz.5 Hakkınız bulunmaktadır. ");
   var number1 = Console.ReadLine();
   var number = Convert.ToInt32(number1);
   
   if(number<10)
   {
       Console.WriteLine("Sayıya yaklaştınız.4 tahmin hakkınız kalmıştır. ");
   }
   else
   {
       Console.WriteLine("Sayıdan uzaklaştınız, daha küçük bir değer deneyiniz. 4 Hakkınız kalmıştır. ");
   }

   Console.WriteLine("Sayıyı tahmin ediniz.");
   Console.ReadLine();
   
   if(number<10)
   {
       Console.WriteLine("Sayıya yaklaştınız.3 tahmin hakkınız kalmıştır. ");
   }
   else
   {
       Console.WriteLine("Sayıdan uzaklaştınız, daha küçük bir değer deneyiniz. 3 tahmin hakkınız kalmıştır. ");
   }
   
    }
    private static void Calculator()
    {
        Console.WriteLine(" Hesap Makinesi Uygulamasına Hoşgeldiniz! ");
        Console.WriteLine("Sayı Giriniz ");
        var numberInput1 = Console.ReadLine();
        var number1 = Convert.ToInt32(numberInput1);
        
        Console.WriteLine("Sayı Giriniz ");
        var numberInput2 = Console.ReadLine();
        var number2 = Convert.ToInt32(numberInput2);

        double sum = number1 + number2;
        double extraction = number1 - number2;
        double division = number1 / number2;
        var multiplication = number1 * number2;

        if (number2 == 0) 
        {
            Console.WriteLine("Geçerli bir sayı giriniz");
        }
        else
        {
            Console.WriteLine(number1/number2);
        }
        Console.WriteLine("Yapmak istediğiniz işlem nedir? ");

        double calculate = 4;
        switch (Calculator())
        {
            case sum:
            {
                Console.WriteLine(number1+number2);
            }
                
        }
        {
            
        }
    }
}