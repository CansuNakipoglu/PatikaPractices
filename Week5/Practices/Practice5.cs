using Week5.Practices.Abstracts;
using System;

namespace Week5.Practices;

/// <summary>
/// Try-Catch Pratiği
/// </summary>
public class Practice5 : IPractice
{
    public void ExecPractice()
    {
        while (true)
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");
                string girdi = Console.ReadLine();
                
                double sayi = Convert.ToDouble(girdi);
                
                double kare = sayi * sayi;
                Console.WriteLine($"Girilen sayının karesi: {kare}");
                break; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen bir hata oluştu: {ex.Message}");
            }
        }
    }
}