using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace OrszagasITMegmerettetes2020
{
    class Fordulo5
    {   
        [Fact(Timeout = 4000)]
        public async static Task Challange5A()
        {
            /// <summary>
            /// 5.Forduló 1. Feladat
            /// Mennyi ideig fut az alábbi kódrészlet (XUnit-ból futtatva)?
            /// </summary>     
            ///

            var ct = new CancellationTokenSource(TimeSpan.FromSeconds(2)).Token;

            var t = new List<int>();
            await Task.Run(() =>
            {
                while (true)
                {
                    Task.Delay(300);
                }
            }, ct);

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A CancellationToken nem szakítja meg a futást 2 másodperc után, úgyhogy a Fact opciójában megadott 4000ms, azaz 4mp után lövi le a futást. 
            /// </summary> 
        }

        public async static Task Challange5B()
        {
            /// <summary>
            /// 5.Forduló 2. Feladat
            /// Add meg vesszővel elválasztva, szóköz nélkül, hogy milyen számok találhatóak sorrendben a t listában az alábbi kód futásának végén!
            /// </summary>     
            ///

            var are = new AutoResetEvent(true);
            var t = new List<int>();
            var t1 = Task.Run(() =>
            {
                while (t.Count < 3)
                {
                    are.WaitOne();
                    t.Add(t.Count());
                    are.Set();
                }
            });

            var t2 = Task.Run(() =>
            {
                while (t.Count < 5)
                {
                    are.WaitOne();
                    t.Add(t.Count());
                    are.Set();
                }
            });

            Task.WaitAll(t1, t2);

            Console.Write("5.Forduló 2.feladat eredménye: "); 

            t.ForEach((x) =>
            {
                Console.Write(x + ",");
            });

            Console.WriteLine();

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A két taszk egymást blokkolja, amíg az egyik véget nem ér, és mindkettő a tömb aktuális hosszát teszi a listába (0-tól kezdve),
            /// így eggyel növeli minden lépésben annak hosszát. 
            /// </summary> 
        }

        public static string Challange5C()
        {
            /// <summary>
            /// 5.Forduló 3. Feladat
            /// Az alábbiak közül mely(ek) NEM lehet(nek) az alábbi függvény eredménye(i)?
            /// </summary>     
            ///

            Random r = new Random();
            string res = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < r.Next(2,4); j++)
                {
                    res += r.Next(100) < 80 ? r.Next(10).ToString() : ((char)('A' + r.Next(26))).ToString();
                }
                res += i != 2 ? "-" : "";
            }

            //return res;

            return "5.Forduló 3.feladat eredménye: 93A-ABF6-D9, AB-CDE-EFG-H1, R2-D2, A8-7[A-A9 ";

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A függvény x-y-z alakú kifejezést állít elő, ahol x, y, z is 2 vagy 3 darab számjegyből vagy az angol ábécé nagybetűjéből áll. 
            /// "93A-ABF6-D9": ebben van egy 4 hosszú csoport, "AB-CDE-EFG-H1": ez  négy részből áll, "R2-D2": ez csak két részből,
            ///  "A8-7[A-A9": ebben pedig a '[' nem jöhet ki, ezért egyik sem lehetséges.
            /// </summary> 
        }
    }
}
