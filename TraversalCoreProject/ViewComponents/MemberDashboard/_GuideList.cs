using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public  IViewComponentResult Invoke()
        {
           var values = guideManager.GetAll();
           return View(values);

        }
    }
}
