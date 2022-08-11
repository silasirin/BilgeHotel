BILGE ADAM RESORT MVC PROJESI

1- Blank Solution acildi.

2- DAL adinda class library (.net framework) projesi olusturuldu.

3- DAL icerisinde Entity klasoru olusturuldu. Icerisinde tablo'lar yer aliyor. BaseEntity class'i acildi. Diger tum class'lar buradan kalitim aliyor (BLL'de CRUD islemlerini yapabilmek icin)

4- DAL icerisinde Enums klasoru olusturuldu. Icerisinde oda durumu var.

5- Entity Framework kurulumu yapildi.

6- DAL icerisinde Map klasoru olusturuldu. Tablolarin mapping islemleri burada yer aliyor.

7- DAL icerisinde Context klasoru olusturulup, ProjectContext class'i acildi.

8- enable-migrations yapildi.

9- Configuration.cs icerisine veri girisi yapildi.

10- update-database yapildi.

***Maas hesaplama ve toplam fiyat hesaplamalari calismiyor. Nasil yapilabilir??? ---- get set ile yapildi.

11- BLL adinda class library (.net framework) projesi olusturuldu. DAL projesinden referans alindi. Entity Framework kurulumu yapildi.

12- BLL katmani icerisinde Base ve Concrete olarak iki adet klasor olusturuldu. 

13- Base klasorunun icerisine BaseRepository ve IRepository olarak iki adet class acildi. 

  * IRepository icerisinde T tipinde tanimlanmis olarak CRUD islemleri methodlarýnýn govdeleri bulunuyor.

  * BaseRepository ise IRepository'den ve DAL katmanindaki BaseEntity class'indan kalitim aliyor. DAL katmanindan alinan BaseEntity class'i tum entity'lere kalitim veriyor. Bu class'lara erisim icin oradan kalitim alindi.  IRepository'den aldigi kalitim da CRUD islemlerini gerceklestirmek icin.

14- Concrete klasorunun icine de tum Entity'ler icin birer Concrete acildi. Bu Concrete'leri olusturulmasi, MVC katmaninda kullanilacak olan Model klasoru icerisindeki class'lar icin onemli. 

15- WinUI (windows form .net framework) katmani acildi. Burada kullanicilar kendi erisimlerine gore windows form uzerinden CRUD islemlerini gerceklestiriyor. DAL ve BLL katmanlarindan referans alindi.

16- WinUI'da kullanicilarin giris yapabilmesi icin LoginForm olusturuldu. 

17- Login Formdan giris yapanlar "calisan" ve "yonetim" olarak ikiye ayrildi. Yonetim olarak giris yapanlar tum crud islemlerini yapabilirken, calisan olarak giris yapanlar yalnizca listeleme islemlerini gerceklestirebilecek.

18- Musterilerin giris yapabilmesi icin ASPv.net web application (.net framework)) ile MVC tiklenerek, MVC katmani olusturuldu. Baslangic projesi olarak ayarlandi.

19- NuGet'tan bootstrapi jquery guncellemeleri yapildi.

20- MVC katmanina Entity Framework kuruldu, DAL ve BLL katmanlarindan referans verildi.

21- MVC katmaninda, müsterilerin login islemlerini gerceklestirebilmeleri icin Models klasoru icerisinde UserVM adinda bir class olusturuldu. Burada email ve sifre bilgileri bulunuyor. Ayný sekilde LoginUserVm class'i da login islemleri icin kullaniliyor.

22- Kullanicinin rezervasyon yaptirdiktan sonra ayirttigi oda bilgilerine ve fiyatina ulasabilmesi icin Models klasoru icerisinde CartItemVM adinda bir class olusturuldu.

23- Cart'a rezervasyon bilgileri eklenirken kullanilmasi icin CartVM class'i olusturuldu.

24- HomeController icerisinde musteri girisi icin Index, MyCart, Register, Login, Pending, About, Contact Action'lari olusturuldu. Bu action'larin View'lari acildi.

25- About, Contact, Register ve login sayfalari tamamlandi.

26- Index ve MyCart haricinde proje tamamlandi.

**Index'te oda secilebiliyor. Ancak tatil paketi secilemiyor. MayCart'a atmiyor.
***Tarih secimi yapilamiyor.

27- 