using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Destination
{
    public class _GuideDetails:ViewComponent
    {
        private readonly IGuideService _guideService;
        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _guideService.GetById(1);
            return View(values);
        }
    }
}
