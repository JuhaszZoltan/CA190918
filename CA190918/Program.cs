using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190918
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            //Console.Write("itányítószám: ");
            //int isz = int.Parse(Console.ReadLine());
            //Console.Write("város: ");
            //string v = Console.ReadLine();
            //Console.Write("közt. neve: ");
            //string kn = Console.ReadLine();
            //Console.Write("közt. jellege: ");
            //string kj = Console.ReadLine();
            //Console.Write("házszám: ");
            //string hsz = Console.ReadLine();
            //Console.WriteLine("---------------");
            ////Console.WriteLine(isz + ' ' + v + ' ' + kn + ' ' + kj + ' ' + hsz + '.');
            ////Console.WriteLine("{0} {1} {2} {3} {4}.", isz, v, kn, kj, hsz);
            //Console.WriteLine($"{isz} {v} {kn} {kj} {hsz}.");
            #endregion
            #region 2. feladat
            //Console.Write("1. vezetéknév: ");
            //string v1 = Console.ReadLine();
            //Console.Write("2. vezetéknév: ");
            //string v2 = Console.ReadLine();
            //Console.Write("1. keresztnév: ");
            //string k1 = Console.ReadLine();
            //Console.Write("2. keresztnév: ");
            //string k2 = Console.ReadLine();
            //Console.WriteLine("------------");
            //Console.WriteLine($"{v1} {k1}");
            //Console.WriteLine($"{v1} {k2}");
            //Console.WriteLine($"{v2} {k1}");
            //Console.WriteLine($"{v2} {k2}");
            #endregion
            #region 3. feladat
            //Console.Write("havi fizetés: ");
            ////string hs = Console.ReadLine();
            ////int he = int.Parse(hs);
            //int hf = int.Parse(Console.ReadLine());
            //int ef = hf * 12;
            //Console.WriteLine($"éves fizetés: {ef} Ft");
            #endregion
            #region 4. feladat
            //Console.Write("euro árfolyama: ");
            //float arfolyam = float.Parse(Console.ReadLine());
            //Console.Write("ennyi eurom van: ");
            //int euro = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------");
            ////int forint = euro * arfolyam;
            ////Console.WriteLine($"Ez ennyi Ft-ot ér: {forint}");
            //Console.WriteLine("Ez ennyi Ft-ot ér: {0:N0}", euro * arfolyam);
            #endregion
            #region 5. feladat
            //Console.Write("téglalap 'a' oldala (cm): ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("téglalap 'b' oldala (cm): ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------");
            //Console.WriteLine($"téglalap kerülete: {2 * (a + b)} cm");
            //Console.WriteLine($"téglalap területe: {a * b} cm^2");
            #endregion
            #region 6. feladat
            //Console.Write("kör sugra (cm): ");
            //int r = int.Parse(Console.ReadLine());

            //Console.WriteLine($"kör kerülete: {2 * r * Math.PI} cm");
            //Console.WriteLine($"kör területe: {Math.Pow(r, 2) * Math.PI} cm^2");
            #endregion
            #region 7. feladat
            //Console.Write("'a'befogó: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("'b'befogó: ");
            //int b = int.Parse(Console.ReadLine());
            //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine("Az átfogó hossza: {0:0.00} cm", c);
            #endregion
            #region 8. feladat
            //Console.Write("megtett út: ");
            //float s = float.Parse(Console.ReadLine());
            //Console.Write("eltelt idő: ");
            //float t = float.Parse(Console.ReadLine());
            //float v = s / t;
            //Console.WriteLine($"átlagsebesség: {v} km/h");
            #endregion
            #region 9. feladat
            Console.Write("fogyasztás 100-on: ");
            float f = float.Parse(Console.ReadLine());
            Console.Write("benzin ára: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("megtett út: ");
            float u = float.Parse(Console.ReadLine());
            float uk = f / 100 * u * b;
            Console.WriteLine($"Utiköltség: {uk} Ft");
            #endregion
            #region 10. feladat
            #endregion
            Console.ReadKey();
        }
    }
}
