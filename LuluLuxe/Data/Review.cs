namespace LuluLuxe.Data
{
    public class Review
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int Rating { get; set; } // e.g., 1 to 5
        public string Comments { get; set; } = string.Empty;
    }
}
