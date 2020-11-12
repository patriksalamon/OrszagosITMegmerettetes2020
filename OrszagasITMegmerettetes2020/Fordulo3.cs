using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrszagasITMegmerettetes2020
{
    class Fordulo3
    {
        static public void Challange3A()
        {
            /// <summary>
            /// 3.Forduló 1. Feladat
            /// Milyen színű lesz a p1-es toll az alábbi kód futásának végére?
            /// </summary>           

            System.Drawing.Point pt1 = new System.Drawing.Point(20, 30);
            System.Drawing.Point pt2 = pt1;

            pt2.X += pt2.Y;

            System.Drawing.Pen p1 = new System.Drawing.Pen(System.Drawing.Color.AliceBlue);
            System.Drawing.Pen p2 = p1;
            p2.Color = System.Drawing.Color.FromArgb(pt1.X, pt2.Y, pt1.Y + pt2.X);

            Console.WriteLine("3.Forduló 1.feladat eredménye: " + p2.Color.ToString());

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// pt1 = 20,30; pt2 = 50,30 lesz. A Pen viszont objektum, ezért referencia típusú, így a p2 változtatása p1-et is változtatja.
            /// </summary> 
        }

        static public void Challange3B()
        {
            /// <summary>
            /// 3.Forduló 2. Feladat
            /// Sorold fel a v tömb elemeit az alábbi metódus futása után, vesszővel elválasztva szóköz nélkül! pl:1,2,3,4
            /// </summary>           

            int[] v = new int[5];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = i + 1;
            }
            for (int i = 0; i < v.Length; i++)
            {
                try
                {
                    //v[i] *= v[^î];
                    v[i] *= v[v.Length - i];
                }
                catch (Exception)
                {

                    v[i] = 0;
                }
            }

            Console.WriteLine("3.Forduló 2.feladat eredménye: 0,10,12,48,50");

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A v tartalma kezdetben: {1, 2, 3, 4, 5 }. A v[^] a C# 8.0-ban v[v.Length-i], ami i = 0 esetén IndexOutOfRangeException-t dob,a mit elkapunk, agy v[0] = 0. 
            /// Majd v[1] = 2 * 5 = 10, v[2] = 3 * 4 = 12, v[3] = 4 * 12 = 48, v[4] = 5 * 10 = 50.
            /// </summary> 
        }
    }
}
