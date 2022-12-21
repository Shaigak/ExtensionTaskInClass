using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks12._21._2022.Controllers
{
    internal class CalculateController
    {
        public void Calculate()
        {
            CalculationService Calculation = new CalculateService();
            var result = Calculation.Calculate(5, 7, "+");
            Console.WriteLine(result);
        }

    }
}
