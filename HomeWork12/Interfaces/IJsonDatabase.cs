using HomeWork12.Models;

namespace HomeWork12.Interfaces;

public interface IJsonDatabase
{
    List<Person> GetAll();
    Person GetById(int id);
    void Add(Person person);
    void Delete(int id);
    void Update(int id, Person person);
    List<Person> Filter(string querystring);
}