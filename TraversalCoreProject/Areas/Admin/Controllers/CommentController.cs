﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
       private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.GetListCommentWithDestination();
            return View(values);
        }

        [HttpGet]
        public IActionResult DeleteComment(int id)
        {
            var deletedComment = _commentService.GetById(id);
            _commentService.Delete(deletedComment);
            return RedirectToAction("Index");
        }
    }
}
