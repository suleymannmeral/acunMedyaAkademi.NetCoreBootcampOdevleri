Console.Write("Birinci sayıyı girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi seçin: (+, -, *, /)");
char islem = Convert.ToChar(Console.ReadLine());

double sonuc = 0;

switch (islem)
{
    case '+':
        sonuc = sayi1 + sayi2;
        Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        break;
    case '-':
        sonuc = sayi1 - sayi2;
        Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        break;
    case '*':
        sonuc = sayi1 * sayi2;
        Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
        break;
    case '/':
        if (sayi2 != 0)
        {
            sonuc = (double)sayi1 / sayi2;
            Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc:F2}");
        }
        else
        {
            Console.WriteLine("Hata: Bir sayı 0'a bölünemez");
        }
        break;
    default:
        Console.WriteLine("Geçersiz işlem! Lütfen +, -, * veya / girin.");
        break;
}