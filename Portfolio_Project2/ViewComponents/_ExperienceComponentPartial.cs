using Microsoft.AspNetCore.Mvc;

using Portfolio_Project2.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
