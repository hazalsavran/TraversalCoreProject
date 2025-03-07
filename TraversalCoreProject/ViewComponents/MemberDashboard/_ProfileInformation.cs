using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser values = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileViewModel profileViewModel = new ProfileViewModel()
            {
                NameSurname = values.Name + " " + values.Surname,
                UserImage = values.ImageUrl,
                Phone = values.PhoneNumber,
                Mail = values.Email

            };
            return View(profileViewModel);
           
        }
    }
}
