using Microsoft.AspNetCore.Http;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class EditGuideViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile Image { get; set; }
        public string Description { get; set; }    
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status { get; set; }
    }
}
