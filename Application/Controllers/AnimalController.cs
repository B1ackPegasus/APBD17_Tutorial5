using Application.Database;
using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals =  StaticData.animals;
        return Ok(animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int Id)
    {
        List<Animal> animals = StaticData.animals;
        int lenght = animals.Count;
        
        for (int i = 0; i < lenght; i++)
        {
            if (Id == animals[i].Id)
            {
                return Ok(animals[i]);
            }
        }

        return NotFound();

    }
    [HttpPost]
    public IActionResult addAnimal(Animal animal)
    {
        var animals = StaticData.animals;
        animals.Add(animal);
        return Created();
    }

    [HttpPut("{Id}")]
    public IActionResult addAnimal(int Id, Animal animal)
    {
        var animals = StaticData.animals;
        int lenght = animals.Count;
        for (int i = 0; i < lenght; i++)
        {
            if (Id == animals[i].Id)
            {
                animals[i] = animal;
                return Ok();
            }
        }

        return NotFound();
    }
    [HttpDelete("{Id}")]
    public IActionResult deleteAnimal(int Id, Animal animal)
    {
        var animals = StaticData.animals;
        int lenght = animals.Count;
        for (int i = 0; i < lenght; i++)
        {
            if (Id == animals[i].Id)
            {
                animals.RemoveAt(i);
                return Ok();
            }
        }

        return NotFound();
    }
}