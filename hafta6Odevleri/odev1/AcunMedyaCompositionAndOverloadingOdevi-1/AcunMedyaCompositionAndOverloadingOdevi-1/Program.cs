using AcunMedyaCompositionAndOverloadingOdevi_1;


Marka bmw = new Marka("BMW");
Kasa sedan = new Kasa("sedan");
Kapi kapilar = new Kapi(4);
Pencere pencereler = new Pencere(4);

Araba araba = new Araba(bmw,  kapilar, sedan, pencereler,"X5", 2000000);

araba.BilgileriYazdır();