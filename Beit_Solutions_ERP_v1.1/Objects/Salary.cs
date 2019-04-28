using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    class Salary
    {
        string _salaryPackageId;
        public string SalaryPackageId
        {
            get { return _salaryPackageId; }
            set{_salaryPackageId = value;}
        }

        string _salaryPackageName;
        public string SalaryPackageName
        {
            get{return _salaryPackageName;}
            set{_salaryPackageName = value;}
        }

        decimal _amount;
        public decimal BaseAmount
        {
            get{return _amount;}
            set{_amount=value;}
        }

        List<Benefit> _benefits = new List<Benefit>();
        public List<Benefit> Benefits
        {
            get{return _benefits;}
            set { _benefits = value; }
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
