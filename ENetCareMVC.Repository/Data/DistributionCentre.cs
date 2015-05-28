//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENetCareMVC.Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DistributionCentre
    {
        public DistributionCentre()
        {
            this.Audit = new HashSet<Audit>();
            this.PackageTransit = new HashSet<PackageTransit>();
            this.PackageTransit1 = new HashSet<PackageTransit>();
            this.Employee = new HashSet<Employee>();
            this.Package = new HashSet<Package>();
        }
    
        public int CentreId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsHeadOffice { get; set; }
    
        public virtual ICollection<Audit> Audit { get; set; }
        public virtual ICollection<PackageTransit> PackageTransit { get; set; }
        public virtual ICollection<PackageTransit> PackageTransit1 { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
