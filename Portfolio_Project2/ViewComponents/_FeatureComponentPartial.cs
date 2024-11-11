using Microsoft.AspNetCore.Mvc;

using Portfolio_Project2.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
