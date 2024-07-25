Projeyi çalıştırdığınızda konsoldan çalıştırılacak uygulama numarasını girmeniz yeterli olacaktır. (Uygulama Numaraları aşağıda verilmiştir)  

Development mod'da uygulamaları hızlı bir şekilde çalıştırabilmek için program.cs de ki satırı aşağıda ki gibi değiştrebilirsiniz.  
Örnek:  
IPractice practice = null; -> IPractice practice = new Practice1();  

Detay: Proeje mimarisinde hızlı ve düzenli olabilmesi adına soyut sınıflardan yararlanılmıştır. Tüm practiceler IPractice sınıfından türetilmiştir bu sayede polyfphormisim uygulanıp rahat bir şekilte tüm sınıfların çalıştırılması sağlanmıştır. Konu gidişatı ile bağımsız tamamen projenin daha akıcı bir şekilde ilerlemesi için bu şekilde bir yapı oluşturuldu.

Uygulama Numaraları:

WEEK 1  
  1 - HelloWorld  
  2 - Değişken Tanımlama Ve Atama İşlemleri  
  3 - Casting İşlemleri  
  4 - Operatörler Pratiği  
  5 - Console Komutları Pratiği  
  6 - Değişkenler ile uygulama pratiği  
  7 - If Else Pratiği  
  8 - Switch Case Yapısı  
  9 - Kim Milyoner OLmak İster Pratiği  

WEEK 2  
  1 - For Döngüsü Uygulamaları  
  2 - While Döngüsü Pratiği  
  3 - While vs Do-While Pratiği  
  4 - Yol Arkadaşı : Tatil uygulaması
