using System.ComponentModel.DataAnnotations;

namespace DockerDatabaseDemo.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;


        public decimal Price { get; set; }
    }
}
