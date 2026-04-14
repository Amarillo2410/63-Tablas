using Microsoft.EntityFrameworkCore;
using ModeloTransporta.src.Modules.TypeVehicle.Infrastructure.Entity;
using ModeloTransporta.src.Modules.VehicleStatus.Infrastructure.Entity;
using ModeloTransporta.src.Modules.Vehicle.Infrastructure.Entity;
using ModeloTransporta.src.Modules.DocumentVehicle.Infrastructure.Entity;
using ModeloTransporta.src.Modules.CompanyVehicle.Infrastructure.Entity;
using ModeloTransporta.src.Modules.DriverVehicle.Infrastructure.Entity;
using ModeloTransporta.src.Modules.TypeLoad.Infrastructure.Entity;
using ModeloTransporta.src.Modules.Load.Infrastructure.Entity;
using ModeloTransporta.src.Modules.LoadDetail.Infrastructure.Entity;
using ModeloTransporta.src.Modules.LoadImage.Infrastructure.Entity;
using ModeloTransporta.src.Modules.LoadStatusHistory.Infrastructure.Entity;
using ModeloTransporta.src.Modules.StatusBid.Infrastructure.Entity;
using ModeloTransporta.src.Modules.Bid.Infrastructure.Entity;
using ModeloTransporta.src.Modules.Trip.Infrastructure.Entity;
using ModeloTransporta.src.Modules.TripAssignment.Infrastructure.Entity;
using ModeloTransporta.src.Modules.TravelScale.Infrastructure.Entity;
using ModeloTransporta.src.Modules.TripStatusHistory.Infrastructure.Entity;
using ModeloTransporta.src.Modules.PersonTransport.Infrastructure.Entity;
using ModeloTransporta.src.Modules.ReturnLoadSuggestion.Infrastructure.Entity;
using ModeloTransporta.src.Modules.Rating.Infrastructure.Entity;
using ModeloTransporta.src.Modules.Country.Infrastructure.Entity;
using ModeloTransporta.src.Modules.StateRegion.Infrastructure.Entity;
using ModeloTransporta.src.Modules.City.Infrastructure.Entity;

namespace ModeloTransporta.src.Shared;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<TypeVehicleEntity> TypeVehicles => Set<TypeVehicleEntity>();
    public DbSet<VehicleStatusEntity> VehicleStatuses => Set<VehicleStatusEntity>();
    public DbSet<VehicleEntity> Vehicles => Set<VehicleEntity>();
    public DbSet<DocumentVehicleEntity> DocumentVehicles => Set<DocumentVehicleEntity>();
    public DbSet<CompanyVehicleEntity> CompanyVehicles => Set<CompanyVehicleEntity>();
    public DbSet<DriverVehicleEntity> DriverVehicles => Set<DriverVehicleEntity>();
    public DbSet<TypeLoadEntity> TypeLoads => Set<TypeLoadEntity>();
    public DbSet<LoadEntity> Loads => Set<LoadEntity>();
    public DbSet<LoadDetailEntity> LoadDetails => Set<LoadDetailEntity>();
    public DbSet<LoadImageEntity> LoadImages => Set<LoadImageEntity>();
    public DbSet<LoadStatusHistoryEntity> LoadStatusHistories => Set<LoadStatusHistoryEntity>();
    public DbSet<StatusBidEntity> StatusBids => Set<StatusBidEntity>();
    public DbSet<BidEntity> Bids => Set<BidEntity>();
    public DbSet<TripEntity> Trips => Set<TripEntity>();
    public DbSet<TripAssignmentEntity> TripAssignments => Set<TripAssignmentEntity>();
    public DbSet<TravelScaleEntity> TravelScales => Set<TravelScaleEntity>();
    public DbSet<TripStatusHistoryEntity> TripStatusHistories => Set<TripStatusHistoryEntity>();
    public DbSet<PersonTransportEntity> PersonTransports => Set<PersonTransportEntity>();
    public DbSet<ReturnLoadSuggestionEntity> ReturnLoadSuggestions => Set<ReturnLoadSuggestionEntity>();
    public DbSet<RatingEntity> Ratings => Set<RatingEntity>();
    public DbSet<CountryEntity> Countries => Set<CountryEntity>();
    public DbSet<StateRegionEntity> StateRegions => Set<StateRegionEntity>();
    public DbSet<CityEntity> Cities => Set<CityEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompanyVehicleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new VehicleStatusEntityConfiguration());
        modelBuilder.ApplyConfiguration(new VehicleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new DocumentVehicleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TypeVehicleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new DriverVehicleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TypeLoadEntityConfiguration());
        modelBuilder.ApplyConfiguration(new LoadEntityConfiguration());
        modelBuilder.ApplyConfiguration(new LoadDetailEntityConfiguration());
        modelBuilder.ApplyConfiguration(new LoadImageEntityConfiguration());
        modelBuilder.ApplyConfiguration(new LoadStatusHistoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new StatusBidEntityConfiguration());
        modelBuilder.ApplyConfiguration(new BidEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TripEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TripAssignmentEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TravelScaleEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TripStatusHistoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new PersonTransportEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ReturnLoadSuggestionEntityConfiguration());
        modelBuilder.ApplyConfiguration(new RatingEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CountryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new StateRegionEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CityEntityConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}