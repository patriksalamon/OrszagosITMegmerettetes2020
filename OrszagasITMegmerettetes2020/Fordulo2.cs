using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrszagasITMegmerettetes2020
{
    class Fordulo2
    {
        static public void Challange2A()
        {
            /// <summary>
            /// 2.Forduló 1. Feladat
            /// Mi lesz az s változó értéke az alábbi metódus futásának végén? A választ vesszővel elválasztva,
            /// csupa nagybetűvel, szóköz nélkül kell megadni! pl.AB,CD,EF,GH
            /// </summary>           

            string s = "CQ,CQ,CQ,DE,HA3DM,K";
            s.Replace(",", " ");
            var sl = s.Split(',').ToList();
            sl.RemoveAll(ss => ss.Substring(0, 1)
            .Equals("c", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("2.Forduló 1.feladat eredménye: " + s);
        }

        static public int Challange2B(string key, int value)
        {
            /// <summary>
            /// 2.Forduló 2. Feladat
            /// Adott az alábbi metódus:
            /// Mi lesz a visszatérési érték az alábbi hívás eredményeképpen? A választ számjegyként add meg!
            /// int sum = Challange2B("schluss",101);
            /// </summary>

            value /= 2;
            var x = new bool[]
            {
                key == "schluß",
                key.Equals("schluß"),
                key.Equals("schluß", StringComparison.Ordinal),
                key.Equals("Schluß", StringComparison.CurrentCulture),
                key.Equals("schluß", StringComparison.OrdinalIgnoreCase),
                key.Equals("schluß", StringComparison.CurrentCulture),
                key.Equals("Schluß", StringComparison.CurrentCultureIgnoreCase),
                value != 50
            };

            int sum = x.Sum(a => a ? 1 : 0);

            Console.WriteLine("2.Forduló 2.feladat eredménye: " + sum);
            return sum;
        }
    }
}
