using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    class Product
    {
        private decimal _productId;
        private string _productCode;
        private string _productName;
        private decimal _purchaseRate;
        private decimal _salesRate;
        private decimal _minimumStock;
        private decimal _maximumStock;
        private decimal _reorderLevel;
        private string _narration;
        private bool _isActive;
        private string _productType;
        private string _dateAdded;
        private string _dateModified;
        
        private decimal ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        
        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
        
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        
        public decimal PurchaseRate
        {
            get { return _purchaseRate; }
            set { _purchaseRate = value; }
        }
        
        public decimal SalesRate
        {
            get { return _salesRate; }
            set { _salesRate = value; }
        }
        
        public decimal MinimumStock
        {
            get { return _minimumStock; }
            set { _minimumStock = value; }
        }
        
        public decimal MaximumStock
        {
            get { return _maximumStock; }
            set { _maximumStock = value; }
        }
        
        public decimal ReorderLevel
        {
            get { return _reorderLevel; }
            set { _reorderLevel = value; }
        }
        
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }
        
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public string ProductType{
            get { return _productType; }
            set { _productType = value; }
        }

        public string DateAdded
        {
            get { return _dateAdded; }
            set { _dateAdded = value; }
        }

        public string DateModified
        {
            get { return _dateModified; }
            set { _dateModified = value; }
        }

    }
}
