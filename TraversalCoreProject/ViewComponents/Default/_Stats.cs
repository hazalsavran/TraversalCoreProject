using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Stats : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.branches = c.Destinations.Count();
            ViewBag.TravelGuide = c.Guides.Count();
           
            return View();
        }
    }
}
