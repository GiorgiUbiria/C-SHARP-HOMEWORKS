using System.Web;
using FluentValidation;
using HomeWork12.Interfaces;
using HomeWork12.Models;
using HomeWork12.Validators;
using Newtonsoft.Json;

namespace HomeWork12.Database;

public class JsonDatabase : IJsonDatabase
{
    private readonly string _filePath = "database.json";
    private List<Person> _people;

    public JsonDatabase()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            _people = JsonConvert.DeserializeObject<List<Person>>(json);
        }
        else
        {
            _people = new List<Person>();
        }
    }

    public List<Person> GetAll()
    {
        return _people;
    }

    public Person GetById(int id)
    {
        if (id >= 0 && id < _people.Count)
        {
            return _people[id];
        }
        
        return null;
    }

    public void Add(Person person)
    {
        var validator = new PersonValidator();
        var result = validator.Validate(person);
        if (result.IsValid)
        {
            _people.Add(person);
            SaveChanges();
        } else
        {
            throw new ValidationException(result.Errors);
        }
    }

    public void Delete(int id)
    {
        var person = GetById(id);
        if (person != null)
        {
            _people.Remove(person);
            SaveChanges();
        }
    }

    public void Update(int id, Person person)
    {
        if (id >= 0 && id < _people.Count)
        {
            var validator = new PersonValidator();
            var result = validator.Validate(person);
            if (result.IsValid)
            {
                _people[id] = person;
                SaveChanges();
            }
            else
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
    
    public List<Person> Filter(string querystring)
    {
        var nvc = HttpUtility.ParseQueryString(querystring);
        var people = _people.AsEnumerable();

        foreach (var key in nvc.AllKeys)
        {
            switch (key.ToLower())
            {
                case "city":
                    people = people.Where(p => p.PersonAddress != null && p.PersonAddress.City == nvc[key]);
                    break;
                case "salary":
                    if (double.TryParse(nvc[key], out var salary))
                    {
                        people = people.Where(p => p.Salary > salary);
                    }
                    break;
                default:
                    people = people;
                    break;
            }
        }

        return people.ToList();
    }

    private void SaveChanges()
    {
        var json = JsonConvert.SerializeObject(_people);
        File.WriteAllText(_filePath, json);
    }
}