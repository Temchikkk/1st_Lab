using System;

namespace ConsoleApp
{
    class Program89
    {
        
        static void Main(string[] args)
        {
            #region task 4
            double s;
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            s = Math.Cos(x);
            for (int y = 1; y <= 8; y++)
            {
                s += ((Math.Cos(y + 1) * x)) / Math.Pow(x, y);
            }
            Console.WriteLine(s);
            #endregion

            #region task 9
            const int m = (-1);
            double z = 0;
            double Factorial = 1;
            for (int i = 1; i <= 6; i++)
            {
                Factorial *= i;
                z += Math.Pow(m, i) * Math.Pow(5, i) / Factorial;
            }
            Console.WriteLine(z);
            #endregion

            #region task 15
            double uu = 1, zz = 1;
            for (int i = 0; i < 4; i++)
            {
                uu += zz;
                zz = uu - zz;
            }
            Console.WriteLine(uu / zz);
            #endregion

            #region task 18
            int p = 10;
            for (int l = 0; l <= 24; l += 3)
            {
                p = p * 2;
                Console.WriteLine("амёб " + p);
            }
            //поработать над оформлением этой задачи
            #endregion

            #region task 16
            double j = 1;
            for (int k = 0; k < 65; k++)
            {

                j += j * 2;
            }
            Console.WriteLine("Грамм зерна " + (j / 15));
            #endregion

            #region task 15
            uu = 1;
            zz = 1;
            for (int i = 0; i < 4; i++)
            {
                uu += zz;
                zz = uu - zz;

            }
            Console.WriteLine(uu / zz);

            #endregion

            #region part 2 task 2
            p = 1;
            int L = 30000;
            int ii = 1;
            while (p <= L)
            {
                ii += 3;
                p *= ii;
            }
            Console.WriteLine(ii - 3);
            #endregion

            #region part 2 task 4
            Console.WriteLine("Введите x ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            s = 0;
            double stepen = 1;
            if (Math.Abs(x2) < 1)
            {

                for (stepen = 0; Math.Pow(x2, stepen) > 0.0001; stepen += 2)
                {
                    s += Math.Pow(x2, stepen);

                }
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("не тот x");
            }
            #endregion

            #region part 2 task 7
            double nachal = 10;
            double time;
            double ss = 0;
            double days = 0;
            //a
            for (time = 0; time < 7; time++)
            {
                nachal = nachal + (nachal / 100 * 10);
                ss += nachal;
            }
            Console.WriteLine(ss);
            //b
            ss = 0;
            nachal = 10;
            while (ss < 101)
            {
                ss += nachal;
                nachal = nachal + (nachal / 100 * 10);
                days += 1;
            }
            Console.WriteLine(days);
            //c
            nachal = 10;
            days = 0;
            while (nachal < 20)
            {
                nachal = nachal + (nachal / 100 * 10);
                days += 1;
            }
            Console.WriteLine(days);
            #endregion

            #region part 3 task 1
            double aa = 0.1;
            double sum = 0;
            double bb = 1;
            double hh = 0.1;
            double yy;
            for (x = aa; x <= bb; x += hh)

            {
                int i = 1;
                s = 0;
                double factorial = 1;
                do
                {
                    factorial *= ((2 * i - 1) * i * 2);
                    s = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / factorial;
                    sum += s;
                    yy = Math.Cos(x);
                    Console.WriteLine($"y:{yy},x:{x}");
                    i++;

                } while (s >= 0.0001);

            }
            Console.WriteLine(sum);
            #endregion

            #region part 3 task 7
            aa = 0;
            sum = 0;
            bb = 1;
            hh = 0.05;
            yy = 0;
            for (x = aa; x <= bb; x += hh)

            {
                int i = 1;
                s = 0;
                double factorial = 1;
                do
                {
                    factorial *= ((2 * i - 1) * i * 2);
                    s = Math.Pow(x, 2 * i) / factorial;
                    sum += s;
                    yy = (Math.Exp(x) + Math.Exp(-1 * x)) / 2;
                    Console.WriteLine($"y:{yy},x:{x}");
                    i++;

                } while (s >= 0.0001);
                #endregion
            }
        }
    }
}
