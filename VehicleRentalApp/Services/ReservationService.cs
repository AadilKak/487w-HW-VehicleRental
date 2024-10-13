using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using VehicleRentalApp.Models;


namespace VehicleRentalApp.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ReservationsContext _context; // Assume this is your DbContext

        public ReservationService(ReservationsContext context)
        {
            _context = context;
        }

        public async Task<List<Reservation>> GetAllReservationsAsync()
        {
            var result =  _context.reservationsTable.ToList();
            return result;
        }
        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            return await _context.reservationsTable.FindAsync(id);
        }

        public async Task AddReservationAsync(Reservation reservation)
        {
            _context.reservationsTable.Add(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReservationAsync(Reservation reservation, int id)
        {
            var existingReservation = await GetReservationByIdAsync(id);
            if (existingReservation != null)
            {
                existingReservation.drivername = reservation.drivername;
                existingReservation.vehiclemodel = reservation.vehiclemodel;
                existingReservation.vehicletype = reservation.vehicletype;
                existingReservation.reservationdate = reservation.reservationdate;
                existingReservation.checkoutdate = reservation.checkoutdate;
                existingReservation.returndate = reservation.returndate;
                existingReservation.totalcost = reservation.totalcost;
                existingReservation.status = reservation.status;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteReservationAsync(int id)
        {
            var reservation = await GetReservationByIdAsync(id);
            if (reservation != null)
            {
                _context.reservationsTable.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }
    }
}
