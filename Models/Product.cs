﻿using System.ComponentModel;

namespace NET_Angular.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Details { get; set; }
        public decimal UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public byte[] ProductImagePath { get; set; }
        public int CartId { get; set; }
        public int? CategoryId { get; set; }
        public int OrderLineId { get; set; }
        public int? PictureId { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
        public virtual ICollection<OrderLine> OrderLines { get; set; } = new HashSet<OrderLine>();
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual Category Categories { get; set; }
    }
}
