//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TruckMaintenance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TruckMaintenance()
        {
            this.Trucks = new HashSet<Truck>();
        }
    
        public int maintenance_id { get; set; }
        public int kilos_serviced { get; set; }
        public System.DateTime date_last_service { get; set; }
        public System.DateTime date_tires_renewed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Truck> Trucks { get; set; }
    }
}
