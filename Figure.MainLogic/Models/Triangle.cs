using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.MainLogic.Models
{
    public class Triangle : Figure
    {
        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double TrirdSide { get; set; }

        public override double GetFigureSquare()
        {
            var p = (FirstSide + SecondSide + TrirdSide) / 3;
            return Math.Sqrt(p * (p - TrirdSide) * (p - SecondSide) * (p - FirstSide));
        }

        public bool IsRightTriangle()
        {
            if (FirstSide * FirstSide + SecondSide * SecondSide == TrirdSide * TrirdSide ||
                FirstSide * FirstSide + TrirdSide * TrirdSide == SecondSide * SecondSide ||
                SecondSide * SecondSide + TrirdSide * TrirdSide == FirstSide * FirstSide)
            {
                return true;
            }
            return false;
        }
    }
}
