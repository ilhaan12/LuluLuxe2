using LuluLuxe.Data;
using Microsoft.EntityFrameworkCore;

public class AppointmentService : IAppointmentService
{
    private readonly ApplicationDbContext _context;

    public AppointmentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Service>> GetAllServicesAsync()
    {
        return await _context.Services.ToListAsync();
    }

    public async Task<List<Staff>> GetAllStaffAsync()
    {
        return await _context.Staff.ToListAsync();
    }

    public async Task CreateAppointmentAsync(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();
    }
}
