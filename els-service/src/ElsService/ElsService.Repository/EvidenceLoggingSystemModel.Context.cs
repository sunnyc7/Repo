﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EvidenceLoggingSystemStoreContainer : DbContext
    {
        public EvidenceLoggingSystemStoreContainer()
            : base("name=EvidenceLoggingSystemStoreContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContainerType> ContainerTypes { get; set; }
        public virtual DbSet<DataTransferType> DataTransferTypes { get; set; }
        public virtual DbSet<DispositionState> DispositionStates { get; set; }
        public virtual DbSet<EvidenceHandler> EvidenceHandlers { get; set; }
        public virtual DbSet<EvidenceLocation> EvidenceLocations { get; set; }
        public virtual DbSet<ReasonForTransfer> ReasonForTransfers { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<DataTransfer> DataTransfers { get; set; }
        public virtual DbSet<ContainerSubtype> ContainerSubtypes { get; set; }
        public virtual DbSet<ContainerBusinessProjectMapping> ContainerBusinessProjectMappings { get; set; }
        public virtual DbSet<Custody> Custodies { get; set; }
    
        public virtual int ContainerDelete(Nullable<long> id, string deletedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(long));
    
            var deletedByParameter = deletedBy != null ?
                new ObjectParameter("DeletedBy", deletedBy) :
                new ObjectParameter("DeletedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ContainerDelete", idParameter, deletedByParameter);
        }
    
        public virtual int DigitalContainerDelete(Nullable<long> id, string deletedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(long));
    
            var deletedByParameter = deletedBy != null ?
                new ObjectParameter("DeletedBy", deletedBy) :
                new ObjectParameter("DeletedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DigitalContainerDelete", idParameter, deletedByParameter);
        }
    
        public virtual int PhysicalContainerDelete(Nullable<long> id, string deletedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(long));
    
            var deletedByParameter = deletedBy != null ?
                new ObjectParameter("DeletedBy", deletedBy) :
                new ObjectParameter("DeletedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PhysicalContainerDelete", idParameter, deletedByParameter);
        }
    
        public virtual int DataTransferDelete(Nullable<long> id, string deletedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(long));
    
            var deletedByParameter = deletedBy != null ?
                new ObjectParameter("DeletedBy", deletedBy) :
                new ObjectParameter("DeletedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DataTransferDelete", idParameter, deletedByParameter);
        }
    
        public virtual int ContainerBusinessProjectMappingDelete(Nullable<long> id, string deletedBy)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(long));
    
            var deletedByParameter = deletedBy != null ?
                new ObjectParameter("DeletedBy", deletedBy) :
                new ObjectParameter("DeletedBy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ContainerBusinessProjectMappingDelete", idParameter, deletedByParameter);
        }
    }
}