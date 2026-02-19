using MaintenanceWebAPI.Models;

namespace MaintenanceWebAPI.Services
{
    public interface IRepairHistoryService
    {
        List<RepairHistoryDto> GetByVehicleId(int vehicleId);
    }
}
