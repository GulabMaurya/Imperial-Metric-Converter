using System;

namespace Imperial_Metric_Converter.Interfaces
{
    public interface IErrorLoggingService
    {
        void LoggingError(Exception ex);
    }
}
