using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAbouth : ViewComponent
    {

        SubAbouthManager subAbouthManager = new SubAbouthManager(new EfSubAbouthDal());
        public IViewComponentResult Invoke()
        {
            var model = subAbouthManager.GetAll().FirstOrDefault();
            return View(model);
        }
    }
}
