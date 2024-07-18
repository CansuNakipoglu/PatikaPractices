using Week1.Practices;
using Week1.Practices.Abscracts;

IPractice practice = new Practice4();

if (practice == null)
{
    Console.Write("Lütfen Çalıştırmak İstediğiniz Uygulamanın Numarasını Giriniz: ");
    var selection = Console.ReadLine();
    
    switch (selection)
    {
        case "1": practice = new Practice1();
            break;
        case "2": practice = new Practice2();
            break;
        case "3": practice = new Practice3();
            break;
        case "4": practice = new Practice4();
            break;
        default: Console.WriteLine("Lütfen Geçerli Bir Uygulama Numarası Giriniz");
            return;
    }    
}

practice.ExecPractice();
