using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShareWork.BLL.Interfaces;
using ShareWork.Model.ViewModel;

namespace ShareWork.Web.Controllers
{
    public class HomeController : Controller
    {
        private IClientService _clientService;
        private IVerifyOrderService _verifyOrderService;
        private ICategoryService _categoryService;
        private IOrderService _orderService;

        public HomeController(IClientService clientService, IVerifyOrderService verifyOrderService, ICategoryService categoryService, IOrderService orderService)
        {
            _clientService = clientService;
            _verifyOrderService = verifyOrderService;
            _categoryService = categoryService;
            _orderService = orderService;
        }

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            IEnumerable<OrderVM> orders = _orderService.GetAll().OrderBy(o => o.DateCreated);

            return View(orders);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}