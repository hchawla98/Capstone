using System;
using System.Collections.Generic;

namespace AlphaShoeStore.Models
{
    public partial class Item
    {
        public Item()
        {
            Inventory = new HashSet<Inventory>();
        }

        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string Sku { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public string Name { get; internal set; }
    }
}
