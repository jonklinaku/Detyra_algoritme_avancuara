using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comaprison_vs_distribution_sort
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] unsortedArray = new int[50];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = random.Next(0, 50);
            }
            Console.Write("Provojme se pari per nje varg me 50 anetare te pa sortuar se sa shpejt po e bene dhe gjithashtu paraqesim rezultatin: ");
            Console.WriteLine("[{0}]", string.Join(", ", unsortedArray));
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] ComparisonAnswer = ComparisonCountSort(unsortedArray);
            timer.Stop();
            Console.WriteLine("Koha per ComparisonCountingSort: " + timer.ElapsedMilliseconds + " miliseconds vargu:");
            Console.WriteLine("[{0}]", string.Join(", ", ComparisonAnswer));

            timer.Reset();

            timer.Start();
            int[] DistributionAnswer = DistributionCountSort(unsortedArray, 0, 50);
            timer.Stop();
            Console.WriteLine("Koha per DistributionCountingSort: " + timer.ElapsedMilliseconds + " miliseconds, vargu:");
            Console.WriteLine("[{0}]", string.Join(", ", DistributionAnswer));

            unsortedArray = new int[1000000];
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = random.Next(0, 1000000);
            }
            //Stopwatch timer = new Stopwatch();
            timer.Reset();
            Console.WriteLine("\n\ntani provojme per nje milion anetare");
            timer.Start();
             ComparisonCountSort(unsortedArray);
            timer.Stop();
            Console.WriteLine("Koha per ComparisonCountingSort: " + timer.ElapsedMilliseconds + " miliseconds");

            timer.Reset();

            timer.Start();
              DistributionCountSort(unsortedArray, 0, 1000000);
            timer.Stop();
            Console.WriteLine("Koha per DistributionCountingSort: " + timer.ElapsedMilliseconds + " miliseconds");
            Console.WriteLine("prekni ndonje tast per te perfunduar programi!");
            Console.ReadKey();
        }


        

        public static int[] DistributionCountSort(int[] array, int l, int u)
        {
            int[] ans = new int[array.Length];
            int[] d = new int[u - l + 1];

            for (int i = 0; i < array.Length; i++)
                d[array[i] - l] = d[array[i] - l] + 1;

            for (int i = 1; i < (u - l + 1); i++)
                d[i] = d[i - 1] + d[i];

            for (int i = array.Length - 1; i >= 0; --i)
            {
                int j = array[i] - l;
                ans[d[j] - 1] = array[i];
                d[j] = d[j] - 1;
            }

            return ans;
        }
        public static int[] ComparisonCountSort(int[] array)
        {
            int[] ans = new int[array.Length];
            int[] count = new int[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                        count[j] += 1;
                    else
                        count[i] += 1;
                }
            }

            for (int i = 0; i < array.Length; i++)
                ans[count[i]] = array[i];

            return ans;
        }
    }
}
