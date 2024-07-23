using System.ComponentModel.Design;
using Week1.Practices.Abstracts;

namespace Week1.Practices;
/// <summary>
/// 
/// </summary>
public class Practice7 :IPractice
{
    public void ExecPractice()
    {
       Console.WriteLine("Lütfen bir sayı giriniz.");
       string number = Console.ReadLine();
       
       bool isSuccess = int.TryParse(number, out int intNumber);

       if (!isSuccess)
       {
           Console.WriteLine("Hatalı giriş yaptınız, lütfen sayısal ifade giriş yapınız. ");
           return;
       }
       if (intNumber < 10) 
       {
           Console.WriteLine(" Sayı 10'dan küçüktür. ");
       }
       else if (intNumber == 10)
       {
           Console.WriteLine(" Girilen sayı 10'a eşittir. "); 
       }
       else
       { 
           Console.WriteLine(" Girilen sayi 10'dan büyüktür. "); 
       }

       if (intNumber % 2 == 0)
       {
           Console.WriteLine(" Girilen sayı çifttir. ");
       }
       else if (intNumber %2!= 0)
       {
           Console.WriteLine(" Girilen sayı tektir. ");
       }
    } 
}