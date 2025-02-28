using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            ViewBag.Id = id;
            var destination = destinationManager.GetById(id);
            return View(destination);
        }
        [HttpPost]
        public IActionResult Detail(Destination destination)
        {

            return View();
        }

    }
}
