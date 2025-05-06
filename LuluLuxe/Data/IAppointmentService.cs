using LuluLuxe.Data;

public interface IAppointmentService
{
    Task<List<Service>> GetAllServicesAsync();
    Task<List<Staff>> GetAllStaffAsync();
    Task CreateAppointmentAsync(Appointment appointment);
}
