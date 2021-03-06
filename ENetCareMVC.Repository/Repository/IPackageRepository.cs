﻿using System.Collections.Generic;
using ENetCareMVC.Repository.Data;

namespace ENetCareMVC.Repository.Repository
{
    public interface IPackageRepository
    {
        int Insert(Package package);
        void Update(Package package);
        Package Get(int? packageId, string barcode);
        Package GetPackageWidthBarCode(string barCode); 
        List<StandardPackageType> GetAllStandardPackageTypes();
        StandardPackageType GetStandardPackageType(int packageId);
        int InsertTransit(PackageTransit packageTransit);
        void UpdateTransit(PackageTransit packageTransit);
        PackageTransit GetTransit(Package package, DistributionCentre Receiver);
        PackageTransit GetOpenTransit(Package package);
        int InsertAudit(Employee employee, StandardPackageType packageType, List<string> barCodes);
        int UpdateLostFromAudit(int auditId, DistributionCentre location, StandardPackageType packageType);
        int UpdateInstockFromAudit(int auditId, DistributionCentre location, StandardPackageType packageType);
        int UpdateTransitReceivedFromAudit(int auditId, DistributionCentre location);
        int UpdateTransitCancelledFromAudit(int auditId, DistributionCentre location);
        List<PackageTransit> GetActiveTransitsByPackage(Package xPackage);
    }
}
