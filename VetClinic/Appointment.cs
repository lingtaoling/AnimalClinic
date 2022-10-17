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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.Prescriptions = new HashSet<Prescription>();
        }
    
        public int id { get; set; }
        public int vet_id { get; set; }
        public int owner_id { get; set; }
        public int pet_id { get; set; }
        public System.DateTime when { get; set; }
        public string note { get; set; }
    
        public virtual Pet Pet { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Vet Vet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
