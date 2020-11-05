using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrszagasITMegmerettetes2020
{
    class Fordulo1
    {
        static public void Challange1A()
        {
            /// <summary>
            /// 1.Forduló 1. Feladat
            /// Mit ír ki az alábbi kódrészlet?
            /// </summary>

            Console.Write("1.Forduló 1.feladat eredménye: ");
                
            int x = 5;
            if (x > 0)
            {
                Console.Write('P');
            }
            if (x < 0)
            {
                Console.Write('N');
            }
            else
            {
                Console.Write('0');
            }

            Console.WriteLine();
        }

        static public void Challange1B()
        {
            /// <summary>
            /// 1.Forduló 2. Feladat
            /// Adott az alábbi kódrészlet. Azt szeretnénk elérni, hogy a kódban lévő törtszámot
            ///kerekítse a legközelebbi egész értékre(101).Válaszd ki a felsorolt lehetőségek közül
            ///az(oka)t, amellyel(amelyekkel) a ?? -et a kódban helyettesitve ez történik!
            ///
            /// K0
            /// N0
            /// F0
            /// P0
            /// 
            /// </summary>

            Console.WriteLine($"1.Forduló 2.feladat eredménye: N0 : { 100.62:n0}" + $", F0 : {100.62:f0}");
        }

        static public IEnumerable<int> Challange1C(int count = 5)
        {
            /// <summary>
            /// 1.Forduló 3. Feladat
            /// Mi lesz az alábbi függvény eredménye, ha paraméter megadása nélkül hívjuk meg?
            /// </summary>

            Console.Write($"1.Forduló 2.feladat eredménye: ");

            int pr = 1;
            int cr = 1;
            for (int i = 0; i < count; i++)
            {
                yield return pr;
                int t = pr + cr;
                pr = cr;
                cr = t;             
            }
        }
    }
}
