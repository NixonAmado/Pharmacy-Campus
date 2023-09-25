using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SupplierContact
    {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public double Stock { get; set; }
    public DateTime ExpirationDate  { get; set; }
    public int Supplier_Fk { get; set; }
    public Person Supplier {get; set; }
    public string SupplierName {get; set; }
    public string Email {get; set; }

    }
}