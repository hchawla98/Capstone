using System;
using System.Collections.Generic;

namespace AlphaShoeStore.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public long? HomePhone { get; set; }
        public long? CellPhone { get; set; }
        public string Email { get; set; }
    }
}
