using System.Runtime.ConstrainedExecution;

namespace MyNamespace.MathOperations
{
    public class Hesaplama
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

namespace MyNamespace.Test
{
    using MyNamespace.MathOperations; 

    class Program
    {
        static void Main()
        {
            Hesaplama hesap = new Hesaplama();

            int toplamSonuc = hesap.Topla(10, 5);
            int carpimSonuc = hesap.Carp(4, 3);

            Console.WriteLine($"Toplama Sonucu: {toplamSonuc}");
            Console.WriteLine($"Çarpma Sonucu: {carpimSonuc}");
        }
    }
}
// Namespace, C#’ta sınıfları, arayüzleri, metodları ve diğer kod bileşenlerini organize etmek ve isim çakışmalarını önlemek için kullanılan bir yapıdır.

// Projede farklı namespace’ler kullanmak birçok avantaj sağlar:  Kodun Organize Edilmesini Sağlar -  Genişletilebilirliği ve Bakımı Kolaylaştırır

// Genişletilebilirlik, bir yazılımın zamanla yeni özellikler eklenerek veya mevcut özellikleri değiştirilerek geliştirilebilmesi anlamına gelir.
//Örneğin, bir e-ticaret sitesi için sipariş sistemi geliştirildiğinde, ilerleyen süreçte yeni ödeme yöntemleri eklemek istenebilir. Eğer sistem genişletilebilir şekilde tasarlandıysa kolayca yeni ödeme yöntemleri eklenebilir.
// bunun için solid uygulayabiliriz