using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon_Methods
{
    delegate int MissingNum(int[] mass);
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[] { 7,5, 10, 2, 4, 6, 8, 3, 9};

            MissingNum missNum = delegate (int[] mass)
            {
                Array.Sort(mass);
                for(int i = 0; i < mass.Length; i++)
                {
                    if (mass[i]!=i+1)
                    {
                        return i+1;
                    }
                }
                return 10;
            };
            Console.WriteLine(missNum(mass1));
        }
    }
}
