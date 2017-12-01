using System;

namespace DnyVtydnu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Cykly.CyklusWhile();
            //Cykly.DoWhile();
            //Cykly.CyklusFor();

            Cykly.HodnotVsReference();

            Auto autoPuvodni = new Auto();
            autoPuvodni.Barva = "cerna";

            Cykly.PrebarviAuto(autoPuvodni);

            Console.WriteLine(autoPuvodni.Barva);




            Console.ReadLine();

        }
    }
}
