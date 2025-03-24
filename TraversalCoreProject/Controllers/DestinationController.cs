using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IDestinationService destinationManager;
       
        private readonly UserManager<AppUser> _userManager;
     
        public DestinationController(IDestinationService destinationManager, UserManager<AppUser> userManager)
        {
            this.destinationManager = destinationManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = destinationManager.GetAll();
            return View(values);
        }
        //[HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            var values = destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        //[HttpPost]
        //public IActionResult Detail(Destination destination)
        //{

        //    return View();
        //}

    }
}
