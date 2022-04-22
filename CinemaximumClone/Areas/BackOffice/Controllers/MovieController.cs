using CinemaximumClone.Data;
using CinemaximumClone.Data.Services;
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Areas.BackOffice.Controllers
{
    [Area("BackOffice")]
    public class MovieController : Controller
    {
        private readonly MovieService _movieService;
        private readonly CategoryService _categoryService;

        public MovieController(CategoryService categoryService, MovieService movieService)
        {
            _categoryService = categoryService;
            _movieService = movieService; 
        }

        public async Task<IActionResult> Index()
        {
            var movieList = await _movieService.GetList();

            return View(movieList);
        }

        public async  Task<IActionResult> Save()
        {
            MovieCategoryCreateViewModel movieCategoryCreate = new MovieCategoryCreateViewModel();
            movieCategoryCreate.Categories = await _categoryService.GetList();

            return View(movieCategoryCreate);
        }

        [HttpPost]
        public IActionResult Save(Movie movie)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<Category>  SaveCategory([FromBody]Category category) {
            var addedCat = await _categoryService.Add(category);
            return addedCat;
        }

        public async Task<List<Category>> GetCategories()
        {
            var categoryList = await _categoryService.GetList();
            return categoryList;
        }

        [HttpDelete]
        public async Task<bool> DeleteCategory(int id)
        {
            var isDeleted = await _categoryService.Delete(id);

            return isDeleted;
        }
    }
}
