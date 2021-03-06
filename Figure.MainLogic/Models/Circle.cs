using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.MainLogic.Models
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public override double GetFigureSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
