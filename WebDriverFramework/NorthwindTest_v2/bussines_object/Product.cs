using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.bussines_object
{
    class Product
    {
        public Product(string productName, string categoryId, string supplierId, string unitPrice,
            string quantityPerUnit, string unitsInStock, string unitsOnOrder, string reorderLevel)
        {
            ProductName = productName;
            CategoryId = categoryId;
            SupplierId = supplierId;
            UnitPrice = unitPrice;
            QuantityPerUnit = quantityPerUnit;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
        }

        public string ProductName { get; set; }

        public string CategoryId { get; set; }

        public string SupplierId { get; set; }

        public string UnitPrice { get; set; }

        public string QuantityPerUnit { get; set; }

        public string UnitsInStock { get; set; }

        public string UnitsOnOrder { get; set; }

        public string ReorderLevel { get; set; }

        public override bool Equals(object other)
        {
            var toCompareWith = other as Product;
            if (toCompareWith == null)
                return false;
            return this.ProductName == toCompareWith.ProductName &&
                this.CategoryId == toCompareWith.CategoryId &&
                this.SupplierId == toCompareWith.SupplierId &&
                this.UnitPrice == toCompareWith.UnitPrice &&
                this.QuantityPerUnit == toCompareWith.QuantityPerUnit &&
                this.UnitsInStock == toCompareWith.UnitsInStock &&
                this.UnitsOnOrder == toCompareWith.UnitsOnOrder &&
                this.ReorderLevel == toCompareWith.ReorderLevel;
        }
    }
}
