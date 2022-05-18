using System.ComponentModel.DataAnnotations;

namespace RepositoryWithMVC_LastTime.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        [Required]
        [Display(Name ="Is Active")]
        public bool IsActive { get; set; } = true;
        public int CustomerId  { get; set; }
        public Customer? Customer { get; set; }
    }
}
