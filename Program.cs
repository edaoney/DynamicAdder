Console.WriteLine("Hesap Makinesi");

Console.Write("Kaç sayı toplamak istiyorsunuz: ");
int adet = int.Parse(Console.ReadLine());

int toplam = 0;

for (int i = 0; i < adet; i++)
{
    toplam += int.Parse(Console.ReadLine());
    
}
Console.WriteLine($"Girilen sayıların toplamı: {toplam}");