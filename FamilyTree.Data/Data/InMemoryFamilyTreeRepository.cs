using System.Collections.Generic;
using System.Linq;
using FamilyTree.ApplicationCore.Entities;
using FamilyTree.ApplicationCore.Enums;
using FamilyTree.ApplicationCore.Interfaces;

namespace FamilyTree.Data.Data
{
   public class InMemoryFamilyTreeRepository : IFamilyTreeRepository
    {
        private List<Person> _persons;
        private List<Child> _children;

        public InMemoryFamilyTreeRepository()
        {
            _persons = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name = "Han",
                    Surname = "Solo",
                    Parents = new List<Parent>()
                    {
                        new Parent()
                        {
                            ParentId = 1,
                            PersonId = 2,
                            ParentType = ParentType.Mother
                        }
                    }
                },
                new Person()
                {
                    Id = 2,
                    Name = "Jaina",
                    Surname = "Solo",
                },
                new Person()
                {
                    Id = 3,
                    Name = "Leia",
                    Surname = "Organa",
                },
                new Person()
                {
                    Id = 4,
                    Name = "Rey",
                    Surname = "Skywalker",
                    Parents = new List<Parent>()
                    {
                        new Parent()
                        {
                            ParentId = 2,
                            PersonId = 1,
                            ParentType = ParentType.Father,
                            LivingStatus = LivingStatus.Dead
                        },
                        new Parent()
                        {
                            ParentId = 3,
                            PersonId = 3,
                            ParentType = ParentType.Mother,
                            LivingStatus = LivingStatus.Alive
                        }
                    }
                },
                new Person()
                {
                    Id = 5,
                    Name = "Anakin",
                    Surname = "Skywalker",
                },
                new Person()
                {
                    Id = 6,
                    Name = "Padmé",
                    Surname = "Amidala",
                },
                new Person()
                {
                    Id = 7,
                    Name = "Luke",
                    Surname = "Skywalker",
                    Parents = new List<Parent>()
                    {
                        new Parent()
                        {
                            ParentId = 4,
                            PersonId = 5,
                            ParentType = ParentType.Father,
                            LivingStatus = LivingStatus.Dead
                        },
                        new Parent()
                        {
                            ParentId = 5,
                            PersonId = 6,
                            ParentType = ParentType.Mother,
                            LivingStatus = LivingStatus.Alive
                        }
                    }

                },
                new Person()
                {
                    Id = 8,
                    Name = "Shmi",
                    Surname = "Skywalker",
                },
                new Person()
                {
                    Id = 9,
                    Name = "Darth",
                    Surname = "Vadar"
                },
                new Person()
                {
                    Id = 10,
                    Name = "None",
                },
            };

            _children = new List<Child>()
            {
                new Child() {Id = 1, PersonId = 9, MotherId = 8, FatherId = 10},
                new Child() {Id = 2, PersonId = 7, MotherId = 6, FatherId = 5},
                new Child() {Id = 3, PersonId = 4, MotherId = 3, FatherId = 1},
                new Child() {Id = 4, PersonId = 1, MotherId = 2},
            };
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _persons;
        }

        public IEnumerable<Child> GetChildren()
        {
            return _children;
        }

        public Child GetChildByPersonId(int id)
        {
            return _children.FirstOrDefault(c => c.Id == id);
        }

        public Person GetPersonById(int id)
        {
            return _persons.FirstOrDefault(p => p.Id == id);
        }

        public Parent GetParentById(int id)
        {
            foreach (var person in _persons)
            {
                if (person.Parents != null)
                    foreach (var parent in person.Parents)
                    {
                        if (parent.PersonId == id) return parent;
                    }
            }

            return null;
        }
    }
}
