using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrszagasITMegmerettetes2020
{
    class Fordulo6
    {
            /// <summary>
            /// 6.Forduló 1. Feladat
            /// Az alábbi szervizen meghívják 5 alkalommal a Counter API-t GET metódussal. Sorold fel vesszővel elválasztva, szóköz nélkül,
            /// hogy milyen 5db visszatérési érték keletkezik?
            /// (Az AddMyService beregisztrálásra került a program indulásakor.)
            /// </summary>     
            ///
            //public class CounterService
            //{
            //    private ulong _counter;
            //    public ulong Counter { get => ++_counter; }
            //}

            //public static class Wireup
            //{
            //    public static IServiceCollection AddMyService(this IServiceCollection s)
            //    {
            //        return s.AddScoped<CounterService>();
            //    }
            //}

            //[ApiController]
            //[Route("controller")]
            //public class CounterController : ControllerBase
            //{

            //    private readonly CounterService _counterService;
            //    public CounterController(CounterService counterService)
            //    {
            //        _counterService = counterService;
            //    }

            //    [HttpGet]
            //    public IActionResult Get()
            //    {
            //        return Ok(_counterService.Counter);
            //}

            public Fordulo6()
            {
                Console.WriteLine("6.Forduló 1.feladat eredménye: 1,1,1,1,1");
            }
        
            /// <summary>
            /// Magyarázat a megoldáshoz
            /// A Scoped regisztrálás miatt minden futtatás alkalmával új példány jön létra a szervizből,
            /// ezért a _counter értéke mindig 1 lesz.
            /// </summary> 
       

        public static async void Challange6B()
        {
            /// <summary>
            /// 6.Forduló 2. Feladat
            /// Hány olyan különböző socket lesz maximum egyazon időben, amelyek a kapcsolatnak bármelyik oldalán nyitva maradnak 
            /// az alábbi program futása során egy 4 magos processzorral rendelkező számítógépen?
            /// </summary>     
            ///

            //Parallel.For(0, 10, async (p) =>{

            //    using var client = new HttpClient();
            //    System.Console.WriteLine((await client.GetAsync("https://dxc.technology")).StatusCode);
            //});

            Console.Write("6.Forduló 2.feladat eredménye: 10");

            /// <summary>
            /// Magyarázat a megoldáshoz
            /// Bár a using-ból egyszerre legfeljebb négy darab fut a Parallel.For miatt, azonban a HttpClient nem zárja be rögtön a socketet,
            /// alapesetben még percig nyitva maradnak.
            /// </summary> 
        }
    }
}
