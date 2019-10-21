using System.Collections.Generic;
using FamilyTree.ApplicationCore.Entities;

namespace FamilyTree.ApplicationCore.Interfaces
{
    public interface IFamilyTreeRepository
    {
        IEnumerable<Person> GetAllPersons();
        IEnumerable<Child> GetChildren();
        Child GetChildByPersonId(int id);
        Person GetPersonById(int id);
        Parent GetParentById(int id);
    }
}
