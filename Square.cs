﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubovik_Zadanie4
{
    class Square
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Square(double a, double b)
        {
            this.a = a;
            this.b = b;
            c = a * a + b * b;
        }

        public double Result()
        {
            return a * a + b * b;
        }
    }
}
