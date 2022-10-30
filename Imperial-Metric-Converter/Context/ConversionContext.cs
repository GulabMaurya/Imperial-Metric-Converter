using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
namespace Imperial_Metric_Converter.Context
{
    public class ConversionContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ConversionContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
