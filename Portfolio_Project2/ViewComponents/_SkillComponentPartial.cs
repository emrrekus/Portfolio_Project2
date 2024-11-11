using Microsoft.AspNetCore.Mvc;

using Portfolio_Project2.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
