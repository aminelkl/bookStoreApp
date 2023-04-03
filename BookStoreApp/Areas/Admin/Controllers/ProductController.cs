using BookStore.DataAccess;
using BookStore.DataAccess.Repository;
using BookStore.DataAccess.Repository.Irepository;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers;
[Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _unitOfWork.Product.GetAll();
            return View(objProductList);
        }

       
        public IActionResult Upsert(int? id)
        {
            Product product = new();
            if(id== null || id == 0)
            {
                //create product
                return View(product);
        }
            else
        {
                //update product
        }
        return View(product);
    }

    [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Update (obj);
                _unitOfWork.Save();
                TempData["Success"] = "Product updated succesfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var ProductFromDb = _unitOfWork.Product.GetFirstOrDefault(u=>u.Id==id);

            if (ProductFromDb == null)
            {
                return NotFound();
            }

            return View(ProductFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
                TempData["Success"] = "CoverType deleted succesfully";
                return RedirectToAction("Index");
         } 
    }

