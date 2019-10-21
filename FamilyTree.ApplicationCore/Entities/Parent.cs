using System.ComponentModel.DataAnnotations;
using FamilyTree.ApplicationCore.Enums;

namespace FamilyTree.ApplicationCore.Entities
{
    public class Parent
    {
        public int ParentId { get; set; }
        public int PersonId { get; set; }
        [Display(Name = "Parent Type")]
        public ParentType ParentType { get; set; }
        [Display(Name = "Living Status")]
        public LivingStatus LivingStatus { get; set; }
    }
}
