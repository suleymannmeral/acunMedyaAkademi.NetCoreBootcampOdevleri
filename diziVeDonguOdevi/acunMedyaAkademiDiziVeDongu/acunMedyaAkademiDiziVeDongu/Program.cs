int[] sayilar = new int[5];
int toplam = 0;

Console.WriteLine("Lütfen 5 sayı girin:");

for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"Sayı {i + 1}: ");
    while (!int.TryParse(Console.ReadLine(), out sayilar[i])) 
    {
        Console.Write("Geçerli bir sayı girin: ");
    }
}

foreach (int sayi in sayilar)
{
    toplam += sayi;
}

double ortalama = (double)toplam / sayilar.Length;


Console.WriteLine($"Toplam: {toplam}");
Console.WriteLine($"Ortalama: {ortalama:F2}");