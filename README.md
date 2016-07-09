# N-Tier-Layer-Example

Facade Design Pattern kullanılarak oluşturulan basit WinForm uygulamasıdır.

MS SQL Server üzerinde NorthWind veri tabanı kullanılmıştır. [Şuradan](https://northwinddatabase.codeplex.com/releases/view/71634) indirilebilir.

Veri tabanı, UI (WinForm) ve ORM kısmı olarak 3'e ayrılmıştır. ORM ise kendi içinde Facade ve Entity olarak ikiye ayrılmıştır.

Yazarken aldığım notlar ve  kod ekran görüntüleri için [şurayı](https://medium.com/@learningzone/ntier-katmanl%C4%B1-mimari-7c8b2c649595#.vyg7q3qfw) inceleyebilirsiniz.

Yapılan işlemler
 * Select ( Listeleme )
 * Add ( Ekleme )
 * Delete (Silme )
 * Update (Güncelleme )
 
Yazılan stored procedure'ler için [-->](https://github.com/ZoneLearning/N-Tier-Layer-Example/blob/master/procedure_northwind.sql)
