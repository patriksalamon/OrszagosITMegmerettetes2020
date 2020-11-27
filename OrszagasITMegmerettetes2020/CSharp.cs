using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrszagasITMegmerettetes2020
{
    class CSharp
    {
        static void Main(string[] args)
        {
            Fordulo1.Challange1A();
            Fordulo1.Challange1B();

            foreach (var item in Fordulo1.Challange1C())
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Fordulo2.Challange2A();
            Fordulo2.Challange2B("schluss", 101);

            Fordulo3.Challange3A();
            Fordulo3.Challange3B();

            Fordulo4.Challange4A();
            Fordulo4.Challange4B();
            Fordulo4.Challange4Main();

            Console.WriteLine("5.Forduló 1.feladat eredménye: 4mp-ig fut");
            Fordulo5.Challange5B();
            Console.WriteLine(Fordulo5.Challange5C());

            Console.ReadLine();
        }
    }
}
