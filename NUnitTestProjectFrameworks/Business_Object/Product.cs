using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectFrameworks.Business_Object
{
    public class Product
    {
        public string searchProductName { get; set; }
        public string searchCategoryId { get; set; }
        public string SearchSupplierId { get; set; }
        public string searchUnitPrice { get; set; }
        public string searchQuantityPerUnit { get; set; }
        public string searchUnitsInStock { get; set; }
        public string searchUnitsOnOrder { get; set; }
        public string searchReorderLevel { get; set; }


        public Product(string searchProductName, string searchCategoryId, string SearchSupplierId, string searchUnitPrice, string searchQuantityPerUnit, string searchUnitsInStock, string searchUnitsOnOrder, string searchReorderLevel)
        {
            this.searchProductName = searchProductName;
            this.searchCategoryId = searchCategoryId;
            this.SearchSupplierId = SearchSupplierId;
            this.searchUnitPrice = searchUnitPrice;
            this.searchQuantityPerUnit = searchQuantityPerUnit;
            this.searchUnitsInStock = searchUnitsInStock;
            this.searchUnitsOnOrder = searchUnitsOnOrder;
            this.searchReorderLevel = searchReorderLevel;

        }
    }
}
