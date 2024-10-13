using VehicleRentalApp.Models;

namespace VehicleRentalApp.Services
{
    public interface IReservationService
    {
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<List<Reservation>> GetAllReservationsAsync();
        Task AddReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation, int id);
        Task DeleteReservationAsync(int id);
    }
}
