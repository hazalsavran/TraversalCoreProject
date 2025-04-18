using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.Areas.Member.Controllers
{
	[Area("Member")]
	public class DashboardController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public DashboardController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			AppUser values = await _userManager.FindByNameAsync(User.Identity.Name);
			ProfileViewModel profileViewModel = new ProfileViewModel()
			{
				NameSurname = values.Name + " "+ values.Surname,
				UserImage = values.ImageUrl
			};
			return View(profileViewModel);
		}

        public async Task<IActionResult> MemberDashboard()
        {
            return View();
        }
    }
}
