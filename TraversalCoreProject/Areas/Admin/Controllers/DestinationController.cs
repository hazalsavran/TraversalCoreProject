using Business.Abstract;
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

        private readonly IDestinationService _destinationService;


        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.GetAll();
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
            _destinationService.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteDestination(int id)
        {
            Destination value = _destinationService.GetById(id);
            _destinationService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            Destination value = _destinationService.GetById(id);
            _destinationService.Update(value);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {
            _destinationService.Update(p);
            return RedirectToAction("Index");
        }
    }
}
