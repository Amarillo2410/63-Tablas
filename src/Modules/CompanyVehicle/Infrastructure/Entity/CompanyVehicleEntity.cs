using System;
namespace ModeloTransporta.src.Modules.CompanyVehicle.Infrastructure.Entity;

public class CompanyVehicleEntity
{
    public int id { get; set; }
    public DateTime assignmentDate { get; set; }
    public int vehicleId { get; set; }
    public int companyId { get; set; }
}