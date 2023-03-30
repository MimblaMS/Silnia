using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia

{
    internal class Program
    {
        static int error = 0;

        // SILNIA n! METODA REKURENCYJNA
        static ulong Silnia1(ulong i)
        {
            try
            {
                checked 
                {
                    if (i == 1) return 1;
                    else return (i * Silnia1(i - 1));
                }
            } 
            catch (OverflowException ex) 
            {
                error = 1;
                return 0;
            }
        }

        // SILNIA n! METODA ITERACYJNA
        static ulong Silnia2(ulong j)
        {
            checked
            {
                try 
                {
                     ulong ret = 1;
                     for (uint i = 1; i <= j; i++) ret = ret * i;
                     return ret;
                } 

                catch (OverflowException e) 
                { 
                     error = 1;
                     return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            String line;
            ulong n;
            Console.WriteLine("Podaj dla jakiej liczby naturalnej obliczyć silnię.\n");
            line = Console.ReadLine();
            n = ulong.Parse(line);

            error = 0;
            ulong ret = Silnia1(n);
            if (error == 0) Console.WriteLine("n! = " + ret);
            else Console.WriteLine("Błąd przepełnienia");

            error = 0;
            ret = Silnia2(n);
            if (error == 0) Console.WriteLine("n! = " + ret);
            else Console.WriteLine("Błąd przepełnienia");

            Console.WriteLine("Naciśnij ENTER");
            Console.ReadLine();
        }
    }
}

