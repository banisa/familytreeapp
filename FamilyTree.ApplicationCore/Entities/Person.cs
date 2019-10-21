using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FamilyTree.ApplicationCore.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual List<Parent> Parents { get; set; }
    }
}
