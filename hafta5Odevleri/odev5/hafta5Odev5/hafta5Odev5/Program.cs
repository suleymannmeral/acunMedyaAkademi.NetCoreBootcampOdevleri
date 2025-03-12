using hafta5Odev5;


Araba[] arabalar = new Araba[]
        {
            new Araba("Ford",150), 
            new Araba("BMW",200), 
            new Araba("Audi",300), 
            new Araba("Porshce",2500), 
            new Araba("Porshce",2500), 

        };

int toplamBenzin = 0;

foreach(var item in arabalar)
{
    toplamBenzin += item.Benzin;
}

Console.WriteLine(toplamBenzin);