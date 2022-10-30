namespace Imperial_Metric_Converter.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string Timestamp { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
