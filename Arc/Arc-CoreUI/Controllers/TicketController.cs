using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arc_CoreUi.Controllers
{
    using ModelViews.Ticket;

    public class TicketController : Controller
    {
        // GET: Tickets
        public ActionResult Index()
        {
            var model = new TicketIndexViewModel();
            return View(model);
        }
    }
}