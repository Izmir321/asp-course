using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProjectsController : Controller
    {
        [Route("admin/projects")]
        public IActionResult Index()
        {
            var viewModel = new ProjectsViewModel
            {
                Projects = SetProjects()
            };

            return View(viewModel);
        }

        private IEnumerable<ProjectViewModel> SetProjects()
        {
            var projects = new List<ProjectViewModel>();

            projects.Add(new ProjectViewModel
            {
                Id = Guid.NewGuid().ToString(),
                ProjectName = "Website Redesign",
                ProjectImage = "/images/Project/project-template.svg",
                Description = "<p>It is <strong>necessary</strong> to develop a website redesign in a corporate style.</p>",
                ClientName = "GitLab Inc.",
                TimeLeft = "1 week left",
                Members = new List<string> { "/images/Project/user-template-male-green.svg" }
            });

            return projects;
        }
    }
}
