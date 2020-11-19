using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrszagasITMegmerettetes2020
{
    class Fordulo4
    {
        static public void Challange4A()
        {
            /// <summary>
            /// 4.Forduló 1. Feladat
            /// Mit ír ki az alábbi látható kód a lefuttatása után?
            /// </summary>           

            var counter = 0;
            var list = new List<int> { 1, 2, 3, 4, 5 };

            var filteredList = list.Where(x =>
            {
                ++counter;
                return x == 2;
            });

            var s1 = filteredList.First();
            var s = counter;
            var s2 = ++counter;

            Console.WriteLine($"4.Forduló 1.feladat eredménye: {counter++}, { filteredList.First() + ++counter}");

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A Where csak a First() metódus futásakor aktiválódik, akkor a counter már 1, de 0-t ír ki a postfix operátor miatt.
            /// x-et kétszer növeljük a Where-ben, egyszer meg postfix módon, és 2t adunk hozzá, így lesz 6 a második érték.
            /// </summary> 
        }

        static public void Challange4B()
        {
            /// <summary>
            /// 4.Forduló 1. Feladat
            /// Mit ír ki az alábbi kód a lefuttatása után?
            /// </summary>           

            var counter = 0;
            var list = new List<int> { 1, 2, 3, 4, 5 };

            var filteredList = list.Where(x =>
            {
                ++counter;
                return x == 2;
            });

            Console.WriteLine($"4.Forduló 2.feladat eredménye: {counter++}, { filteredList.Count() + ++counter}");

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A Where csak a Count() metódus futásakor aktiválódik, akkor a counter már 1, de 0-t ír ki a postfix operátor miatt.
            /// x-et kétszer növeljük a Where-ben, egyszer meg postfix módon, és 5-öt adunk hozzá (a lista hossza), így lesz 8 a második érték.
            /// </summary> 
        }

        static public void Challange4Main()
        {
            /// <summary>
            /// 4.Forduló 1. Feladat
            /// Mit ír ki az alábbi program a konzolra?
            /// </summary>     
            ///

            var st = new Szamok();
            int szam = 9;
            ref var x = ref st.SzamKeres(szam);
            x *= 2;

            Console.WriteLine($"4.Forduló 3.feladat eredménye: {st}");

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// Az osztályban lévő függvény a paraméterként megadott számnál (itt 9) nagyobb vagy azzal egyenlő elemének referenciáját adja vissza.
            /// Ez az adott tömbben a 15, a referenciaként átadás miatt a tömbben lévő elemet duplázza meg, így lesz 30.
            /// </summary> 
        }
    }

    class Szamok
    {
        int[] num = { 1, 4, 8, 15, 31 };

        public ref int SzamKeres(int t)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= t)
                    return ref num[i];
            }
            return ref num[0];
        }

        public override string ToString() => string.Join(" ", num);

    }
}
