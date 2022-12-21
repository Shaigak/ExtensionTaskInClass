using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculationService
    {
        public double Calculate(double x, double y, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = x + y;
                    return result;
                case "-":
                    result = x - y;
                    return result;
                case "*":
                    result = x*y;
                    return result;
                case "/":
                    result = x / y;
                    return result;
                    
            }
            return default;
        }
    }
}
