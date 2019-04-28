using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    //Table ready
    class Location
    {
        private string LocationId;
        private string City;
        private string JurisdictionType;
        private string JurisdictionName;
        private string Country;
        private string Address;

        public void SetLocationId(string LocationId) { this.LocationId = LocationId; }
        public void SetCity(string City) { this.City = City; }
        public void SetJurisdictionType(string JurisdictionType) { this.JurisdictionType = JurisdictionType; }
        public void SetJurisdictionName(string JurisdictionName) { this.JurisdictionName = JurisdictionName; }
        public void SetCountry(string Country) { this.Country = Country; }
        public void SetAddress(string Address) { this.Address = Address; }

        public string GetLocationId() { return this.LocationId; }
        public string GetCity() { return this.City; }
        public string GetJurisdictionType() { return this.JurisdictionType; }
        public string GetJurisdictionName() { return this.JurisdictionName; }
        public string GetCountry() { return this.Country; }
        public string GetAddress() { return this.Address; }

        DateTime _extraDate;
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }
    }
}
