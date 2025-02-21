using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
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
