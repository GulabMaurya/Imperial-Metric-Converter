using Dapper;
using Imperial_Metric_Converter.Context;
using Imperial_Metric_Converter.Interfaces;
using Imperial_Metric_Converter.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Imperial_Metric_Converter.Repository
{
    public class ErrorLoggingRepository : IErrorLoggingRepository
    {
        private readonly ConversionContext _context;

        public ErrorLoggingRepository(ConversionContext context)
        {
            _context = context;
        }

        public void AddLogEntry(ErrorLog error)
        {
            var query = "INSERT INTO Log ([Timestamp], ErrorMessage, StackTrace) VALUES (@Timestamp, @ErrorMessage, @StackTrace)";

            var parameters = new DynamicParameters();
            parameters.Add("Timestamp", System.DateTime.Now, DbType.String);
            parameters.Add("ErrorMessage", error.ErrorMessage, DbType.String);
            parameters.Add("StackTrace", error.StackTrace, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var id = connection.QuerySingleAsync<int>(query, parameters);


            }
        }
    }
}
