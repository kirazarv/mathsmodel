using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1taskUPMathModel
{
    public class CalcPopulation
    {
        public static double birth, mortality,firstY;
        public static double[] population = new double[101];

        static void Main(string[] args)
        {
            birth=0.03;
            mortality = 0.005;
            firstY = 500;
            Calc(birth, mortality, firstY);
            Output(population);

            //тестирование 
            double rozhd = 0.0145;
            double smr = 0.0016;
            double pervGod = 4635200;
            double[] expected = { 4635200, 4694994, 4755560, 4816906, 4879044, 4941984, 5005736, 5070310, 5135717, 5201967, 5269073 };
            double[] actual = new double[11];
            //act and assert
            double[] temp = CalcPopulation.Calc(rozhd, smr, pervGod);
            Console.WriteLine("actual - expected");
            for (int i = 0; i < actual.Length; i++)
            {
                actual[i] = temp[i];
                Console.WriteLine($"{actual[i]} - {expected[i]}");
            }
            Console.ReadKey();

        }

        public static double[] Calc(double r,double m,double Xprev)
        {
            double Xi = Xprev;
            population[0] = Xi;
            //Console.WriteLine("год - численность на начало года");
            

            for (int i = 1; i < 101; i++)
            {
                Xi = Xprev + Xprev * (r - m);
                Xprev = Xi;

                population[i] = Math.Round(Xi, MidpointRounding.AwayFromZero);
               
            }
            Console.ReadKey();

            return population;
        }

        public static void Output(double[]args)
        {
            Console.WriteLine("год - численность на начало года");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"200{i}- {population[i]}");
            }
            for (int i = 10; i < 100; i++)
            {
                Console.WriteLine($"20{i}- {population[i]}");
            }
            Console.WriteLine($"2100- {population[100]}");
            Console.ReadKey();

        }

    }
}
