using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager( new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetAll();

            return View(values);
        }
    }
}
