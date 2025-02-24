
using acunMedyaAkademiOdev_1_inheritance.Classes;

Audi audi = new Audi();             //classlardan obje türetiyoruz. bu objeler örneğin(audi) türetilen classın özelliklerini taşır 
Bmw bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();
Togg togg = new Togg();
Toyota toyota = new Toyota();

audi.Brand = "Audi";            
audi.Transmission = "Automatic";

bmw.Brand = "Bmw";
bmw.Transmission = "Manual";

mercedes.Brand = "Mercedes";
mercedes.Transmission = "Automatic";

porsche.Brand = "Porsche";
porsche.Transmission = "Automatic";

togg.Brand = "Togg";
togg.Transmission = "Automatic";

toyota.Brand = "Toyota";
toyota.Transmission = "Manual";


audi.Print(audi.Brand,audi.Transmission);
bmw.Print(bmw.Brand,bmw.Transmission);
mercedes.Print(mercedes.Brand,mercedes.Transmission);
porsche.Print(porsche.Brand,porsche.Transmission);
togg.Print(togg.Brand,togg.Transmission);
toyota.Print(toyota.Brand,toyota.Transmission);