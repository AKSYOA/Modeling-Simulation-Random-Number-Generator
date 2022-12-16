using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class MainFuctions
    {

        public List<double> LCG_Generator(double multiplier, double increment, double modulus, double x0, double iteration)
        {
            List<double> lcg = new List<double>();
            double seed_i = 0;
            for (int i = 1; i < iteration; i++) 
            {
                if(i == 1)
                {
                    lcg.Add(((multiplier * x0) + increment) % modulus);
                    seed_i = ((multiplier * x0) + increment) % modulus;
                }
                else
                {
                    lcg.Add(((multiplier * seed_i) + increment) % modulus);
                    seed_i = ((multiplier * seed_i) + increment) % modulus;  
                }
                
            }
            return lcg;
        }


        public int calculateActualPeriodLenth(List<double> randomNumber)
        { 
            return 1;
        }


        /*
        public double calculateActualPeriodLenth(double multiplier, double increment, double modulus, double x0)
        {
            double LongestPeriod = -1;
            double k = modulus - 1;

            if (IsPowerOfTwo(modulus) && (increment != 0))
            {

            }
            if (IsPowerOfTwo(modulus) && (increment == 0))
            {
                if (seedIsOdd(x0) && (multiplier == (5 + 8 * k)))
                    LongestPeriod = modulus / 4;
            }
            if (IsPrime(modulus) && (increment == 0))
            {
                if (IsDivisible((Math.Pow(multiplier, k) - 1), modulus))
                    LongestPeriod = modulus - 1;
            }

            return LongestPeriod;
        }
        */


        public bool IsPrime(double modulus)
        {
            int a = 0;
            for (int i = 1; i <= modulus; i++)
            {
                if (modulus % i == 0)
                {
                    a++;
                }
            }
            if (a == 2) 
                return true;
            else 
                return false;
        }


        public bool IsDivisible(double a, double b)
        {
            double cDouble = a / b;
            int cInteger = (int)cDouble;
            if (cInteger == cDouble)
                return true;
            return false;
        }


        public bool IsPowerOfTwo(double num)
        {
            if (num == 0)
                return false;
            while (num != 1)
            {
                if (num % 2 != 0)
                    return false;
                num = num / 2;
            }
            return true;
        }


        public bool seedIsOdd(double seed)
        {
            if (seed % 2 != 0)
                return true;
            return false;
        }


    }
}
