using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WaterCalculator.Web.ViewModels.Water
{
    public class WaterInputModel
    {
        [Display(Name = "Enter your age")]
        public string Age { get; set; }

        [Display(Name = "Enter your weight in kilograms:")]
        public string Weight { get; set; }
    }
}
