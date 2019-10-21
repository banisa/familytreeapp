using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyTree.ApplicationCore.Entities
{
    [Table("Children")]
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int? MotherId { get; set; }
        public int? FatherId { get; set; }
    }
}
