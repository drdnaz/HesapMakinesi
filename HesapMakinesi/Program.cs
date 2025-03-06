// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk sayıyı giriniz: ");
        double a = Convert.ToDouble(Console.ReadLine()); // Konsol ekranına girilen değeri "a" değişkenine atayan kod

        Console.Write("İkinci sayıyı giriniz: ");
        double b = Convert.ToDouble(Console.ReadLine()); // Konsol ekranına girilen değeri "b" değişkenine atayan kod

        Console.Write("İşlem numarası giriniz (1: Toplama, 2: Çıkarma, 3: Çarpma, 4: Bölme): ");
        int islem = Convert.ToInt32(Console.ReadLine()); // Konsol ekranına girilen değeri "islem" değişkenine atayan kod

        if (islem == 1)
        {
            Toplama(a, b);
        }
        else if (islem == 2)
        {
            Cikarma(a, b);
        }
        else if (islem == 3)
        {
            Carpma(a, b);
        }
        else if (islem == 4)
        {
            Bolme(a, b);
        }
        else
        {
            Console.WriteLine("Geçersiz işlem numarası");
        }
    }
    static void Toplama(double a, double b)
    {
        Console.WriteLine("Toplama işlemi yapılıyor...");
        double sonuc = a + b;
        Console.WriteLine("İşlem sonucu: " + sonuc);
    }
    static void Cikarma(double a, double b)
    {
        Console.WriteLine("Çıkarma işlemi yapılıyor...");
        double sonuc = a - b;
        Console.WriteLine("İşlem sonucu: " + sonuc);
    }
    static void Carpma(double a, double b)
    {
        Console.WriteLine("Çarpma işlemi yapılıyor...");
        double sonuc = a * b;
        Console.WriteLine("İşlem sonucu: " + sonuc);
    }
    static void Bolme(double a, double b)
    {
        Console.WriteLine("Bölme işlemi yapılıyor...");
        if (b != 0)
        {
            double sonuc = a / b;
            Console.WriteLine("İşlem sonucu: " + sonuc);
        }
        else
        {
            Console.WriteLine("Hata: Bir sayı 0'a bölünemez!");
        }
    }
}
