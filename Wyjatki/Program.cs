using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int i = 10, j = 1, k;
                    k = i / j;
                    sbyte result;
                    sbyte x = Convert.ToSByte(Console.ReadLine());
                    sbyte y = Convert.ToSByte(Console.ReadLine());
                    result = (sbyte)(x + y);
                    if (result < 0)
                    {
                        throw new Exception("Wartość mniejsza od 0");
                    }
                }
                catch (OverflowException exc)
                {
                    Console.WriteLine("przepełnienie : {0}", exc.Message);
                }
                catch (ArithmeticException exc)
                {
                    Console.WriteLine("Wystąpił błąd: {0}", exc.Message);
                }
                catch (FormatException exc)
                {
                    Console.WriteLine("Zły format : {0}", exc.Message);
                }
                catch (Exception exc)
                {
                    Console.WriteLine("inne wyjątki: {0}", exc.Message);
                    //throw;
                }
                finally
                {
                    // zawsze się wykona
                    Console.WriteLine("To zawsze się wyświetli");
                }
            } catch (Exception exc)
            {
                Console.WriteLine("General error: {0}", exc.Message);
            }
            Console.ReadKey();
        }
    }
}
