//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElsService
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhysicalContainer : Container
    {
        public int EvidenceLocationId { get; set; }
        public string EvidenceLocationName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Capacity { get; set; }
        public string Label { get; set; }
    
        public virtual EvidenceLocation EvidenceLocation { get; set; }
    }
}