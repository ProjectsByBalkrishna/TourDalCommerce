using System.ComponentModel.DataAnnotations;

namespace tourdalCommerce.Models{
   public  class VendorModel{
[Key]
        public int VendorID { get; set; }
        public required string VendorName { get; set; }
        public required string Password{get;set;}
        public required string VendorEmail { get; set; }
        public required int Phone { get; set; }

    }
}