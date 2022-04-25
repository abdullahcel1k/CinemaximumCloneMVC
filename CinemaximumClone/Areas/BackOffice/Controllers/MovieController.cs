using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaximumClone.Areas.BackOffice.Controllers
{
    [Area("BackOffice")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICategoryService _categoryService;
        private readonly IMovieCategoryService _movieCategoryService;

        public MovieController(ICategoryService categoryService, IMovieService movieService, IMovieCategoryService movieCategoryService)
        {
            _categoryService = categoryService;
            _movieService = movieService;
            _movieCategoryService = movieCategoryService;
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
        public async Task<IActionResult> Save(Movie movie, List<int> categoryIds)
        {
            var addedMovie = await _movieService.Add(movie);
            for(var i = 0; i < categoryIds.Count; i++)
            {
                var newMoviewCategory = new MovieCategory();
                newMoviewCategory.Movie = addedMovie;
                newMoviewCategory.Category = await _categoryService.GetById(categoryIds[i]);
                await _movieCategoryService.Add(newMoviewCategory);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _movieService.Delete(id);

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
