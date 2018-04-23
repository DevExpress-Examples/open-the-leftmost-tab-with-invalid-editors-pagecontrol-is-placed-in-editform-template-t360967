using System;
using System.Web.Mvc;

namespace GridViewPageControlValidation {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial() {
            return PartialView(NorthwindDataProvider.GetProducts());
        }

        public ActionResult GridViewAddNewPartial(Product product) {
            if (ModelState.IsValid) {
                try {
                    NorthwindDataProvider.InsertProduct(product);
                }
                catch (Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return PartialView("GridViewPartial", NorthwindDataProvider.GetProducts());
        }

        public ActionResult GridViewUpdatePartial(Product product) {
            if (ModelState.IsValid) {
                try {
                    NorthwindDataProvider.UpdateProduct(product);
                }
                catch (Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";

            return PartialView("GridViewPartial", NorthwindDataProvider.GetProducts());
        }

        public ActionResult GridViewDeletePartial(int productID) {
            try {
                NorthwindDataProvider.DeleteProduct(productID);
            }
            catch (Exception e) {
                ViewData["EditError"] = e.Message;
            }

            return PartialView("GridViewPartial", NorthwindDataProvider.GetProducts());
        }
    }
}