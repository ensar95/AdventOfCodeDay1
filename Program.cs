using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sep = { "\n" };
            string[] text = File.ReadAllText("C:\\Users\\ensar.skopljak\\source\\repos\\AdventOfCodeDay1\\AdventOfCodeDay1\\FinancialReport.txt").Split(sep, StringSplitOptions.RemoveEmptyEntries);
            List<string> excerpts = text.OfType<string>().ToList();
            Console.WriteLine(excerpts[0]);

            for(int i=0; i<excerpts.Count; i++)
            {
                if (excerpts[i].Contains("\r"))
                {
                    excerpts[i] = excerpts[i].Replace("\r", "");
                }
            }

            Console.WriteLine(excerpts[0]);
            long resultA = 0;
            long resultB = 0;
            for (int i = 0; i < excerpts.Count; i++)
            {
                for (int j = 0; j < excerpts.Count; j++)
                {
                    long a = Int64.Parse(excerpts[i]);
                    long b = Int64.Parse(excerpts[j]);
                    if(a+b == 2020)
                    {
                        resultA = a;
                        resultB = b;
                        break;
                    }
                }

            }
            Console.WriteLine(resultB * resultA);


            //partTwo

            long result1 = 0;
            long result2 = 0;
            long result3 = 0;
            for (int i = 0; i < excerpts.Count; i++)
            {
                for (int j = 0; j < excerpts.Count; j++)
                {
                    for (int k = 0; k < excerpts.Count; k++)
                    {
                        long a = Int64.Parse(excerpts[i]);
                        long b = Int64.Parse(excerpts[j]);
                        long c = Int64.Parse(excerpts[k]);
                        if (a + b + c == 2020)
                        {
                            result1 = a;
                            result2 = b;
                            result3 = c;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(result3 * result2 * result1);
        }
    }
}
