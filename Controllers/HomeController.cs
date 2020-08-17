using starter_module_mvc.Models;
using starter_module_mvc.Services.Interfaces;
using DotNetNuke.Security;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Web.Mvc;

namespace starter_module_mvc.Controllers
{
    [DnnHandleError]
    public class HomeController : DnnController
    {
        protected IMyService MyService { get; }

        public HomeController(IMyService myService)
        {
            MyService = myService;
        }

        public ActionResult Home()
        {
            var model = new Home
            {
                Message = MyService.DnnHello()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Home(Home data)
        {
            var model = new Home
            {
                Message = MyService.DnnHelloPersonalize(data.Name)
            };
            return View(model);
        }
    }
}