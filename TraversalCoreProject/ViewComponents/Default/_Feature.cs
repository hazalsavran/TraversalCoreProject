using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        Feature2Manager feature2Manager = new Feature2Manager(new EfFeature2Dal());
        public IViewComponentResult Invoke()
        {

            var feature = featureManager.GetAll();
            var features2 = feature2Manager.GetAll();
            HighlightsViewModel model = new HighlightsViewModel
            {
                Feature1 = feature[0],
                Features = features2
                
            };
            return View(model);
        }
    }
}
