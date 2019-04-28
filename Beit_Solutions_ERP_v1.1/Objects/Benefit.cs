using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    class Benefit
    {
        string _benefitId;
        public string BenefitId
        {
            get { return _benefitId; }
            set { _benefitId= value; }
        }

        string _benefitName;
        public string BenefitName
        {
            get { return _benefitName; }
            set { _benefitName = value; }
        }


        bool _deductable;
        public bool Deductable
        {
            get { return _deductable; }
            set { _deductable = value; }
        }

        decimal _amount;
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public string Narration
        {
            get;
            set;
        }
        
        DateTime _extraDate;
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }

    }
}
