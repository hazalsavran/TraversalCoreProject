﻿using Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //var values = guideManager.GetAll();
            return View();

        }
    }
}
