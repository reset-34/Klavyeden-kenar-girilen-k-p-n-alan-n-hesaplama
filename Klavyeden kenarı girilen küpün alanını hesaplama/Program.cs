using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_kenarı_girilen_küpün_alanını_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Formül : 6*a*a


            Console.WriteLine("Küpün bir kenarını giriniz");
            int a = Int32.Parse(Console.ReadLine());

            int alan = 6 * a * a;

            Console.WriteLine("Küpün alanı= " + alan);
            Console.ReadLine();
        }
    }
}
