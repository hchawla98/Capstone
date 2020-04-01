using System;
using System.Collections.Generic;

namespace AlphaShoeStore.Models
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int ItemId { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }

        public virtual Item Item { get; set; }
    }
}
