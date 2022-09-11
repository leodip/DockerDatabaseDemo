﻿namespace DockerDatabaseDemo.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }

        public Order Order { get; set; } = null!;
        public int OrderId { get; set; }
    }
}
