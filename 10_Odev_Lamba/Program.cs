namespace _10_Odev_Lamba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool lamb1 = true, lamb2 = true, lamb3 = true;
            if (lamb1)
            {
                if (lamb2 && lamb3)
                {
                    Console.WriteLine("tüm lambalar açık");
                }
                else if (!lamb2 && !lamb3)
                {
                    Console.WriteLine("yalnız bir lamba açık");
                }
                else
                {
                    Console.WriteLine("2 lamba açık");
                }
            }
            else if (lamb2)
            {
                if (lamb1 && lamb3)
                {
                    Console.WriteLine("tüm lambalar açık");
                }
                else if (!lamb1 && !lamb3)
                {
                    Console.WriteLine("yalnız bir lamba acık");
                }
                else
                {
                    Console.WriteLine("2 lamba açık");
                }
            }
            else if (lamb3)
            {
                if (lamb1 && lamb2)
                {
                    Console.WriteLine("tüm lambalar açık");
                }
                else if (!lamb1 && !lamb2)
                {
                    Console.WriteLine("yalnız bir lamba acık");
                }
                else
                {
                    Console.WriteLine("2 lamba açık");
                }
            }
            else
            {
                Console.WriteLine("tüm lambalar kapalı");
            }
        }
    }
}