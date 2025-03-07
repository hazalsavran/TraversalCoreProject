using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
      

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination p)
        {
            destinationManager.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteDestination(int id)
        {
            Destination value = destinationManager.GetById(id);
            destinationManager.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            Destination value = destinationManager.GetById(id);
            destinationManager.Update(value);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {
            destinationManager.Update(p);
            return RedirectToAction("Index");
        }
    }
}
