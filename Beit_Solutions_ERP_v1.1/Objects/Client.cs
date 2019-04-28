using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    public class Client
    {
        private string _clientId;
        private string _clientName;
        private string _clientSurname;
        private string _clientNationality;
        private string _clientType;
        private string _dob;
        private string _maritalStatus;
        private string _gender;

        private string _address1;
        private string _address2;
        private string _address3;
        private string _address4;
        private string _address5;

        private string _phoneNumber1;
        private string _phoneNumber2;
        
        private string _email;
        private string _passportNo;
        private string _clientNationalIdNo;
        private string _juristicType;
        private string _juristicTaxNo;
        private string _juristicRegistrationNo;
        private string _extraDate;

        public string ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        public string ClientSurname
        {
            get { return _clientSurname; }
            set { _clientSurname = value; }
        }

        public string ClientNationality
        {
            get { return _clientNationality; }
            set { _clientNationality = value; }
        }

        public string ClientType
        {
            get { return _clientType; }
            set { _clientType = value; }
        }

        public string Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string Address3
        {
            get { return _address3; }
            set { _address3 = value; }
        }
        public string Address4
        {
            get { return _address4; }
            set { _address4 = value; }
        }
        public string Address5
        {
            get { return _address5; }
            set { _address5 = value; }
        }

        public string PhoneNumber1
        {
            get { return _phoneNumber1; }
            set { _phoneNumber1 = value; }
        }

        public string PhoneNumber2
        {
            get { return _phoneNumber2; }
            set { _phoneNumber2 = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PassportNo
        {
            get { return _passportNo; }
            set { _passportNo = value; }
        }

        public string ClientNationalIdNo
        {
            get { return _clientNationalIdNo; }
            set { _clientNationalIdNo = value; }
        }

        public string JuristicType
        {
            get { return _juristicType; }
            set { _juristicType = value; }
        }

        public string JuristicTaxNo
        {
            get { return _juristicTaxNo; }
            set { _juristicTaxNo = value; }
        }

        public string JuristicRegistrationNo
        {
            get { return _juristicRegistrationNo; }
            set { _juristicRegistrationNo = value; }
        }

        public string LastModified
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }
    }
}
