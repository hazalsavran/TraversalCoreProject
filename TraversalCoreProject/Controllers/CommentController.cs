using Business.Concrete;
using DataAccess.EntityFramework;
using DocumentFormat.OpenXml.Office2010.Excel;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
       

        [HttpGet]
        public PartialViewResult AddComment()
        {
            
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {

            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            commentManager.Add(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
