﻿using Ecuation.Core.Models;

namespace Ecuation.Core.Services
{

    public interface IEcuationService

    {
        double GetEcuation(double a, double b, double c, RaizType raizType);
        double GetEcuation2(double a, double b, double c, RaizType raizType);
    }
}
