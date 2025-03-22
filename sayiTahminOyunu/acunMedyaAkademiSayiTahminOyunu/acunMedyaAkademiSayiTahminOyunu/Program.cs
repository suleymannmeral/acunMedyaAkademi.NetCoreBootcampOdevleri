Random random = new Random();
int rastgeleSayi = random.Next(1, 101);
int tahmin;
int tahminSayisi = 0;

Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin!");

do
{
    Console.Write("Tahmininizi girin: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out tahmin))
    {
        Console.WriteLine("Lütfen geçerli bir sayı girin!");
        continue;
    }

    tahminSayisi++;

    if (tahmin < rastgeleSayi)
    {
        Console.WriteLine("Daha büyük bir sayı girin!");
    }
    else if (tahmin > rastgeleSayi)
    {
        Console.WriteLine("Daha küçük bir sayı girin!");
    }
    else
    {
        Console.WriteLine($"Tebrikler {tahminSayisi} tahminde doğru sayıyı buldunuz");
        break;
    }
} while (true);