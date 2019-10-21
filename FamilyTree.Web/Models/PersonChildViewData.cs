using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FamilyTree.ApplicationCore.Entities;

namespace FamilyTree.Web.Models
{
    public class PersonChildViewData
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Child> Children { get; set; }
        public IEnumerable<Person> Persons { get; set; }
    }
}