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
    
    public partial class Package
    {
        public Package()
        {
            this.AuditPackage = new HashSet<AuditPackage>();
            this.PackageTransit = new HashSet<PackageTransit>();
        }
    
        public int PackageId { get; set; }
        public string BarCode { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public int PackageTypeId { get; set; }
        public Nullable<int> CurrentLocationCentreId { get; set; }
        public PackageStatus CurrentStatus { get; set; }
        public Nullable<int> DistributedByEmployeeId { get; set; }
    
        public virtual Employee DistributedBy { get; set; }
        public virtual ICollection<AuditPackage> AuditPackage { get; set; }
        public virtual ICollection<PackageTransit> PackageTransit { get; set; }
        public virtual StandardPackageType PackageType { get; set; }
        public virtual DistributionCentre CurrentLocation { get; set; }
    }
}
