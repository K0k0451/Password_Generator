using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator.Model
{
    public class Something
    {
        private int n, l;

        public void ReadInput()
        {
            Console.WriteLine("Въведи N: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведи L: ");
            l = int.Parse(Console.ReadLine());
        }

        public string GeneratePasswords()
        {
            string result = "";

            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (char l1 = 'a'; l1 < 'a' + l; l1++)
                    {
                        for (char l2 = 'a'; l2 < 'a' + l; l2++)
                        {
                            for (int d3 = 1; d3 <= n; d3++)
                            {
                                if (d3 > d1 && d3 > d2)
                                {
                                    result += $"{d1}{d2}{l1}{l2}{d3} ";
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
