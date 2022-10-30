using Dapper;
using Imperial_Metric_Converter.Context;
using Imperial_Metric_Converter.Interfaces;
using Imperial_Metric_Converter.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imperial_Metric_Converter.Repository
{
    public class ConversionRepository : IConversionRepository
    {
        private readonly ConversionContext _context;

        public ConversionRepository(ConversionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UnitConversion>> GetUnitConversionRates()
        {
            var query = "SELECT Id, ConversionType, ConversionRate FROM tblConversionRates";

            using (var connection = _context.CreateConnection())
            {
                var conversionRates = await connection.QueryAsync<UnitConversion>(query);
                return conversionRates.ToList();


            }
        }
    }
}
