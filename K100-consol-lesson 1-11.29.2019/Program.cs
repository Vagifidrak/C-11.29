using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K100_consol_lesson_1_11._29._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Adinizi daxil edin: ");
            //var ad = Console.ReadLine();

            //Console.Write("Yasinizi daxil edin: ");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //if (18 > yas)
            //{
            //    Console.WriteLine("Salam !" + ad + ".Xos gelmisen" + "Senin Yasin catmir");
            //}
            //else if (18 < yas && 24 > yas)
            //{
            //    Console.WriteLine("Salam" + ad + "Xos gelmisen" + "Yene collerde qaldin");
            //}
            //else
            //{
            //    Console.WriteLine("Salam !" + ad + "Xos gelmisen" + "Axirda alindira bildin");
            //}
            while (1 == 1) {
                Console.WriteLine("Imtahan balinizi daxil edin");
                int bal = Convert.ToInt32(Console.ReadLine());
                if (51 > bal)
                {
                    Console.WriteLine("En zeif bend sizsiz Xudahafiz");
                }
                else if (51 < bal && 71 > bal)
                {
                    Console.WriteLine("En zeif olmasanda zeifin tayisiniz");
                }
                else if (71 < bal && 81 > bal)
                {
                    Console.WriteLine("Pis deyil ama sevinme");
                }
                else if (81 < bal && 91 > bal)
                {
                    Console.WriteLine("Birazda oxu elin ete catar");
                }
                else if (91 < bal && 100 > bal) {
                    Console.WriteLine("Artiq meqseddesen");
                }
                else
                { 
                    Console.WriteLine("Bali duzgun daxil edin");
                }
            }
        }
        }
    }
