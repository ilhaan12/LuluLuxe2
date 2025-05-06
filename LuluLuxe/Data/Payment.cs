namespace LuluLuxe.Data
{
    public class Payment
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Method { get; set; } = string.Empty; // e.g., "Card", "Cash"
    }
}
