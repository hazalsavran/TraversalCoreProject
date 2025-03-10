using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult DeleteUser(int id)
        {
           _appUserService.Delete(_appUserService.GetById(id));
            return RedirectToAction("Index");
        }
        //buraya view eklenip doldurulacak
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var value =  _appUserService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.Update(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.GetAll();
            return View();
        }

        //public IActionResult ReservationUser(int id)
        //{
        //    var values = _reservationService.GetListWithReservationByAccepted(id);
        //    return View(values);
        //}
    }
}
