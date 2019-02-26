using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult LeftTreePartial() {
            return PartialView("LeftTreePartial");
        }
        public ActionResult RightTreePartial() {
            return PartialView("RightTreePartial");
        }
        public ActionResult UpdateTreeListContainer(string sourceKey, string newParentKey) {
            MyProvider.MoveNode(sourceKey, newParentKey);
            return PartialView("TreeListContainerPartial");
        }
    }
}