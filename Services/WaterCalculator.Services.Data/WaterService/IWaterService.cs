using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCalculator.Services.Data.WaterService
{
    public interface IWaterService
    {
        string Calculate(string inputAge, string inputWeight);
    }
}
