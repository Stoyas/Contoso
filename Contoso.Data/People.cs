﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class People
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string UnitOrApartmentNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public DateTime Createddate { get; set; }
        public string CreatedBy { get; set; } // audit column
        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Boolean Islocked { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int FailedAttempts { get; set; }
    }
}
