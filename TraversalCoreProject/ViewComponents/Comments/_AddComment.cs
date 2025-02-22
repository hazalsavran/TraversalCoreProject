using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comments
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    
    }
}
