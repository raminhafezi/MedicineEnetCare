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
    
    public partial class StandardPackageType
    {
        public StandardPackageType()
        {
            this.Audit = new HashSet<Audit>();
            this.Package = new HashSet<Package>();
        }
    
        public int PackageTypeId { get; set; }
        public string Description { get; set; }
        public int NumberOfMedications { get; set; }
        public ShelfLifeUnitType ShelfLifeUnitType { get; set; }
        public int ShelfLifeUnits { get; set; }
        public bool TemperatureSensitive { get; set; }
        public decimal Value { get; set; }
    
        public virtual ICollection<Audit> Audit { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public override string ToString() { return "Id:" + PackageTypeId + " / " + Description + " / #:" + NumberOfMedications + " / Life:" + ShelfLifeUnits + ShelfLifeUnitType + " / Val:" + Value; }

    }
}
