using Imperial_Metric_Converter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imperial_Metric_Converter.Interfaces
{
    public interface IConversionRepository
    {
        Task<IEnumerable<UnitConversion>> GetUnitConversionRates();
    }
}
