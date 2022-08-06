namespace _20_Odev_AsalSayıToplam
{
    internal class Program
    {
        static bool AsalMı(int sayi)
        {
            bool sonuc = true;
            for (int i = 2; i < sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    sonuc = false;
                    break;
                }
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            int toplam = 0;
            for (int i = 2; i <= 1000; i++)
            {
                if (AsalMı(i))
                {
                    toplam += i;
                }
            }
            Console.WriteLine(toplam);
        }
}