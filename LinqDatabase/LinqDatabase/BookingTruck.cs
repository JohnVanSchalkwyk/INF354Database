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
    
    public partial class BookingTruck
    {
        public int booking_id { get; set; }
        public System.DateTime booking_date_made { get; set; }
        public System.DateTime booking_departure_date { get; set; }
        public System.DateTime booking_arrival_date { get; set; }
        public string departure_street_number { get; set; }
        public string departure_street_name { get; set; }
        public string departure_street_area { get; set; }
        public string departure_city { get; set; }
        public string arrival_street_number { get; set; }
        public string arrival_street_name { get; set; }
        public string arrival_street_area { get; set; }
        public string arrival_city { get; set; }
        public int truck_id { get; set; }
        public int staff_id { get; set; }
        public int goods_id { get; set; }
        public string booking_notes { get; set; }
        public int client_id { get; set; }
        public int driver_id { get; set; }
        public Nullable<int> delivery_distance { get; set; }
    
        public virtual BookingGood BookingGood { get; set; }
        public virtual Client Client { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual TruckDriver TruckDriver { get; set; }
        public virtual Truck Truck { get; set; }
    }
}
