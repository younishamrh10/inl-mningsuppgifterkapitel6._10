using System;

namespace inlämningsuppgifterkapitel6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en sträng");
            string text = Console.ReadLine();
            Console.WriteLine("Hur hur många texter de är: " + AntalTalIText(text));
        }

        static int AntalTalIText(string text)
        {
            string[] delar = text.Split(' ');
            int antal = 0;

            for (int i = 0; i < delar.Length; i++)
            {
                double tal;
                if (double.TryParse(delar[i], out tal))
                {
                    antal++;
                }
            }
            return antal;
        }
    }
}