using System;
using System.Collections.Generic;
using System.Text;

namespace DnyVtydnu
{
    class Cykly
    {
        public static void CyklusWhile()
        {
            int i = 0;

            while (i < 4)
            {
                i++;
                Console.WriteLine("Ahoj");


            }
        }
        public static void DoWhile()
        {
            int i = 0;

            do
            {
                ++i;
                Console.WriteLine(i);

            } while (i < 4);
        }
        public static void CyklusFor()
        {
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void CyklusFor2()
        {
            for (int i = 0, j = 10; i <= j; i++, j++)
            {
                Console.WriteLine("dvojice {0}, {1}", i, j);

            }

        }
        public static void Opakovanie(int pocet)
        {
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine(i);

                if (i == 7) break;
            }
        }

        public static void HodnotVsReference()
        {
            int hodnota1 = 6;
            int hodnota2;

            hodnota2 = hodnota1;

            hodnota2++;
            Console.WriteLine(hodnota1);
            Console.WriteLine(hodnota2);

            Auto auto1 = new Auto();
            auto1.Barva = "cervena";
            Auto auto2 = auto1;
            auto2.Barva = "cerna";

            Console.WriteLine(auto1.Barva);
            Console.WriteLine(auto2.Barva);

        }

        public static void PrebarviAuto(Auto auto)
        {
            auto.Barva = "bila";
        }
            
    }
}
    // zvysok po deleni cislom %2 napriklad zvysok po deleni dvomi
        
