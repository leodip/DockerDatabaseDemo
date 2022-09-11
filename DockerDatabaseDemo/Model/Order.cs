using System.ComponentModel.DataAnnotations;

namespace DockerDatabaseDemo.Model
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string Customer { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
