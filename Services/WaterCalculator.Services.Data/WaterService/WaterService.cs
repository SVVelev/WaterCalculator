namespace WaterCalculator.Services.Data.WaterService
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WaterService : IWaterService
    {
        public string Calculate(string inputAge, string inputWeight)
        {
            int age = int.Parse(inputAge);
            double weight = double.Parse(inputWeight);

            int mililiters = 0;

            if (age <= 30)
            {
                mililiters = 40;
            }
            else if (age <= 54)
            {
                mililiters = 35;
            }
            else if (age <= 65)
            {
                mililiters = 30;
            }
            else
            {
                mililiters = 25;
            }

            double result = mililiters * weight;

            return result.ToString();
        }
    }
}
