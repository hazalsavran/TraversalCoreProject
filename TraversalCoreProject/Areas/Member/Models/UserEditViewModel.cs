using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProject.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string Name { get; set; }
        public  string Surname { get; set; }
        public  string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IFormFile  Image { get; set; }
    }
}
