//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VetClinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int id { get; set; }
        public int vet_id { get; set; }
        public int owner_id { get; set; }
        public int pet_id { get; set; }
        public System.DateTime when { get; set; }
        public string note { get; set; }
    
        public virtual Pet Pet { get; set; }
    }
}