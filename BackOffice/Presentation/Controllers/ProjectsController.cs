using Business.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class ProjectsController(IProjectService projectService) : Controller
{
    private readonly IProjectService _projectService = projectService;

    public async IActionResult Index()
    {
        var model = new ProjectsViewModel
        {
            Projects = await _projectService.GetProjectAsync(),
        };
        return View();
    }

    [HttpPost]
    public async IActionResult Add(AddProjectViewModel model)
    {
        var addProjectFormData = model.MapTo<AddProjectFormData>()

        var result = await _projectService.CreateProjectAsync(model);
        return Json(new { });
    }

    [HttpPost]
    public IActionResult Update(EditProjectViewModel model)
    {
        return Json(new { });
    }

    [HttpPost]
    public IActionResult Delete(string id)
    {
        return Json(new {});
    }
}
