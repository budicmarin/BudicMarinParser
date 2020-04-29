using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudicMarinParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši rečenicu");
            String recenica = Console.ReadLine();
            for(int i=0;i<recenica.Length;i++)
            {
                if(!((recenica[i]>='A'&&recenica[i]<='Z')|| 
                    (recenica[i] >= 'a' && recenica[i] <= 'z')|| (recenica[i] >= '0' && recenica[i] <= '9')))
                {
                    recenica=recenica.Replace(recenica[i],' ');
                }
            }
            string[]rijeci = recenica.Split(' ');

            foreach(string rec in rijeci)
            {
                Console.WriteLine(rec);
            }
            Console.ReadKey();

        }

    }
        
}

