using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Security.Claims;
using Tunzking.DataAccess.Repository.IRepository;
using Tunzking.Models;
using Tunzking.Utility;
using X.PagedList;

namespace TunzkingWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if(claim != null)
            {
                HttpContext.Session.SetInt32(SD.SessionCart, _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId.ToString() == claim.Value).Count());
            }

            return View();
        }

        public IActionResult Search(string? search, int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 6;
            if (string.IsNullOrEmpty(search))
            {
                return RedirectToAction("Category");
            }
            else
            {
                IEnumerable<Product> productList = _unitOfWork.Product.GetAll(u=>u.Title.Contains(search),includeProperties: "Category");

                IPagedList<Product> pagedList = productList.ToPagedList(pageNumber, pageSize);
                return View(pagedList);
            }
        }


        public IActionResult Category(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 6;
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");

            IPagedList<Product> pagedList = productList.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }

        [HttpPost]
        [ActionName("Category")]
        public IActionResult CategoryPOST(int? page)
        {
            int pageNumber = 1;
            int pageSize = 6;
            string filter = Request.Form["radio"];
            if(!string.IsNullOrEmpty(filter))
            {
                IEnumerable<Product> productList = _unitOfWork.Product.GetAll(u=>u.Brand == filter,includeProperties: "Category");

                IPagedList<Product> pagedList = productList.ToPagedList(pageNumber, pageSize);
                return View(pagedList);
            }
            else
            {
                IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");

                IPagedList<Product> pagedList = productList.ToPagedList(pageNumber, pageSize);
                return View(pagedList);
            }
        }

        public IActionResult Details(int id)
        {
            ShoppingCart cart = new()
            {
                Product = _unitOfWork.Product.Get(p => p.Id == id, includeProperties: "Category"),
                Count = 1,
                ProductId = id
            };
                
            return View(cart);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Details([Bind("ProductId,Product,Count,ApplicationUserId,ApplicationUser")] ShoppingCart shoppingCart)
        {
            if(!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }
            if(shoppingCart.Count > 100)
            {
                TempData["error"] = "1-100";
                return RedirectToAction("Details");
            }
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userIdString = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            if(Guid.TryParse(userIdString, out Guid userId))
            {
                shoppingCart.ApplicationUserId = userId;
            }
            else { }

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u=>u.ApplicationUserId == userId && u.ProductId==shoppingCart.ProductId);

            if(cartFromDb != null)
            {
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart, _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart updated";

            return RedirectToAction(nameof(Category));
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}