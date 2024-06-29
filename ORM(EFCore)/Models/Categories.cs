using System.ComponentModel.DataAnnotations;

namespace ORM_EFCore_.Models
{
	public class Categories
	{
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
