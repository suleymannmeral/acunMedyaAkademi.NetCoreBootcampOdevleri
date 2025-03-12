
using hafta5Odev4;

Employee[] calisanlar = new Employee[]
      {
            new Employee(40000,"Süleyman","Meral","Stajyer","IT"),
            new Employee(22000,"Beyza","Meral","Programcı","IT"),
            new Employee(100000,"Esma","Yağbakar","Genel Müdür","Eğitim"),
            new Employee(45000,"Ecrin","Kabil","Müdür","Yapı"),
            new Employee(90000,"Oğuzhan","Meral","Genel Müdür","Teknik"),
        
      };

double toplamMaas = 0;

for(int i=0; i<calisanlar.Length;i++)
{
    Console.WriteLine(calisanlar[i].Ad + " " + calisanlar[i].Soyad + " " + calisanlar[i].Meslek + " " + calisanlar[i].Departman);
    toplamMaas += calisanlar[i].Maas;

}
Console.WriteLine("Toplam Maas:" + toplamMaas);