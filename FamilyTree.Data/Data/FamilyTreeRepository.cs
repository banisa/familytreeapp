using System.Collections.Generic;
using System.Linq;
using FamilyTree.ApplicationCore.Entities;
using FamilyTree.ApplicationCore.Interfaces;

namespace FamilyTree.Data.Data
{
    public class FamilyTreeRepository : IFamilyTreeRepository
    {
        private readonly FamilyTreeContext _db;

        public FamilyTreeRepository(FamilyTreeContext db)
        {
            _db = db;
        }
        public IEnumerable<Person> GetAllPersons()
        {
            return _db.Persons;
        }
        
        public IEnumerable<Child> GetChildren()
        {
            return _db.Children.OrderByDescending(x => x.Id);
        }

        public Child GetChildByPersonId(int id)
        {
            return _db.Children.FirstOrDefault(c => c.PersonId == id);
        }

        public Person GetPersonById(int id)
        {
            return _db.Persons.FirstOrDefault(p => p.Id == id);
        }

        public Parent GetParentById(int id)
        {
            var persons = _db.Persons;
            return Enumerable.FirstOrDefault(persons.Where(person => person.Parents.Count > 0).SelectMany(person => person.Parents), parent => parent.PersonId == id);
        }
    }
}
