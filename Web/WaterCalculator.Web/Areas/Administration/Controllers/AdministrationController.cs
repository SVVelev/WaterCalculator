namespace WaterCalculator.Web.Areas.Administration.Controllers
{
    using WaterCalculator.Common;
    using WaterCalculator.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
