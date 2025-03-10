using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TraversalCoreProject.Areas.Member.Models;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.GetAll();
            return View(values);
        }

        public IActionResult ChangeToFalse(int id)
        {
            var guide = _guideService.GetById(id);
            guide.Status = false;
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            var guide = _guideService.GetById(id);
            guide.Status = true;
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuide(AddGuideViewModel guide)
        {
            Guide newGuid = new Guide
            {
                Name = guide.Name,
                Description = guide.Description,
                TwitterUrl = guide.TwitterUrl,
                InstagramUrl = guide.InstagramUrl,
               
            };
            if (guide.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(guide.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await guide.Image.CopyToAsync(stream);
                newGuid.Image = imageName;
            }
          
            _guideService.Add(newGuid);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var guide = _guideService.GetById(id);
            return View(guide);
        }
        [HttpPost]
        public async Task<IActionResult> EditGuide(EditGuideViewModel guide)
        {
            var updatedGuide = _guideService.GetById(guide.Id);
            updatedGuide.Description = guide.Description;
            updatedGuide.Name = guide.Name;
            updatedGuide.InstagramUrl = guide.InstagramUrl;
            updatedGuide.TwitterUrl = guide.TwitterUrl;
           
            if (guide.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(guide.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await guide.Image.CopyToAsync(stream);
                updatedGuide.Image = imageName;

            }
           

            _guideService.Update(updatedGuide);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteGuide(int id)
        {
            var guide = _guideService.GetById(id);
            _guideService.Delete(guide);

            return RedirectToAction("Index");
        }

    }
}
