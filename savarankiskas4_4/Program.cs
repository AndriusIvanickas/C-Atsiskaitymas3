using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace savarankiskas4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> Vardai = new List<string>() { "Tomas", "Benas", "Leja" };
            Kates kate1 = new Kates("Tomas", "Bengalijos", "vyras", 5, 10);
            Kates kate2 = new Kates("Benas", "Bombejaus", "vyras", 10, 15);
            Kates kate3 = new Kates("Leja", "Brazilijos", "moteris", 7, 10);
            List<Kates> katinai = new List<Kates>();

            katinai.Add(kate1);
            katinai.Add(kate2);
            katinai.Add(kate3);
            SpausdintiKatinus();
            PrintList(katinai);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("2 UZD");
            Console.Write("Kuri irasa pasalinti: ");
            string salinimas = Console.ReadLine();
            Console.WriteLine();
            Trinimas(katinai, salinimas);
            PrintList(katinai);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("3 UZD");
            Console.Write("Ieskoma: ");
            string paieska = Console.ReadLine();
            Console.WriteLine($"Tokiu yra: {Paieska(katinai, paieska)}");

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("4 UZD");
            Console.WriteLine($"vidutinis svoris: {VidutinisSvoris(katinai)}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("5 UZD");
            katinai.Sort((x, y) => y.KatesSvoris.CompareTo(x.KatesSvoris));
            PrintList(katinai);
            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.ReadKey();




        }
        static void PrintList(List<Kates> katinai)
        {
            Console.WriteLine("| Vardas |     Veisle     | Lytis | Metai | Svoris |");
            for (int i = 0; i < katinai.Count; i++)
            {
                Console.WriteLine(katinai[i]);
            }
        }

        static void Trinimas(List<Kates> katinai, string salinimas)
        {

            int num = 0;
            for (int i = 0; i < katinai.Count; i++)
            {
                
                if (katinai[i].KatesVardas == salinimas)
                {
                    katinai.RemoveAt(i);

                    num++;
                   
                }
                
                
                


            }
            if (num == 0)
            {
                Console.WriteLine("Tokio iraso nera");
            }
        }
        static double VidutinisSvoris(List<Kates> katinai)
        {

            double svoris = 0;
            int kiekis = 0;
            for (int i = 0; i < katinai.Count; i++)
            {
                svoris = svoris + katinai[i].KatesSvoris;
                kiekis++;
            }
            return Math.Round( (svoris / kiekis),2);
        }
        static int Paieska(List<Kates> katinai, string paieska)
        {
            int kiekis = katinai.Count(elem => elem.KatesVardas.Equals(paieska));
            return kiekis;
        }
        static public void SpausdintiKatinus()
        {
            
        }
    }
}


