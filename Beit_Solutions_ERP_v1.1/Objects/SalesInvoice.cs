using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{

    class SalesInvoice
    {
        private decimal _salesInvoiceId;
        private decimal _productId;
        private decimal _qty;
        private decimal _discount;
        private decimal _taxAmount;
        private decimal _subTotalAmount;
        private decimal _netAmount;

        private DateTime _date;
        private decimal _employeeId;
        private string _narration;
        private string _customerName;
        private string _customerId;

        public decimal SalesInvoiceId
        {
            get { return _salesInvoiceId; }
            set { _salesInvoiceId = value; }
        }
   
        public decimal ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public decimal Quantity
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public decimal TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        public decimal SubTotalAmount
        {
            get { return _subTotalAmount; }
            set { _subTotalAmount = value; }
        }

        public decimal NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public decimal EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
    }
}
