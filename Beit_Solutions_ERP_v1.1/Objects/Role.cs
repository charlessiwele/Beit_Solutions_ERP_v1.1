using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beit_Solutions_ERP_v1._1.Objects
{
    //Table ready
    class Role
    {
        private string _roleId;
        private string _role;
        private string _narration;
        DateTime _extraDate;

        public string RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        public string RoleName
        {
            get { return _role; }
            set { _role = value; }
        }
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }

    }
}
