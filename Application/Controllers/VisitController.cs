using Application.Database;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
namespace Application.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitController:ControllerBase
{
    [HttpGet("{Id}")]
    public IActionResult getVisitsById(int Id)
    {
        var visits = StaticData.visits;
        int lenght = visits.Count;
        List<Visit> AnimalVisit = new List<Visit>();
        for (int i = 0; i < lenght; i++)
        {
            if (Id == visits[i].animale.Id)
            {
                AnimalVisit.Add(visits[i]);
            }
        }

        if (AnimalVisit.Count > 0)
        {
            return Ok(AnimalVisit);
        }
        
        return NotFound();
        
    }

    [HttpPost]
    public IActionResult addVisit(Visit visit)
    {
        var visits = StaticData.visits;
        visits.Add(visit);
        return Created();
    }
    
}