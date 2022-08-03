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

12- WinUI (windows form .net framework) katmani acildi. Burada kullanicilar kendi erisimlerine gore windows form uzerinden CRUD islemlerini gerceklestiriyor. DAL ve BLL katmanlarindan referans alindi.

13- WinUI'da kullanicilarin giris yapabilmesi icin LoginForm olusturuldu. 

14- Login Formdan giris yapanlar "calisan" ve "yonetim" olarak ikiye ayrildi. Yonetim olarak giris yapanlar tum crud islemlerini yapabilirken, calisan olarak giris yapanlar yalnizca listeleme islemlerini gerceklestirebilecek.

15- Musterilerin giris yapabilmesi icin ASPv.net web application (.net framework)) ile MVC tiklenerek, MVC katmani olusturuldu. Baslangic projesi olarak ayarlandi.

16- NuGet'tan bootstrapi jquery guncellemeleri yapildi.

17- MVC katmanina Entity Framework kuruldu, DAL ve BLL katmanlarindan referans verildi.

18- 