﻿namespace ENetCareMVC.Repository.Data
{
    public class ReconciledPackage
    {
        public int PackageId { get; set; }
        public string BarCode { get; set; }
        public int CurrentLocationCentreId { get; set; }
        public string CurrentLocationCentreName { get; set; }
        public PackageStatus CurrentStatus { get; set; }
        public PackageStatus NewStatus { get; set; }
    }
}
