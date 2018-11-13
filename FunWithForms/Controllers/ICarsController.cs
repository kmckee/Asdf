using FunWithForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace FunWithForms.Controllers
{
    public interface ICarsController
    {
        IActionResult Create();
        IActionResult Create(Car car);
        IActionResult Delete(int id);
        IActionResult DeletePost(int id);
        IActionResult Details(int id);
        IActionResult Edit(Car car);
        IActionResult Edit(int id);
        IActionResult Index();
    }
}