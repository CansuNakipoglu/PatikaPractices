using Week1;

Console.Write("Lütfen Çalıştırmak İstediğiniz Uygulamanın Numarasını Giriniz: ");
var selection = Console.ReadLine();

switch (selection)
{
    case "1": Practice1.ExecPractice();
        break;
    default: Console.WriteLine("Lütfen Geçerli Bir Uygulama Numarası Giriniz");
        break;
}