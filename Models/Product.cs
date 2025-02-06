using System.ComponentModel.DataAnnotations;

namespace tourdalCommerce.Models{
    public class Product{
        [Key]
            public int ProductID { get; set; }
            public required string Product_Name { get; set; }
            public required string Prod_Description { get; set; }
            public required double Prod_Price { get; set; }
            public VendorModel vendor{get;set;}
    }
}