﻿using System;

namespace Calc.BinaryCalculators
{
    public class Exp : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            if (secondArgument < 0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "secondArgument");
            }
            double result = firstArgument;
            for (; secondArgument > 0; secondArgument--)
            {
                result *= 10;
            }
            return result;
        }
    }
}
