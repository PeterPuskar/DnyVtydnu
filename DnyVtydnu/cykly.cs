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
            int hodnotovy = 6;


        }
    }
}
    // zvysok po deleni cislom %2 napriklad zvysok po deleni dvomi
        
