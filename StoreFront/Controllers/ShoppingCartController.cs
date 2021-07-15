//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using MVC3.UI.MVC.Models;

//namespace StoreFront.Controllers
//{
//    public class ShoppingCartController : Controller
//    {
//        // GET: ShoppingCart
//        public ActionResult Index()
//        {
//            //Pull session-based cart info into a local variable that we can pass to the view
//            var shoppingCart = (Dictionary<int, CartItemViewModel>)Session["cart"];

//            //does the shoppingCart exist and have items in it?
//            if (shoppingCart == null || shoppingCart.Count == 0)
//            {
//                //The user either hasn't put anything in the cart, or removed all, or session expired
//                shoppingCart = new Dictionary<int, CartItemViewModel>();

//                //Create message about empty cart
//                ViewBag.Message = "There are no items in your cart";
//            }
//            else
//            {
//                ViewBag.Message = null;//Explicitly clear out the variable
//            }
//            return View();
//        }

//        public ActionResult UpdateCart(int bookID, int qty)
//        {
//            //Get the cart from session and place its value in a local shoppingCart variable
//            Dictionary<int, CartItemViewModel> shoppingCart = (Dictionary<int, CartItemViewModel>)Session["cart"];

//            //Target correct cartItem using bookID for key - then change Qty property with the qty parameter
//            shoppingCart[bookID].Qty = qty;

//            //Return the local cart to the session and redirect the user back to the shopping cart to see their changes.
//            Session["cart"] = shoppingCart;

//            return RedirectToAction("Index");
//        }

//        public ActionResult RemoveFromCart(int id)
//        {
//            //Get
//            Dictionary<int, CartItemViewModel> shoppingCArt = (Dictionary<int, CartItemViewModel>)Session["cart"];

//            shoppingCArt.Remove(id);

//            Session["cart"] = shoppingCArt;

//            return RedirectToAction("Index");
//        }

//    }
//}