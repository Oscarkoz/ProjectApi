using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Data;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly ProjectContext _context;

    public ProjectsController(ProjectContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Project>> Get()
    {
        return Ok(_context.Projects.ToList());
    }
}
