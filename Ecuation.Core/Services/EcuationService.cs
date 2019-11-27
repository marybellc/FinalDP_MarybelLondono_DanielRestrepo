using Ecuation.Core.Models;
using System;

namespace Ecuation.Core.Services
{
    public class EcuationService : IEcuationService
    {
        double x1;
        double x2;
        double determinante;

        public double GetEcuation(double a, double b, double c, RaizType raizType)
        {
            determinante = (b * b) - (4 * a * c);
            x2 = (-b + Math.Sqrt(determinante)) / (2 * a);
            x1 = (-b - Math.Sqrt(determinante)) / (2 * a);

            return x1;
        }

    }
}
