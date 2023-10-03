using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int note, upmoy,downmoy,k;
            note = 0;
            k = 0;
            upmoy = 0;
            downmoy = 0;
            Console.WriteLine("entrez vos notes");

            for (k = 0; k <=10 ; k++) 
            {

                note = int.Parse(Console.ReadLine());

                if (note > 11)
                {
                    upmoy++;

                }
                else
                {
                   downmoy++;
                }
                
            }

            Console.WriteLine(upmoy + " eleves sont au dessus de 10 et" + downmoy + " eleves sont en dessous de 10!");
            Console.ReadLine();

        }
    }
}
