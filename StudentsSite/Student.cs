//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShimiTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int ID { get; set; }
        public string First_name_ { get; set; }
        public string Last_name_ { get; set; }
        public System.DateTime Date_of_birth { get; set; }
        public string Israeli_ID_ { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Description_ { get; set; }
    
        public virtual City City { get; set; }
    }
}
