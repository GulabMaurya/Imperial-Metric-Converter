using Imperial_Metric_Converter.Interfaces;
using Imperial_Metric_Converter.Models;
using System;

namespace Imperial_Metric_Converter.Services
{
    public class ErrorLoggingService : IErrorLoggingService
    {
        private readonly IErrorLoggingRepository _errorLoggingRepository;
        public ErrorLoggingService(IErrorLoggingRepository errorLoggingRepository)
        {
            _errorLoggingRepository = errorLoggingRepository;
        }
        public void LoggingError(Exception ex)
        {
            ErrorLog error = new ErrorLog()
            {
                ErrorMessage = ex.Message,
                StackTrace = ex.StackTrace
            };
            _errorLoggingRepository.AddLogEntry(error);
        }
    }
}
