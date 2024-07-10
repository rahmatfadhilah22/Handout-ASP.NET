using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Categories : BaseEntity
    {
        [Key]
        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
    }
}
