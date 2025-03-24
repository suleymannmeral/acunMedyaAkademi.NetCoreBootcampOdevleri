using acunMedyaGenericListOdevi;
Car bmw = new Car();
bmw.Marka = "BMW";
bmw.Model = "X5";
bmw.BenzinHarcamasi = 9;
bmw.ToplamMesafe = 100;
Car mercedes = new Car();
mercedes.Marka = "Mercedes";
mercedes.Model = "C200";
mercedes.BenzinHarcamasi = 8.2;
mercedes.ToplamMesafe = 100;
Car toyota = new Car();
toyota.Marka = "Toyota";
toyota.Model = "Corolla";
toyota.BenzinHarcamasi = 6.5;
toyota.ToplamMesafe = 100;
List<Car> cars = new List<Car>();

cars.Add(bmw);
cars.Add(mercedes);
cars.Add(toyota);

foreach(var item in cars)
{
  
    Console.WriteLine("Marka: " + item.Marka + ", Model: " + item.Model + ", 100KM'de Yaktığı Yakıt: " + item.BenzinHarcamasi + " Toplam Yakıt Tüketimi: " + item.YakitTuketimi((double)item.BenzinHarcamasi, (double)item.ToplamMesafe)); ;
}