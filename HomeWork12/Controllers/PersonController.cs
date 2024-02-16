using FluentValidation;
using HomeWork12.Database;
using HomeWork12.Interfaces;
using HomeWork12.Models;
using HomeWork12.Validators;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork12.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly IJsonDatabase _database;
    private readonly IValidator<Person> _validator;

    public PeopleController(IJsonDatabase database, IValidator<Person> validator)
    {
        _database = database;
        _validator = validator;
    }

    [HttpPost]
    public IActionResult Post([FromBody] Person person)
    {
        var validationResult = _validator.Validate(person);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        _database.Add(person);
        return Ok(person);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var people = _database.GetAll();
        return Ok(people);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var person = _database.GetById(id);
        if (person == null)
        {
            return NotFound();
        }

        return Ok(person);
    }

    [HttpGet("filter")]
    public IActionResult Get([FromQuery] string querystring)
    {
        var people = _database.Filter(querystring);
        return Ok(people);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var person = _database.GetById(id);
        if (person == null)
        {
            return NotFound();
        }

        _database.Delete(id);
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Person person)
    {
        var validationResult = _validator.Validate(person);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }

        _database.Update(id, person);
        return Ok(person);
    }
}