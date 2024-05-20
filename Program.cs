using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkKonzolna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NizZivotinja();
            Console.ReadLine();
        }
        static void NizZivotinja()
        {
           
            int brojZivotinja1 = UnesiBrojZivotinja("prvi");
            string[] niz1 = UnesiNizZivotinja(brojZivotinja1, "prvi");

            int brojZivotinja2 = UnesiBrojZivotinja("drugi");
            string[] niz2 = UnesiNizZivotinja(brojZivotinja2, "drugi");

            Console.WriteLine("\nZajedničke životinje u oba niza su:");
            foreach (string zivotinja1 in niz1)
            {
                foreach (string zivotinja2 in niz2)
                {
                    if (zivotinja1 == zivotinja2)
                    {
                        Console.WriteLine(zivotinja1);
                    }
                }
            }
        }
        static int UnesiBrojZivotinja(string nazivNiza)
        {
            int brojZivotinja = 0;
            while (true)
            {
                Console.Write($"Unesite broj životinja za {nazivNiza} niz: ");
                string unos = Console.ReadLine();

                if (int.TryParse(unos, out brojZivotinja) && brojZivotinja > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Molimo unesite važeći broj.");
                }
            }
            return brojZivotinja;
        }

        static string[] UnesiNizZivotinja(int brojZivotinja, string nazivNiza)
        {
            string[] niz = new string[brojZivotinja];
            for (int i = 0; i < brojZivotinja; i++)
            {
                Console.Write($"Unesite životinju {i + 1} za {nazivNiza} niz: ");
                niz[i] = Console.ReadLine();
            }
            return niz;
        }
    }
}
