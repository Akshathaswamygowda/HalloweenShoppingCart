using Ch24ShoppingCartMVC.Models;
using Ch24ShoppingCartMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ch24ShoppingCartMVC.Controllers
{
    public class CheckoutController : Controller
    {
        CartModel cart = new CartModel();

        
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("List/");
        }

        [HttpGet]
        public ActionResult List()
        {
            CartViewModel model = (CartViewModel)TempData["cart"];
            if (model == null)
                model = cart.GetCart();
            return View(model);
        }
        [HttpPost]
        public RedirectToRouteResult List(OrderViewModel order)
        {
            CartViewModel model = cart.GetCart(order.SelectedProduct.ProductID);
            model.AddedProduct.Quantity = order.SelectedProduct.Quantity;
            cart.AddToCart(model);
            TempData["cart"] = model;
            return RedirectToAction("Index", "Checkout");
        }
        [HttpPost]
        public RedirectToRouteResult SubmitCheckout(CartViewModel model)
        {
            try
            {
                //HalloweenEntities1 halloweenEntities1 = new HalloweenEntities1();
                //halloweenEntities1.Customers.Add(new Customer { Email = model.Email, FirstName=model.FirstName,LastName = model.LastName, Address = model.Address, City = model.City, State = model.State, ZipCode = model.PostalCode, PhoneNumber = model.PhoneNumber });
                //halloweenEntities1.SaveChanges();
                return RedirectToAction("PaymentPage", "Checkout");

            }
            catch(System.Data.Entity.Validation.DbEntityValidationException)
            {
                
            }
            return RedirectToAction("PaymentPage", "Checkout");
        }
        [HttpGet]
        public ActionResult Confirmation()
        {

            return View();
        }
        public ActionResult PaymentPage()
        {
            
            return RedirectToAction("Payment", "Checkout");
        }

        public ActionResult Payment(CartViewModel model)
        {
           
            return View();
        }

        public ActionResult PayPal()
        {
            return Content("<script>window.location = 'https://www.paypal.com/signin?country.x=US&locale.x=en_US';</script>");
        }

       public ActionResult ShippingConf()
        {
            return RedirectToAction("Confirmation", "Checkout");
        }

    }
}
