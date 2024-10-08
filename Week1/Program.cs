﻿using Week1.Practices;
using Week1.Practices.Abstracts;

IPractice practice = null;

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
        case "5": practice = new Practice5();
            break;
        case "6": practice = new Practice6();
            break;
        case "7": practice = new Practice7();
            break;
        case "8": practice = new Practice8();
            break;
        case "9": practice = new Practice9();
            break;
        default: Console.WriteLine("Lütfen Geçerli Bir Uygulama Numarası Giriniz");
            return;
    }    
}

practice.ExecPractice();
