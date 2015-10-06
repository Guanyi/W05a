using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductData
{
    [MetadataType(typeof(ProductMetaData))]

    public partial class Product { }

    public class ProductMetaData
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public Nullable<int> SupplierID { get; set; }

        public Nullable<int> CategoryID { get; set; }

        [ScaffoldColumn(false)]
        public string QuantityPerUnit { get; set; }

        public Nullable<decimal> UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<short> UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<short> UnitsOnOrder { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<short> ReorderLevel { get; set; }

        [ScaffoldColumn(false)]
        public bool Discontinued { get; set; }
    }
}
