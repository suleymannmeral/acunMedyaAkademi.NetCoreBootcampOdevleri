using AcunmedyaAkademiHafta4Odev3;

Bmw bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();

int totalFuel = 0;

 totalFuel += bmw.CalculateFuelConsumption();
 totalFuel += mercedes.CalculateFuelConsumption();
 totalFuel += porsche.CalculateFuelConsumption();
Console.WriteLine("Total Fuel Consumption is :  "+totalFuel);