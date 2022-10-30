using Imperial_Metric_Converter.Models;

namespace Imperial_Metric_Converter.Interfaces
{
    public interface IErrorLoggingRepository
    {
        void AddLogEntry(ErrorLog error);
    }
}
