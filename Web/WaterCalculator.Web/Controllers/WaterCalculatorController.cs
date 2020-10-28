using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCalculator.Services.Data.WaterService;
using WaterCalculator.Web.ViewModels.Water;

namespace WaterCalculator.Web.Controllers
{
    public class WaterCalculatorController : BaseController
    {
        private readonly IWaterService waterService;

        public WaterCalculatorController(IWaterService waterService)
        {
            this.waterService = waterService;
        }

        public IActionResult InputData()
        {
            var viewModel = new WaterInputModel();

            return this.View(viewModel);
        }

        public IActionResult Result(string mililitersToDrink)
        {
            var viewModel = new WaterOutputModel();
            viewModel.MililitersToDrink = mililitersToDrink;

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult InputData(WaterInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string result = this.waterService.Calculate(input.Age, input.Weight);

            return this.RedirectToAction(nameof(this.Result), new { mililitersToDrink = result });
        }
    }
}
