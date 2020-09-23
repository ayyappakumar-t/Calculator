﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Interface
{
    public interface ICalculatorAdapter
    {
        int Add(int start, int amount);
        int Subtract(int start, int amount);
        int Multiply(int start, int by);
        int Divide(int start, int by);
    }
}
