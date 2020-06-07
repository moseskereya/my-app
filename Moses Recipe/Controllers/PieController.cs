using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moses_Recipe.Models;
using Moses_Recipe.ViewModels;

namespace Moses_Recipe.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategotyRepository _categotyRepository;
        public PieController(IPieRepository pieRepository, ICategotyRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categotyRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            PiesListModel piesListModel = new PiesListModel();
            piesListModel.Pies = _pieRepository.AllPies;

            piesListModel.CurrentCategory = "Cheese Cake";
            return View(piesListModel);
        }
        
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}