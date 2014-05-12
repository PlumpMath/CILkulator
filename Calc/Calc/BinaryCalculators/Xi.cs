﻿using System;

namespace Calc.BinaryCalculators
{
    public class Xi:IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            int t,i;
            for (t = 1, i = 0; i < secondArgument; i++,t *= 10) ;
            int result= (int)(firstArgument % (t) / (t*0.1));
            return result;
        }
    }
}