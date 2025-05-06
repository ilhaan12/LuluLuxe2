public class Appointment
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime AppointmentDate { get; set; }
    public int ServiceId { get; set; }
    public int StaffId { get; set; } // <-- Add this line
}
