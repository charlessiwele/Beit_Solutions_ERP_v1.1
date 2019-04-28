using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    class Employee
    {
        private decimal _employeeId;
        public decimal EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        private decimal _designationId;
        public decimal DesignationId
        {
            get { return _designationId; }
            set { _designationId = value; }
        }

        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        private string _employeeSurname;
        public string EmployeeSurname
        {
            get { return _employeeSurname; }
            set { _employeeSurname = value; }
        }

        private string _employeeCode;
        public string EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }

        private DateTime _dob;
        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }


        private string _maritalStatus;
        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string  _qualifications;
        public string Qualifications
        {
            get { return _qualifications; }
            set { _qualifications = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _phoneNumber1;
        public string PhoneNumber1
        {
            get { return _phoneNumber1; }
            set { _phoneNumber1 = value; }
        }

        private string _phoneNumber2;
        public string PhoneNumber2
        {
            get { return _phoneNumber2; }
            set { _phoneNumber2 = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _joiningDate;
        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }

        private DateTime _terminationDate;
        public DateTime TerminationDate
        {
            get { return _terminationDate; }
            set { _terminationDate = value; }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private string _passportNo;
        public string PassportNo
        {
            get { return _passportNo; }
            set { _passportNo = value; }
        }

        private DateTime _passportExpiryDate;
        public DateTime PassportExpiryDate
        {
            get { return _passportExpiryDate; }
            set { _passportExpiryDate = value; }
        }

        private string _salaryType;
        public string SalaryType
        {
            get { return _salaryType; }
            set { _salaryType = value; }
        }

        private string _bankName;
        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        private string _branchName;
        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }
        
        private string _bankAccountNumber;
        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            set { _bankAccountNumber = value; }
        }
        
        private string _branchCode;
        public string BranchCode
        {
            get { return _branchCode; }
            set { _branchCode = value; }
        }        
    }
}
