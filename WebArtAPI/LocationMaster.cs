//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebArtAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocationMaster
    {
        public decimal Location_PK { get; set; }
        public string LocationName { get; set; }
        public string LocationPrefix { get; set; }
        public string LocationAddress { get; set; }
        public Nullable<decimal> LocationType_PK { get; set; }
        public string LocType { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<decimal> CurrencyID { get; set; }
        public Nullable<decimal> CountryID { get; set; }
        public Nullable<decimal> PaymentModeID { get; set; }
        public Nullable<decimal> PaymentTermID { get; set; }
        public string IsActive { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
    }
}
