﻿using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1) =>
         View(new ProductsListViewModel
        {
            Products = repository.Products.Where(predicate=>predicate.Category==category||category==null)
                           .OrderBy(p => p.ProductID)
                           .Skip((productPage - 1) * PageSize)
                           .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category==null? repository.Products.Count():repository.Products.Where(p=>p.Category==category).Count()
            }
        });
    }
}